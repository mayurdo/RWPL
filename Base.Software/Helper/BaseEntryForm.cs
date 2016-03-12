using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using RWPLEntityModel;

namespace Base.Software.Helper
{
    public abstract class BaseEntryForm<TEntity>
        where TEntity : IEntity, new()
    {
        protected IServices _services;
        protected TEntity _entity;

        private readonly Control _form;

        protected readonly List<Control> _bindControls;

        protected List<Control> _bindGridControls;

        protected bool HasGridForm = false;

        public BaseEntryForm(Control form, long srNo = 0)
        {
            _services = new WinServices(typeof(TEntity).Name);
            _form = form;

            _bindControls = GetBindControls(form);

            BindEvents(form);

            if (_bindControls.Any(x => !string.IsNullOrEmpty(x.AccessibleDescription) && x.AccessibleDescription.Contains(AccDescription.AppData.ToString())))
            {
                var appDataControls = _bindControls.Where(x => !string.IsNullOrEmpty(x.AccessibleDescription) && x.AccessibleDescription.Contains(AccDescription.AppData.ToString()));
                FillDropDownAndAutoCompleteByApplicationData(appDataControls);
            }


            _entity = GetEntityById(srNo);
        }

        #region method called in controller

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

        private TEntity GetEntityById(long srNo = 0)
        {
            if (srNo == 0)
            {
                return new TEntity();
            }

            var response = _services.GetEntityByIdServiceResponse<TEntity>(srNo);

            if (response.IsSuccess)
                return response.Object;

            MessageBox.Show(response.Exception.Message, @"Error Message");
            ((Form)_form).Close();

            return new TEntity();
        }

        protected void FillDropDownAndAutoCompleteByApplicationData(IEnumerable<Control> bindControls)
        {
            var appDataControls = bindControls.Where(x => x.AccessibleDescription.Contains(AccDescription.AppData.ToString()));

            foreach (var control in appDataControls)
            {
                var bindTextIndex = control.Name.IndexOf("Bind", System.StringComparison.Ordinal);
                var propertyName = control.Name.Substring(bindTextIndex + 4);
                var accessibleName = string.IsNullOrEmpty(control.AccessibleName) ? propertyName : control.AccessibleName;

                string[] dataList;
                switch (accessibleName)
                {
                    case "CustomerName":
                        dataList = PageHelper.ApplicationData.Customers.Select(x => x.CustomerName).Distinct().ToArray();
                        control.LostFocus += CustomerNameChange;
                        break;
                    case "ItemCode":
                        dataList = PageHelper.ApplicationData.Items.Select(x => x.ItemCode).Distinct().ToArray();
                        control.LostFocus += ItemCodeChange;
                        break;
                    case "ItemName":
                        dataList = PageHelper.ApplicationData.Items.Select(x => x.ItemName).Distinct().ToArray();
                        break;
                    case "ReelNo":
                        dataList = PageHelper.ApplicationData.Stocks.Select(x => x.ReelNo).Distinct().ToArray();
                        control.LostFocus += ReelNoChange;
                        break;
                    default:
                        continue;
                }

                if (control is TextBox)
                {
                    var itemCollection = new AutoCompleteStringCollection();
                    itemCollection.AddRange(dataList);
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
        #endregion



        #region Save

        protected virtual void SavePageData(object sender, EventArgs e)
        {
            if (!ValidateControls(_bindControls))
            {
                return;
            }

            BindEntityModelWithControls(_bindControls, ref _entity);

            ResultResponse<TEntity> response;

            if (_entity.SrNo == 0)
            {
                _entity.CreatedBy = PageHelper.UserDetail.UserName;
                _entity.CreatedDate = DateTime.Now;
                response = _services.SaveServiceResponse(_entity);
            }
            else
            {
                _entity.UpdatedBy = PageHelper.UserDetail.UserName;
                _entity.UpdatedDate = DateTime.Now;
                response = _services.EditServiceResponse(_entity);

            }


            if (!response.IsSuccess)
            {
                MessageBox.Show(response.Exception.Message, @"Error Message");
                return;
            }

            ResetBindingControls(_bindControls);

            _entity = new TEntity();
        }

        protected bool ValidateControls(List<Control> bindControls)
        {
            foreach (var control in bindControls)
            {
                var controlName = control.Name;

                if (string.IsNullOrEmpty(control.AccessibleDescription) || !control.AccessibleDescription.Contains("Req"))
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
                        value = control.Name.Contains("Time") ? ((DateTimePicker)control).Value : ((DateTimePicker)control).Value.Date;
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

                var propertyName = controlName.Substring(bindTextIndex + 4);// 4 for bind
                var propertyInfo = entity.GetType().GetProperty(propertyName);
                if (propertyInfo == null)
                    throw new Exception(@"Property name not match with control name");

                propertyInfo.SetValue(entity, ChangeType(value, propertyInfo.PropertyType), null);
            }
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

                if (!string.IsNullOrEmpty(control.AccessibleDescription)
                        && control.AccessibleDescription.Contains(AccDescription.NotReset.ToString()))
                    continue;

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

        #endregion





        public void FillDropDownAndAutoComplete<TPageDataRequest>()
        {
            var pageDataResponse = _services.GetEntryPageDataServiceResponse<TPageDataRequest>();

            if (!pageDataResponse.IsSuccess)
            {
                MessageBox.Show(pageDataResponse.Exception.Message, @"Error Message On Page Data Request");
                return;
            }

            var pageData = pageDataResponse.Object;

            FillDropDownAndAutoComplete(pageData, _bindControls);

            if (HasGridForm)
                FillDropDownAndAutoComplete(pageData, _bindGridControls);
        }

        protected void FillDropDownAndAutoComplete<TPageDataRequest>(TPageDataRequest pageData, List<Control> controls)
        {
            if (pageData == null)
                return;

            foreach (Control control in controls)
            {
                var bindTextIndex = control.Name.IndexOf("Bind", System.StringComparison.Ordinal);
                var propertyName = control.Name.Substring(bindTextIndex + 4);// 4 for bind

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



        protected void BindControlsWithEntityModel<T>(List<Control> bindControls, T entity)
        {
            foreach (var control in bindControls)
            {
                var controlName = control.Name;

                if (!controlName.Contains("Bind"))
                    continue;

                var bindTextIndex = controlName.IndexOf("Bind", System.StringComparison.Ordinal);
                var controlType = controlName.Substring(0, bindTextIndex);

                var propertyName = controlName.Substring(bindTextIndex + 4);// 4 for bind
                var propertyInfo = entity.GetType().GetProperty(propertyName);
                if (propertyInfo == null)
                    throw new Exception(@"Property name not match with control name");

                var value = propertyInfo.GetValue(entity, null); // For .NET 3.5

                switch (controlType)
                {
                    case "txt":
                    case "cmb":
                        control.Text = (value == null) ? string.Empty : value.ToString();
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


        protected void BindEvents(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (string.IsNullOrEmpty(control.AccessibleDescription))
                    continue;

                var accDescriptionList = control.AccessibleDescription.Split('.');

                if (accDescriptionList.Contains(AccDescription.Back.ToString()))
                    control.Click += CloseForm;

                if (accDescriptionList.Contains(AccDescription.Num.ToString()))
                    control.KeyPress += AcceptOnlyNumber;

                if (accDescriptionList.Contains(AccDescription.NumMultComa.ToString()))
                    control.KeyPress += AcceptOnlyNumberWithMultiplyAndCommas;

                if (accDescriptionList.Contains(AccDescription.Dec.ToString()))
                    control.KeyPress += AcceptOnlyDecimal;

                if (accDescriptionList.Contains(AccDescription.Save.ToString()))
                    control.Click += SavePageData;

                BindAditionalEvent(control, accDescriptionList);
            }
        }

        protected abstract void BindAditionalEvent(Control control, string[] accDescriptionList);

        private void CloseForm(object sender, EventArgs e)
        {
            var findForm = ((Control)sender).FindForm();

            if (findForm != null)
                findForm.Close();
        }


        private void AcceptOnlyNumber(object sender, KeyPressEventArgs e)
        {
            PageHelper.AcceptOnlyNumber(e);
        }

        private void AcceptOnlyNumberWithMultiplyAndCommas(object sender, KeyPressEventArgs e)
        {
            PageHelper.AcceptOnlyNumberWithMultiplyAndCommas(e, ((TextBox)sender).Text);
        }

        private void AcceptOnlyDecimal(object sender, KeyPressEventArgs e)
        {
            PageHelper.AcceptOnlyDecimal(e, ((TextBox)sender).Text);
        }


        private void ItemCodeChange(object sender, EventArgs e)
        {
            var controls = HasGridForm ? _bindGridControls : _bindControls;

            var itemNameControl = controls.SingleOrDefault(x => (string.IsNullOrEmpty(x.AccessibleName)
                                            ? x.Name.Substring(x.Name.IndexOf("Bind", System.StringComparison.Ordinal) + 4)
                                            : x.AccessibleName) == @"ItemName");

            if (itemNameControl == null)
                return;

            var item = PageHelper.ApplicationData.Items.SingleOrDefault(x => x.ItemCode == ((TextBox)sender).Text);
            if (item == null)
            {
                itemNameControl.Text = string.Empty;
                return;
            }

            itemNameControl.Text = item.ItemName;
        }

        private void CustomerNameChange(object sender, EventArgs e)
        {
            var controls = _bindControls;

            var addressControl = controls.SingleOrDefault(x => (string.IsNullOrEmpty(x.AccessibleName)
                                            ? x.Name.Substring(x.Name.IndexOf("Bind", System.StringComparison.Ordinal) + 4)
                                            : x.AccessibleName) == @"Address");

            var contactPersonControl = controls.SingleOrDefault(x => (string.IsNullOrEmpty(x.AccessibleName)
                                            ? x.Name.Substring(x.Name.IndexOf("Bind", System.StringComparison.Ordinal) + 4)
                                            : x.AccessibleName) == @"ContactPerson");

            var customer = PageHelper.ApplicationData.Customers.SingleOrDefault(x => x.CustomerName == ((TextBox)sender).Text);

            if (addressControl != null)
            {
                addressControl.Text = (customer == null) ? string.Empty : customer.Address;
            }

            if (contactPersonControl != null)
            {
                contactPersonControl.Text = (customer == null) ? string.Empty : customer.ContactPerson;
            }
        }

        private void ReelNoChange(object sender, EventArgs e)
        {
            var controls = HasGridForm ? _bindGridControls : _bindControls;

            var bfControl = controls.SingleOrDefault(x => (x.Name.Substring(x.Name.IndexOf("Bind", System.StringComparison.Ordinal) + 4) == @"BF"));
            var gsmControl = controls.SingleOrDefault(x => (x.Name.Substring(x.Name.IndexOf("Bind", System.StringComparison.Ordinal) + 4) == @"GSM"));
            var sizeControl = controls.SingleOrDefault(x => (x.Name.Substring(x.Name.IndexOf("Bind", System.StringComparison.Ordinal) + 4) == @"Size"));
            var millControl = controls.SingleOrDefault(x => (x.Name.Substring(x.Name.IndexOf("Bind", System.StringComparison.Ordinal) + 4) == @"Mill"));


            var stock = PageHelper.ApplicationData.Stocks.SingleOrDefault(x => x.ReelNo == ((TextBox)sender).Text);

            if (bfControl != null)
                bfControl.Text = (stock == null) ? string.Empty : stock.BF.ToString(CultureInfo.InvariantCulture);

            if (gsmControl != null)
                gsmControl.Text = (stock == null) ? string.Empty : stock.GSM.ToString(CultureInfo.InvariantCulture);

            if (sizeControl != null)
                sizeControl.Text = (stock == null) ? string.Empty : stock.Size.ToString(CultureInfo.InvariantCulture);

            if (millControl != null)
                millControl.Text = (stock == null) ? string.Empty : stock.Mill;
        }
    }

    enum AccDescription
    {
        Req,
        Num,
        NumMultComa,
        Dec,
        AppData,
        Save,
        Back,
        AddItem,
        DeleteItem,
        NotReset
    }
}