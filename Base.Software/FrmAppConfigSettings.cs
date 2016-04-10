using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Base.Software
{
    public partial class FrmAppConfigSettings : Form
    {
        public FrmAppConfigSettings()
        {
            InitializeComponent();
        }

        private void FrmAppConfigSettings_Load(object sender, EventArgs e)
        {
            txtConnectionStringName.Text = ConfigurationManager.ConnectionStrings[0].Name;
            txtConnectionString.Text = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateConfigFile();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateConfigFile()
        {
            //updating config file
            var xmlDoc = new XmlDocument();
            //Loading the Config file
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in xmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    xElement.FirstChild.Attributes["connectionString"].Value = txtConnectionString.Text;
                }
            }
            //writing the connection string in config file
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}
