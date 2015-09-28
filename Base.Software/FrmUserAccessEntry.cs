using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;
//using DocumentFormat.OpenXml.Bibliography;
//using DocumentFormat.OpenXml.Drawing.Charts;
using RWPLEntityModel;
using RWPLLinqDataService;

namespace Base.Software
{
    public partial class FrmUserAccessEntry : Form
    {
        private IServices _services;
        private User _user;

        public FrmUserAccessEntry()
        {
            InitializeComponent();

            _services = new WinServices(typeof(User).Name);

            _user = new User();
            _user.UserAccessPages.AddRange(Enum.GetValues(typeof(AccessPages)).Cast<object>().Select(x => new UserAccessPage()
            {
                PageName = x.ToString(),
                CreatedBy=PageHelper.UserDetail.UserName,
                CreatedDate=DateTime.Now
            }));
        }

        public FrmUserAccessEntry(long srNo)
        {
            InitializeComponent();

            _services = new WinServices(typeof(User).Name);

            var response = _services.GetEntityByIdServiceResponse<User>(srNo);

            if (!response.IsSuccess)
            {
                MessageBox.Show(response.Exception.Message, @"Error Message");
                this.Close();
            }

            _user = response.Object;
        }

        private void UserAccessEntry_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtBindRUserName.Text = _user.UserName;
            txtBindRPassword.Text = _user.Password;
            dataGridView1.DataSource = _user.UserAccessPages;
            formatColumns();
        }

        private void formatColumns()
        {
            var pageNameColumn = dataGridView1.Columns["PageName"];
            pageNameColumn.Width = 300;

            var userColumn = dataGridView1.Columns["User"];
            userColumn.Visible = false;

            var userSrNoColumn = dataGridView1.Columns["User_SrNo"];
            userSrNoColumn.Visible = false;

            PageHelper.ColumnFormating(dataGridView1);

            var srNoColumn = dataGridView1.Columns["SrNo"];
            srNoColumn.Visible = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _user.UserName = txtBindRUserName.Text;
            _user.Password = txtBindRPassword.Text;
            _user.UserAccessPages.AddRange((EntitySet<UserAccessPage>)dataGridView1.DataSource);

            if (_user.SrNo == 0)
            {
                _user.CreatedBy = PageHelper.UserDetail.UserName;
                _user.CreatedDate = DateTime.Now;
                _services.SaveServiceResponse(_user);
            }
            else
            {
                _user.UpdatedBy = PageHelper.UserDetail.UserName;
                _user.UpdatedDate = DateTime.Now;
                _services.EditServiceResponse(_user);
                this.Close();
            }

            _user = new User();
            _user.UserAccessPages.AddRange(Enum.GetValues(typeof(AccessPages)).Cast<object>().Select(x => new UserAccessPage() { PageName = x.ToString() }));

            Reset();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
