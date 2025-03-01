using LoginsCurse.Classes;
using LoginsCurse.DBClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginsCurse.Forms
{
    public partial class PasswordForm : Form
    {
        private Login login;
        private LoginsDB loginsDB;
        private bool isEncrypted;
        public PasswordForm(Login _login)
        {
            InitializeComponent();
            login = _login;
            UpadateData();
        }

        public void UpadateData()
        {
            loginsDB = new LoginsDB();
            siteNameBox.DataSource = loginsDB.GetNames();
            siteNameBox.DisplayMember = "SiteName";
            siteNameBox.ValueMember = "SiteName";
            if (login != null)
            {
                siteNameBox.Text = login.SitesName.SiteName;
                siteAddressBox.Text = login.SitesAddress.SiteAddress;
                siteDescriptionBox.Text = login.Description;
                siteLoginBox.Text = login.Login1;
                sitePasswordBox.Text = login.Password;
                encryptBtn.Text = (login.IsEncrypted == true) ? "Decrypt" : "Encrypt";
                isEncrypted = login.IsEncrypted;
                if (isEncrypted)
                {
                    sitePasswordBox.Enabled = false;
                }
            }
            else
            {
                siteNameBox.SelectedIndex = -1 ;
                isEncrypted = false;
                button2.Visible = false;
                button2.Enabled = false;
            }
        }


        private void PasswordForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(login == null)
            {
                loginsDB.AddPassword(siteNameBox.Text, siteAddressBox.Text, siteDescriptionBox.Text, siteLoginBox.Text, sitePasswordBox.Text, isEncrypted);
            }
            else
            {
                loginsDB.SavePassword(login, siteNameBox.Text, siteAddressBox.Text, siteDescriptionBox.Text, siteLoginBox.Text, sitePasswordBox.Text, isEncrypted);
            }
            this.Close();
            Helper.isFormClosed = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do tou realy want to remove the password info?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                loginsDB.DeletePassword(login);
                this.Close();
                Helper.isFormClosed = false;
            }
            
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if(sitePasswordBox.Text != "")
            {
                DialogResult result = new EncryptForm(isEncrypted, sitePasswordBox.Text).ShowDialog();
                if(result == DialogResult.OK)
                {
                    sitePasswordBox.Text = Helper.EncryptedValue;
                    encryptBtn.Text = (encryptBtn.Text == "Encrypt") ? "Decrypt" : "Encrypt";
                    isEncrypted = !isEncrypted;
                    if (isEncrypted)
                    {
                        sitePasswordBox.Enabled = false;
                    }
                    else
                    {
                        sitePasswordBox.Enabled = true;
                    }
                }
            }
        }
    }
}
