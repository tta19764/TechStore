
namespace LoginsCurse.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPasswordBtn = new System.Windows.Forms.Button();
            this.siteLoginBox = new System.Windows.Forms.TextBox();
            this.siteDescriptionBox = new System.Windows.Forms.TextBox();
            this.descriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.loginCheckBox = new System.Windows.Forms.CheckBox();
            this.siteAddressBox = new System.Windows.Forms.TextBox();
            this.siteNameBox = new System.Windows.Forms.ComboBox();
            this.addressCheckBox = new System.Windows.Forms.CheckBox();
            this.siteCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(400, 360);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.statsBtn);
            this.panel1.Controls.Add(this.addPasswordBtn);
            this.panel1.Controls.Add(this.siteLoginBox);
            this.panel1.Controls.Add(this.siteDescriptionBox);
            this.panel1.Controls.Add(this.descriptionCheckBox);
            this.panel1.Controls.Add(this.loginCheckBox);
            this.panel1.Controls.Add(this.siteAddressBox);
            this.panel1.Controls.Add(this.siteNameBox);
            this.panel1.Controls.Add(this.addressCheckBox);
            this.panel1.Controls.Add(this.siteCheckBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 244);
            this.panel1.TabIndex = 2;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // addPasswordBtn
            // 
            this.addPasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.addPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPasswordBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPasswordBtn.ForeColor = System.Drawing.Color.White;
            this.addPasswordBtn.Location = new System.Drawing.Point(683, 161);
            this.addPasswordBtn.Name = "addPasswordBtn";
            this.addPasswordBtn.Size = new System.Drawing.Size(283, 65);
            this.addPasswordBtn.TabIndex = 10;
            this.addPasswordBtn.Text = "Add password";
            this.addPasswordBtn.UseVisualStyleBackColor = false;
            this.addPasswordBtn.Click += new System.EventHandler(this.addPasswordBtn_Click);
            // 
            // siteLoginBox
            // 
            this.siteLoginBox.Enabled = false;
            this.siteLoginBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteLoginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.siteLoginBox.Location = new System.Drawing.Point(208, 105);
            this.siteLoginBox.Name = "siteLoginBox";
            this.siteLoginBox.Size = new System.Drawing.Size(283, 32);
            this.siteLoginBox.TabIndex = 9;
            this.siteLoginBox.TextChanged += new System.EventHandler(this.siteNameBox_TextChanged);
            // 
            // siteDescriptionBox
            // 
            this.siteDescriptionBox.Enabled = false;
            this.siteDescriptionBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteDescriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.siteDescriptionBox.Location = new System.Drawing.Point(683, 107);
            this.siteDescriptionBox.Name = "siteDescriptionBox";
            this.siteDescriptionBox.Size = new System.Drawing.Size(283, 32);
            this.siteDescriptionBox.TabIndex = 8;
            this.siteDescriptionBox.TextChanged += new System.EventHandler(this.siteNameBox_TextChanged);
            // 
            // descriptionCheckBox
            // 
            this.descriptionCheckBox.AutoSize = true;
            this.descriptionCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.descriptionCheckBox.Location = new System.Drawing.Point(506, 109);
            this.descriptionCheckBox.Name = "descriptionCheckBox";
            this.descriptionCheckBox.Size = new System.Drawing.Size(151, 30);
            this.descriptionCheckBox.TabIndex = 6;
            this.descriptionCheckBox.Text = "Description";
            this.descriptionCheckBox.UseVisualStyleBackColor = true;
            this.descriptionCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // loginCheckBox
            // 
            this.loginCheckBox.AutoSize = true;
            this.loginCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.loginCheckBox.Location = new System.Drawing.Point(31, 109);
            this.loginCheckBox.Name = "loginCheckBox";
            this.loginCheckBox.Size = new System.Drawing.Size(92, 30);
            this.loginCheckBox.TabIndex = 5;
            this.loginCheckBox.Text = "Login";
            this.loginCheckBox.UseVisualStyleBackColor = true;
            this.loginCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // siteAddressBox
            // 
            this.siteAddressBox.Enabled = false;
            this.siteAddressBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteAddressBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.siteAddressBox.Location = new System.Drawing.Point(683, 49);
            this.siteAddressBox.Name = "siteAddressBox";
            this.siteAddressBox.Size = new System.Drawing.Size(283, 32);
            this.siteAddressBox.TabIndex = 4;
            this.siteAddressBox.TextChanged += new System.EventHandler(this.siteNameBox_TextChanged);
            // 
            // siteNameBox
            // 
            this.siteNameBox.Enabled = false;
            this.siteNameBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.siteNameBox.FormattingEnabled = true;
            this.siteNameBox.Location = new System.Drawing.Point(208, 49);
            this.siteNameBox.Name = "siteNameBox";
            this.siteNameBox.Size = new System.Drawing.Size(283, 34);
            this.siteNameBox.TabIndex = 3;
            this.siteNameBox.TextChanged += new System.EventHandler(this.siteNameBox_TextChanged);
            // 
            // addressCheckBox
            // 
            this.addressCheckBox.AutoSize = true;
            this.addressCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.addressCheckBox.Location = new System.Drawing.Point(506, 53);
            this.addressCheckBox.Name = "addressCheckBox";
            this.addressCheckBox.Size = new System.Drawing.Size(162, 30);
            this.addressCheckBox.TabIndex = 2;
            this.addressCheckBox.Text = "Site address";
            this.addressCheckBox.UseVisualStyleBackColor = true;
            this.addressCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // siteCheckBox
            // 
            this.siteCheckBox.AutoSize = true;
            this.siteCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.siteCheckBox.Location = new System.Drawing.Point(31, 53);
            this.siteCheckBox.Name = "siteCheckBox";
            this.siteCheckBox.Size = new System.Drawing.Size(96, 30);
            this.siteCheckBox.TabIndex = 1;
            this.siteCheckBox.Text = "Name";
            this.siteCheckBox.UseVisualStyleBackColor = true;
            this.siteCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 360);
            this.panel2.TabIndex = 3;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // statsBtn
            // 
            this.statsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.statsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsBtn.ForeColor = System.Drawing.Color.White;
            this.statsBtn.Location = new System.Drawing.Point(385, 161);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(283, 65);
            this.statsBtn.TabIndex = 11;
            this.statsBtn.Text = "See stats";
            this.statsBtn.UseVisualStyleBackColor = false;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1000, 660);
            this.Name = "MainForm";
            this.Text = "Logins storage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox siteAddressBox;
        private System.Windows.Forms.ComboBox siteNameBox;
        private System.Windows.Forms.CheckBox addressCheckBox;
        private System.Windows.Forms.CheckBox siteCheckBox;
        private System.Windows.Forms.TextBox siteDescriptionBox;
        private System.Windows.Forms.CheckBox descriptionCheckBox;
        private System.Windows.Forms.CheckBox loginCheckBox;
        private System.Windows.Forms.TextBox siteLoginBox;
        private System.Windows.Forms.Button addPasswordBtn;
        private System.Windows.Forms.Button statsBtn;
    }
}