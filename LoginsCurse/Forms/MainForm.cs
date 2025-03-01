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
    public partial class MainForm : Form
    {
        private LoginsDB loginsDB;
        
        private bool full = false;
        private Login login;
        private bool isWide;
        private bool isWidest;
        private const int moveX = 100;
        private const int moveY = 23;
        private int widestYMove;
        private int gap;
        public MainForm()
        {
            InitializeComponent();
            isWide = false;
            isWidest = false;
            CreateList();
            
            widestYMove = descriptionCheckBox.Location.Y - addressCheckBox.Location.Y;
            gap = addPasswordBtn.Location.X - statsBtn.Location.X;
            foreach (SitesName siteName in loginsDB.GetNames())
            {
                siteNameBox.Items.Add(siteName.SiteName);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            siteNameBox.Enabled = siteCheckBox.Checked;
            siteAddressBox.Enabled = addressCheckBox.Checked;
            siteLoginBox.Enabled = loginCheckBox.Checked;
            siteDescriptionBox.Enabled = descriptionCheckBox.Checked;
            CreateList();
            ResizeButtons();
        }

        private void siteNameBox_TextChanged(object sender, EventArgs e)
        {
            CreateList();
            ResizeButtons();
        }

        private void CreateList()
        {
            loginsDB = new LoginsDB();
            loginsDB.RemoveExtra();
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.AutoScrollMargin = new Size(9, 0);
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Controls.Clear();
            

            string name = "";
            string address = "";
            string login = "";
            string description = "";
            if (siteCheckBox.Enabled)
            {
                name = siteNameBox.Text;
            }
            if (siteAddressBox.Enabled)
            {
                address = siteAddressBox.Text;
            }
            if (siteLoginBox.Enabled)
            {
                login = siteLoginBox.Text;
            }
            if (siteDescriptionBox.Enabled)
            {
                description = siteDescriptionBox.Text;
            }

            List<Login> logins = loginsDB.GetLogins(name, address, login, description);

            foreach(Login info in logins)
            {
                Panel tempPanel = new Panel() 
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Margin = Padding.Empty,
                    Padding = Padding.Empty,
                    BorderStyle = BorderStyle.None
                };

                Button tempButton = new Button()
                {
                    Text = $"Name: {info.SitesName.SiteName}\r\nAddres: {info.SitesAddress.SiteAddress}\r\nDescription: {info.Description}",
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10),
                    Margin = Padding.Empty,
                    ForeColor = Color.FromArgb(255, 255, 255),
                    Width = flowLayoutPanel.Width,
                    Cursor = Cursors.Hand,
                    Name = info.Id.ToString()
                };
                
                tempButton.Width = flowLayoutPanel.ClientSize.Width - +flowLayoutPanel.AutoScrollMargin.Width * 2;
                tempButton.Font = new Font(tempButton.Font.FontFamily, 10);
                tempButton.Click += Button_Click;
                

                tempPanel.Controls.Add(tempButton);
                flowLayoutPanel.Controls.Add(tempPanel);
                int textWidth = tempButton.Width - tempButton.Padding.Horizontal;
                Size textSize = TextRenderer.MeasureText(tempButton.Text, tempButton.Font, new Size(textWidth, int.MaxValue), TextFormatFlags.WordBreak);
                int desiredHeight = textSize.Height + tempButton.Padding.Vertical;
                tempButton.Height = desiredHeight + 10;
            }

            full = true;

            
        }



        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            login = loginsDB.GetLogin(int.Parse(button.Name));
            PasswordForm passwordForm = new PasswordForm(login);
            passwordForm.MdiParent = this;
            passwordForm.FormClosed += PasswordForm_FormClosed;
            passwordForm.Show();
            this.MinimumSize = new Size(900, 750);
        }

        private void PasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CreateList();
            sender = null;
            
            if(loginsDB.GetLogin(login.Id) != null && Helper.isFormClosed == false)
            {
                Button button = sender as Button;
                login = loginsDB.GetLogin(login.Id);
                PasswordForm passwordForm = new PasswordForm(login);
                passwordForm.MdiParent = this;
                passwordForm.FormClosed += PasswordForm_FormClosed;
                passwordForm.Show();
                this.MinimumSize = new Size(900, 750);
            }
            Helper.isFormClosed = true;
        }

        public void ResizeButtons()
        {
            if (full)
            {
                int height = 0;
                foreach (Panel panel in flowLayoutPanel.Controls)
                {
                    height += panel.Height;

                }
                if (panel2.Height >= height)
                {

                    panel2.Width = 300;
                    foreach (Panel panel in flowLayoutPanel.Controls)
                    {
                        foreach (Button button in panel.Controls)
                        {
                            button.Width = flowLayoutPanel.ClientSize.Width - flowLayoutPanel.Margin.Horizontal;
                        }
                    }
                }
                else
                {
                    panel2.Width = 300 + flowLayoutPanel.AutoScrollMargin.Width * 2;
                    foreach (Panel panel in flowLayoutPanel.Controls)
                    {
                        foreach (Button button in panel.Controls)
                        {
                            button.Width = flowLayoutPanel.ClientSize.Width - flowLayoutPanel.Margin.Horizontal;
                        }
                    }
                }
            }
        }

        private void panel2_Resize(object sender, EventArgs e)
        {

            ResizeButtons();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if(panel1.Width > 750 && isWide == false)
            {
                isWide = true;
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 5);
                siteCheckBox.Location = new Point(siteCheckBox.Location.X + moveX, siteCheckBox.Location.Y - moveY);
                addressCheckBox.Location = new Point(addressCheckBox.Location.X + moveX, addressCheckBox.Location.Y - moveY);
                loginCheckBox.Location = new Point(loginCheckBox.Location.X + moveX, loginCheckBox.Location.Y - moveY);
                descriptionCheckBox.Location = new Point(descriptionCheckBox.Location.X + moveX, descriptionCheckBox.Location.Y - moveY);
                siteNameBox.Location = new Point(siteNameBox.Location.X + moveX, siteNameBox.Location.Y - moveY);
                siteAddressBox.Location = new Point(siteAddressBox.Location.X + moveX, siteAddressBox.Location.Y - moveY);
                siteLoginBox.Location = new Point(siteLoginBox.Location.X + moveX, siteLoginBox.Location.Y - moveY);
                siteDescriptionBox.Location = new Point(siteDescriptionBox.Location.X + moveX, siteDescriptionBox.Location.Y - moveY);
                addPasswordBtn.Location = new Point(addPasswordBtn.Location.X + moveX, addPasswordBtn.Location.Y - moveY);
                statsBtn.Location = new Point(addPasswordBtn.Location.X - gap, addPasswordBtn.Location.Y);
                panel1.Height -= moveY;
            }
            else if (panel1.Width < 750 && isWide == true)
            {
                isWide = false;
                label1.Location = new Point(label1.Location.X, label1.Location.Y - 5);
                siteCheckBox.Location = new Point(siteCheckBox.Location.X - moveX, siteCheckBox.Location.Y + moveY);
                addressCheckBox.Location = new Point(addressCheckBox.Location.X - moveX, addressCheckBox.Location.Y + moveY);
                loginCheckBox.Location = new Point(loginCheckBox.Location.X - moveX, loginCheckBox.Location.Y + moveY);
                descriptionCheckBox.Location = new Point(descriptionCheckBox.Location.X - moveX, descriptionCheckBox.Location.Y + moveY);
                siteNameBox.Location = new Point(siteNameBox.Location.X - moveX, siteNameBox.Location.Y + moveY);
                siteAddressBox.Location = new Point(siteAddressBox.Location.X - moveX, siteAddressBox.Location.Y + moveY);
                siteLoginBox.Location = new Point(siteLoginBox.Location.X - moveX, siteLoginBox.Location.Y + moveY);
                siteDescriptionBox.Location = new Point(siteDescriptionBox.Location.X - moveX, siteDescriptionBox.Location.Y + moveY);
                addPasswordBtn.Location = new Point(addPasswordBtn.Location.X - moveX, addPasswordBtn.Location.Y + moveY);
                statsBtn.Location = new Point(addPasswordBtn.Location.X - gap, addPasswordBtn.Location.Y);
                panel1.Height += moveY;
            }
            else if (panel1.Width > 1400 && isWidest == false)
            {
                isWidest = true;
                addPasswordBtn.Location = new Point(siteAddressBox.Location.X + (siteAddressBox.Location.X - siteNameBox.Location.X) * 2, siteAddressBox.Location.Y + (addPasswordBtn.Location.Y - siteDescriptionBox.Location.Y));
                loginCheckBox.Location = new Point(addressCheckBox.Location.X + (addressCheckBox.Location.X - siteCheckBox.Location.X), addressCheckBox.Location.Y);
                descriptionCheckBox.Location = new Point(addressCheckBox.Location.X + (addressCheckBox.Location.X - siteCheckBox.Location.X) * 2, addressCheckBox.Location.Y);
                siteLoginBox.Location = new Point(siteAddressBox.Location.X + (siteAddressBox.Location.X - siteNameBox.Location.X), siteAddressBox.Location.Y);
                siteDescriptionBox.Location = new Point(siteAddressBox.Location.X + (siteAddressBox.Location.X - siteNameBox.Location.X) * 2, siteAddressBox.Location.Y);
                statsBtn.Location = new Point(addPasswordBtn.Location.X - gap, addPasswordBtn.Location.Y);
                panel1.Height -= moveY;
            }
            else if (panel1.Width < 1400 && isWidest == true)
            {
                isWidest = false;
                loginCheckBox.Location = new Point(addressCheckBox.Location.X - (addressCheckBox.Location.X - siteCheckBox.Location.X), addressCheckBox.Location.Y + widestYMove);
                descriptionCheckBox.Location = new Point(descriptionCheckBox.Location.X - (addressCheckBox.Location.X - siteCheckBox.Location.X) * 2, addressCheckBox.Location.Y + widestYMove);
                siteLoginBox.Location = new Point(siteNameBox.Location.X, siteAddressBox.Location.Y + widestYMove);
                siteDescriptionBox.Location = new Point(siteAddressBox.Location.X, siteAddressBox.Location.Y + widestYMove);
                addPasswordBtn.Location = new Point(siteDescriptionBox.Location.X, addPasswordBtn.Location.Y + widestYMove);
                statsBtn.Location = new Point(addPasswordBtn.Location.X - gap, addPasswordBtn.Location.Y);
                panel1.Height += moveY;
            }
        }

        private void addPasswordBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            login = new Login() { Id = 0};
            PasswordForm passwordForm = new PasswordForm(null);
            passwordForm.MdiParent = this;
            passwordForm.FormClosed += PasswordForm_FormClosed;
            passwordForm.Show();
            this.MinimumSize = new Size(900, 750);
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            StatsForm statsForm = new StatsForm();
            statsForm.MdiParent = this;
            statsForm.Show();
            this.MinimumSize = new Size(900, 600);
        }
    }
}
