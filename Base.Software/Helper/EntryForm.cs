using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software;
using RWPLEntityModel;

namespace Base.Software.Helper
{
    public class EntryForm<TEntity> : BaseEntryForm<TEntity> where TEntity : IEntity, new()
    {
        private IServices _services;
        private TEntity _entity;

        private readonly Control _form;

        private readonly List<Control> _bindControls;

        public EntryForm(Control form, long srNo = 0)
        {
            _services = new WinServices(typeof(TEntity).Name);
            _form = form;

            _bindControls = GetBindControls(form);

            _entity = GetEntityById(srNo);

            if (_entity.SrNo != 0)
                BindControlsWithEntityModel(_bindControls, _entity);
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



        public void SavePageData()
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
        }

        public void FillDropDownAndAutoCompleteByApplicationData()
        {
            var accessibleControls = _bindControls.Where(x => !string.IsNullOrEmpty(x.AccessibleName));

            foreach (var control in accessibleControls)
            {
                string[] dataList;
                switch (control.AccessibleName)
                {
                    case "CustomerName":
                        dataList = PageHelper.ApplicationData.Customers.Select(x => x.CustomerName).Distinct().ToArray();
                        break;
                    case "ItemCode":
                        dataList = PageHelper.ApplicationData.Items.Select(x => x.ItemCode).Distinct().ToArray();
                        control.LostFocus += ItemCodeChange;
                        break;
                    case "ItemName":
                        dataList = PageHelper.ApplicationData.Items.Select(x => x.ItemName).Distinct().ToArray();
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

        private void ItemCodeChange(object sender, EventArgs e)
        {
            var itemNameControl = _bindControls.SingleOrDefault(x => x.AccessibleName == @"ItemName");

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

    }
}
