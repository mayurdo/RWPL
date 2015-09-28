using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Base.Software;
using RWPLEntityModel;
using Control = System.Windows.Forms.Control;

namespace Base.Software.Helper
{
    public class EntryWithGridForm<TEntity, TGridEntity> : BaseEntryForm<TEntity>
        where TEntity : IEntity, new()
        where TGridEntity : IEntity, new()
    {
        private IServices _services;
        private TEntity _entity;

        private List<TGridEntity> _gridEntities;

        private readonly Control _form;

        private DataGridView _dataGridView;

        private readonly List<Control> _bindControls;

        private readonly List<Control> _bindGridControls;

        public EntryWithGridForm(Control form, long srNo = 0)
        {
            var grpGridControlName = @"grpGridBindR" + typeof(TGridEntity).Name + "s";

            _services = new WinServices(typeof(TEntity).Name);
            _form = form;
            _dataGridView = (DataGridView)form.Controls[grpGridControlName].Controls[@"dataGridView1"];

            _bindControls = GetBindControls(form);

            _bindGridControls = GetBindControls(form.Controls[grpGridControlName]);


            _entity = GetEntityById(srNo);

            _gridEntities = new List<TGridEntity>();

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

        #region Add Grid Item

        public void AddGridItem()
        {
            if (!ValidateControls(_bindGridControls))
            {
                return;
            }

            var gridEntity = new TGridEntity();
            gridEntity.CreatedBy = PageHelper.UserDetail.UserName;
            gridEntity.CreatedDate = DateTime.Now;
            BindEntityModelWithControls<TGridEntity>(_bindGridControls, ref gridEntity);

            _gridEntities.Add(gridEntity);

            BindItemDataGridView();

            ResetBindingControls(_bindGridControls);
        }

        public void DeleteGridItem()
        {
            if (_dataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show(@"Please select item for delete", @"Validation Message", MessageBoxButtons.OK);
                return;
            }

            foreach (DataGridViewRow item in _dataGridView.SelectedRows)
            {
                var gridEntity = _gridEntities[item.Index];
                gridEntity.DeletedBy = PageHelper.UserDetail.UserName;
                gridEntity.DeletedDate = DateTime.Now;
                gridEntity.IsDeleted = true;
            }

            BindItemDataGridView();
        }

        private void BindItemDataGridView()
        {
            _dataGridView.DataSource = _gridEntities.ToList();
            PageHelper.ColumnFormating(_dataGridView);
            _dataGridView.Columns["SrNo"].Visible = false;
            _dataGridView.Columns[typeof(TEntity).Name].Visible = false;
            _dataGridView.Columns[typeof(TEntity).Name + "_SrNo"].Visible = false;

            //var currencyManager1 = (CurrencyManager)BindingContext[_dataGridView.DataSource];
            //currencyManager1.SuspendBinding();
            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["IsDeleted"].Value))
                {
                    _dataGridView.CurrentCell = null;
                    row.Visible = false;
                }
            }
            //currencyManager1.ResumeBinding();
        }

        #endregion

        #region Save

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
        }

        #endregion

        protected override void SetGridDataFromEntity(Control control, object value)
        {
            _gridEntities = ((ICollection<TGridEntity>)value).Where(x=> !x.IsDeleted).ToList();

            BindItemDataGridView();
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

            FillDropDownAndAutoComplete(pageData,_bindControls);
            FillDropDownAndAutoComplete(pageData, _bindGridControls);
        }
    }
}
