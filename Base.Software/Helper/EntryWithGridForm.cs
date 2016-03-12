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

        private List<TGridEntity> _gridEntities;

        private DataGridView _dataGridView;

       

        public EntryWithGridForm(Control form, long srNo = 0)
            : base(form, srNo)
        {
            HasGridForm = true;

            var grpGridControlName = @"grpGridBind" + typeof(TGridEntity).Name + "s";

            _dataGridView = (DataGridView)form.Controls[grpGridControlName].Controls[@"dataGridView1"];

            _bindGridControls = GetBindControls(form.Controls[grpGridControlName]);

            BindEvents(form.Controls[grpGridControlName]);

            var appDataControls = _bindGridControls.Where(x => !string.IsNullOrEmpty(x.AccessibleDescription) && x.AccessibleDescription.Contains(AccDescription.AppData.ToString())).ToList();

            if (appDataControls.Count > 0)
            {
                FillDropDownAndAutoCompleteByApplicationData(appDataControls);
            }

            _gridEntities = new List<TGridEntity>();

            if (_entity.SrNo != 0)
                BindControlsWithEntityModel(_bindControls, _entity);
        }


        #region Add Delete Grid Item

        private void AddGridItem(object sender, EventArgs e)
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

        private void DeleteGridItem(object sender, EventArgs e)
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
            HideGridColumn("SrNo");
            HideGridColumn(typeof(TEntity).Name);
            HideGridColumn(typeof(TEntity).Name + "_SrNo");

            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["IsDeleted"].Value))
                {
                    _dataGridView.CurrentCell = null;
                    row.Visible = false;
                }
            }
        }

        private void HideGridColumn(string columnName)
        {
            var dataGridViewColumn = _dataGridView.Columns[columnName];

            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = false;
        }

        #endregion


        #region Override methods

        protected override void SetGridDataFromEntity(Control control, object value)
        {
            _gridEntities = ((ICollection<TGridEntity>)value).Where(x => !x.IsDeleted).ToList();

            BindItemDataGridView();
        }

        protected override void BindAditionalEvent(Control control, string[] accDescriptionList)
        {
            if (accDescriptionList.Contains(AccDescription.AddItem.ToString()))
                control.Click += AddGridItem;

            if (accDescriptionList.Contains(AccDescription.DeleteItem.ToString()))
                control.Click += DeleteGridItem;
        }

        #endregion

    }
}
