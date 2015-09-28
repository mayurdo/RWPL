using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using RWPLEntityModel;
using Base.Software;
using RWPLLinqDataService;

namespace Base.Software.Helper
{
    public class ReportForm<TReport, TSearch,TEntity>
        where TSearch : ReportRequest, new()
        where TEntity : IEntity
    {
        private IServices _services;
        private ResultResponse<TReport> _response;
        private readonly TSearch _searchRequest;
        private int _totalPage;


        public Control _form { get; set; }
        public DataGridView dataGridView1 { get; set; }
        public BindingSource bindingSource1 { get; set; }
        public BindingNavigator bindingNavigator1 { get; set; }
        public Label _lblReportStatus;
        public Label _lblReportSummary;
        public TextBox bindingNavigatorPositionItem;

        protected string PrimaryKeyName { get; set; }

        public UserAccessPage UserAccessPage
        {
            get { return PageHelper.UserDetail.UserAccessPages.Single(x => x.PageName == typeof (TEntity).Name); }
        }



        public ReportForm(Control form, BindingNavigator bindingNavigator, DataGridView dataGridView, TextBox txtPageNo,
            Label labelReportStatus, Label lblReportSummary)
        {
            bindingSource1 = new BindingSource();
            bindingNavigator1 = bindingNavigator;
            dataGridView1 = dataGridView;
            bindingNavigatorPositionItem = txtPageNo;
            _lblReportStatus = labelReportStatus;
            _lblReportSummary = lblReportSummary;
            _form = form;

            _services = new WinServices(typeof (TEntity).Name);

            PrimaryKeyName = "SrNo";

            _searchRequest = new TSearch();
        }


        #region Report

        public void BindGridViewWithFilter()
        {
            BindSearchModelWithControls();

            BindGridView();

            var extraPage = (_response.TotalItem % _searchRequest.PageSize) > 0 ? 1 : 0;
            _totalPage = ((int)(_response.TotalItem / _searchRequest.PageSize) + extraPage);

            bindingSource1.DataSource = Enumerable.Range(1, _totalPage);
            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void BindSearchModelWithControls()
        {
            foreach (Control control in _form.Controls)
            {
                var controlName = control.Name;

                if (!controlName.Contains("Bind"))
                    continue;

                object value;
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
                    default:
                        value = null;
                        break;
                }

                var propertyName = controlName.Substring(bindTextIndex + 4);
                var propertyInfo = _searchRequest.GetType().GetProperty(propertyName);
                if (propertyInfo == null)
                    throw new Exception(@"Property name not match with control name");

                propertyInfo.SetValue(_searchRequest, Convert.ChangeType(value, propertyInfo.PropertyType), null);
            }

        }

        private void BindGridView()
        {
            _response = _services.GetServiceResponse<TReport>(_searchRequest);

            if (!_response.IsSuccess)
            {
                MessageBox.Show(_response.Exception.Message, @"Error Message");
                return;
            }

            dataGridView1.DataSource = _response.PageData;
            PageHelper.ColumnFormating(dataGridView1);
            _lblReportStatus.Text = string.Format("Total : {0}", _response.TotalItem);
            _lblReportSummary.Text = string.Format("Report Summary :-   {0}", _response.ReportSummary);
        }

       

        public void FillDropDownAndAutoComplete<TPageDataRequest>()
        {
            var pageDataResponse = _services.GetReportPageDataServiceResponse<TPageDataRequest>();

            if (!pageDataResponse.IsSuccess)
            {
                MessageBox.Show(pageDataResponse.Exception.Message, @"Error Message On Page Data Request");
                return;
            }

            var pageData = pageDataResponse.Object;

            foreach (Control control in _form.Controls)
            {
                var bindTextIndex = control.Name.IndexOf("Bind", System.StringComparison.Ordinal);
                var propertyName = control.Name.Substring(bindTextIndex + 4);

                var propertyInfo = pageData.GetType().GetProperty(propertyName);
                if (propertyInfo == null)
                    continue;

                var dataList = propertyInfo.GetValue(pageData,null); // .net 3.5

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

        #endregion


        public void AddNewPage<TForm>() where TForm : Form, new()
        {
            if (!UserAccessPage.Add)
            {
                MessageBox.Show(@"You Don't have add new record, Please contact your administrator", @"Access Message");
                return;
            }

            var frm = new TForm();
            frm.ShowDialog();

            BindGridViewWithFilter();
        }

        public void EditPage<TForm>() where TForm : Form, new()
        {
            if (!UserAccessPage.Edit)
            {
                MessageBox.Show(@"You Don't have add new record, Please contact your administrator", @"Access Message");
                return;
            }

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show(@"Please select data to edit", @"Validation Message", MessageBoxButtons.OK);
                return;
            }

            var srNo = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[PrimaryKeyName].Value);

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), srNo);
            frm.ShowDialog();

            BindGridViewWithFilter();
        }

        public void DeleteSelectedData()
        {
            if (!UserAccessPage.Delete)
            {
                MessageBox.Show(@"You Don't have add new record, Please contact your administrator", @"Access Message");
                return;
            }

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show(@"Please select data to edit", @"Validation Message", MessageBoxButtons.OK);
                return;
            }

            var srNo = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[PrimaryKeyName].Value);

            var dialogResult = MessageBox.Show(string.Format("Do you want to delete selected data with SrNo : {0}", srNo),
                @"Confirmation Message", MessageBoxButtons.YesNo);

            if(dialogResult==DialogResult.No)
                return;

            var deletedBy = PageHelper.UserDetail.UserName;
            var deleteReason = "";
            var pageDataResponse = _services.DeleteServiceResponse<TEntity>(srNo, deletedBy, deleteReason);

            if (!pageDataResponse.IsSuccess)
            {
                MessageBox.Show(pageDataResponse.Exception.Message, @"Error Message On Page Data Request", MessageBoxButtons.OK);
                return;
            }

            BindGridViewWithFilter();

        }

    }
}