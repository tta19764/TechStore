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
    public partial class StatsForm : Form
    {
        private LoginsDB loginsDB;
        public StatsForm()
        {
            InitializeComponent();
            resultLbl.Visible = false;
            loginsDB = new LoginsDB();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            resultLbl.Visible = true;
            if (passwordCheck.Checked)
            {
                if (loginChek.Checked)
                {
                    resultLbl.Text = $"Entered combination is used {loginsDB.GetUses(loginChek.Checked, passwordCheck.Checked, loginBox.Text, PasswordBox.Text)} times.";
                }
                else
                {
                    resultLbl.Text = $"Entered password is used {loginsDB.GetUses(loginChek.Checked, passwordCheck.Checked, "", PasswordBox.Text)} times.";
                }
            }
            else if(loginChek.Checked)
            {
                resultLbl.Text = $"Entered login is used {loginsDB.GetUses(loginChek.Checked, passwordCheck.Checked, loginBox.Text, "")} times.";
            }
            else
            {
                resultLbl.Visible = false;
            }
        }

        private void loginChek_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.Visible = passwordCheck.Checked;
            loginBox.Visible = loginChek.Checked;
            resultLbl.Visible = true;
            if (passwordCheck.Checked)
            {
                if (loginChek.Checked)
                {
                    resultLbl.Text = $"Entered combination is used {loginsDB.GetUses(loginChek.Checked, passwordCheck.Checked, loginBox.Text, PasswordBox.Text)} times.";
                }
                else
                {
                    resultLbl.Text = $"Entered password is used {loginsDB.GetUses(loginChek.Checked, passwordCheck.Checked, "", PasswordBox.Text)} times.";
                }
            }
            else if (loginChek.Checked)
            {
                resultLbl.Text = $"Entered login is used {loginsDB.GetUses(loginChek.Checked, passwordCheck.Checked, loginBox.Text, "")} times.";
            }
            else
            {
                resultLbl.Visible = false;
            }
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginBox.Text = loginsDB.GetMostUsedLogin();
            loginChek.Checked = true;
            passwordCheck.Checked = false;
            resultLbl.Text = $"This login is used the most: {loginsDB.GetMostUsedLoginCount()} times.";
        }

        private void passwordBtn_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = loginsDB.GetMostUsedPassword();
            loginChek.Checked = false;
            passwordCheck.Checked = true;
            resultLbl.Text = $"This password is used the most: {loginsDB.GetMostUsedPasswordCount()} times.";
        }
    }
}
