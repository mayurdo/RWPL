using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using RWPLEntityModel;

namespace Base.Software.Helper
{
    public class BaseEntryForm<TEntity>
        where TEntity : IEntity, new()
    {
        protected List<Control> GetBindControls(Control container)
        {
            var listControls = new List<Control>();

            foreach (Control control in container.Controls)
            {
                var controlName = control.Name;

                if (!controlName.Contains("Bind"))
                    continue;

                listControls.Add(control);
            }

            return listControls.OrderBy(x => x.TabIndex).ToList();
        }

        protected bool ValidateControls(List<Control> bindControls)
        {
            foreach (var control in bindControls)
            {
                var controlName = control.Name;

                if (!controlName.Contains("BindR"))
                    continue;

                var bindTextIndex = controlName.IndexOf("Bind", System.StringComparison.Ordinal);
                var controlType = controlName.Substring(0, bindTextIndex);

                switch (controlType)
                {
                    case "txt":
                    case "cmb":
                        if (control.Text == string.Empty)
                        {
                            control.Focus();
                            MessageBox.Show(@"Please fill required field", @"Validation Message", MessageBoxButtons.OK);
                            return false;
                        }
                        break;
                    case "grpGrid":
                        if (((DataGridView)control.Controls["dataGridView1"]).RowCount <= 0)
                        {
                            MessageBox.Show(@"Please add Items", @"Validation Message", MessageBoxButtons.OK);
                            return false;
                        }
                        break;
                    default:
                        throw new Exception(string.Format("{0} control type not define for validation", controlType));
                }
            }

            return true;
        }

        protected void BindEntityModelWithControls<T>(List<Control> bindControls, ref T entity)
        {
            foreach (var control in bindControls)
            {
                var controlName = control.Name;

                if (!controlName.Contains("Bind") || controlName.Contains("SrNo"))
                    continue;

                object value; // For .NET 3.5
                var bindTextIndex = controlName.IndexOf("Bind", System.StringComparison.Ordinal);
                var controlType = controlName.Substring(0, bindTextIndex);

                switch (controlType)
                {
                    case "txt":
                    case "cmb":
                        value = control.Text;
                        break;
                    case "cb":
                        value = ((CheckBox)control).Checked;
                        break;
                    case "dtp":
                        value = ((DateTimePicker)control).Value;
                        break;
                    case "grpRadio":
                        value = GetValueFromRadioGroupControl(control);
                        break;
                    case "grpGrid":
                        value = ((DataGridView)control.Controls["dataGridView1"]).DataSource;
                        break;
                    default:
                        value = null;
                        break;
                }

                var propertyName = controlName.Substring(bindTextIndex + 5);// 4 for bind and 1 for R/N validation
                var propertyInfo = entity.GetType().GetProperty(propertyName);
                if (propertyInfo == null)
                    throw new Exception(@"Property name not match with control name");

                propertyInfo.SetValue(entity, ChangeType(value, propertyInfo.PropertyType), null);
            }
        }

        private object ChangeType(object value, Type conversion)
        {
            var t = conversion;

            if (t.IsGenericType && (t.GetGenericTypeDefinition() == typeof(Nullable<>)))
            {
                if (value == null || string.IsNullOrEmpty(value.ToString()))
                {
                    return null;
                }

                t = Nullable.GetUnderlyingType(t);
            }

            if (t.IsGenericType && ((t.GetGenericTypeDefinition() == typeof(ICollection<>))))
            {
                return value;
            }

            if (t.IsGenericType && ((t.GetGenericTypeDefinition() == typeof(EntitySet<>))))
            {
                var methodInfo = t.GetMethod("AddRange");
                var classInstance = Activator.CreateInstance(t, null);
                methodInfo.Invoke(classInstance, new[] { value });

                return classInstance;
            }



            return Convert.ChangeType(value, t);
        }

        private string GetValueFromRadioGroupControl(Control groupControl)
        {
            foreach (Control control in groupControl.Controls)
            {
                if ((control is RadioButton) && ((RadioButton)control).Checked)
                {
                    return ((RadioButton)control).Text;
                }
            }

            return string.Empty;
        }

        protected void ResetBindingControls(List<Control> bindControls)
        {
            foreach (Control control in bindControls)
            {
                var controlName = control.Name;

                if (!controlName.Contains("Bind"))
                    continue;

                var bindTextIndex = controlName.IndexOf("Bind", System.StringComparison.Ordinal);
                var controlType = controlName.Substring(0, bindTextIndex);

                switch (controlType)
                {
                    case "txt":
                    case "cmb":
                        control.Text = string.Empty;
                        break;
                    case "cb":
                        ((CheckBox)control).Checked = false;
                        break;
                    case "dtp":
                        ((DateTimePicker)control).Value = DateTime.Now;
                        break;
                    case "grpRadio":
                        break;
                    case "grpGrid":
                        ((DataGridView)control.Controls["dataGridView1"]).DataSource = null;
                        break;
                    default:
                        throw new Exception(string.Format("{0} control type not find", controlType));
                }
            }

            bindControls.First().Focus();
        }


        protected void BindControlsWithEntityModel<T>(List<Control> bindControls, T entity)
        {
            foreach (var control in bindControls)
            {
                var controlName = control.Name;

                if (!controlName.Contains("Bind"))
                    continue;

                var bindTextIndex = controlName.IndexOf("Bind", System.StringComparison.Ordinal);
                var controlType = controlName.Substring(0, bindTextIndex);

                var propertyName = controlName.Substring(bindTextIndex + 5);// 4 for bind and 1 for R/N validation
                var propertyInfo = entity.GetType().GetProperty(propertyName);
                if (propertyInfo == null)
                    throw new Exception(@"Property name not match with control name");

                var value = propertyInfo.GetValue(entity, null); // For .NET 3.5

                switch (controlType)
                {
                    case "txt":
                    case "cmb":
                        control.Text = value.ToString();
                        break;
                    case "cb":
                        ((CheckBox)control).Checked = (bool)value;
                        break;
                    case "dtp":
                        ((DateTimePicker)control).Value = (DateTime)value;
                        break;
                    case "grpRadio":
                        SetValueFromRadioGroupControl(control, value.ToString());
                        break;
                    case "grpGrid":
                        SetGridDataFromEntity(control, value);
                        break;
                    default:
                        value = null;
                        break;
                }
            }
        }

        protected void SetValueFromRadioGroupControl(Control groupControl, string value)
        {
            foreach (Control control in groupControl.Controls)
            {
                if ((control is RadioButton) && ((RadioButton)control).Text == value)
                {
                    ((RadioButton)control).Checked = true;
                }
            }
        }

        protected virtual void SetGridDataFromEntity(Control control, object value)
        { }

        protected virtual object GetEntitySet()
        {
            return new object();
        }

        protected void FillDropDownAndAutoComplete<TPageDataRequest>(TPageDataRequest pageData, List<Control> controls)
        {
            if (pageData == null)
                return;

            foreach (Control control in controls)
            {
                var bindTextIndex = control.Name.IndexOf("Bind", System.StringComparison.Ordinal);
                var propertyName = control.Name.Substring(bindTextIndex + 5);

                var propertyInfo = pageData.GetType().GetProperty(propertyName);
                if (propertyInfo == null)
                    continue;

                var dataList = propertyInfo.GetValue(pageData, null);// For .NET 3.5

                if (control is TextBox)
                {
                    var itemCollection = new AutoCompleteStringCollection();
                    itemCollection.AddRange(((List<String>)dataList).ToArray());
                    ((TextBox)control).AutoCompleteCustomSource = itemCollection;
                    ((TextBox)control).AutoCompleteMode = AutoCompleteMode.Suggest;
                    ((TextBox)control).AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).DataSource = dataList;
                    ((ComboBox)control).Text = string.Empty;
                }
            }
        }
    }
}