
namespace LoginsCurse.Forms
{
    partial class StatsForm
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
            this.loginBox = new System.Windows.Forms.ComboBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordBtn = new System.Windows.Forms.Button();
            this.loginChek = new System.Windows.Forms.CheckBox();
            this.passwordCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.loginBox.FormattingEnabled = true;
            this.loginBox.Location = new System.Drawing.Point(278, 44);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(305, 37);
            this.loginBox.TabIndex = 0;
            this.loginBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.PasswordBox.Location = new System.Drawing.Point(278, 126);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(305, 37);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // resultLbl
            // 
            this.resultLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.resultLbl.Location = new System.Drawing.Point(136, 261);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(152, 29);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "PlaceHolder";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(69, 365);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(246, 56);
            this.loginBtn.TabIndex = 30;
            this.loginBtn.Text = "Most used login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordBtn
            // 
            this.passwordBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.passwordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBtn.ForeColor = System.Drawing.Color.White;
            this.passwordBtn.Location = new System.Drawing.Point(363, 365);
            this.passwordBtn.Name = "passwordBtn";
            this.passwordBtn.Size = new System.Drawing.Size(246, 56);
            this.passwordBtn.TabIndex = 29;
            this.passwordBtn.Text = "Most used password";
            this.passwordBtn.UseVisualStyleBackColor = false;
            this.passwordBtn.Click += new System.EventHandler(this.passwordBtn_Click);
            // 
            // loginChek
            // 
            this.loginChek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginChek.AutoSize = true;
            this.loginChek.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.loginChek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.loginChek.Location = new System.Drawing.Point(69, 46);
            this.loginChek.Name = "loginChek";
            this.loginChek.Size = new System.Drawing.Size(103, 33);
            this.loginChek.TabIndex = 31;
            this.loginChek.Text = "Login";
            this.loginChek.UseVisualStyleBackColor = true;
            this.loginChek.CheckedChanged += new System.EventHandler(this.loginChek_CheckedChanged);
            this.loginChek.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // passwordCheck
            // 
            this.passwordCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordCheck.AutoSize = true;
            this.passwordCheck.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.passwordCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.passwordCheck.Location = new System.Drawing.Point(69, 128);
            this.passwordCheck.Name = "passwordCheck";
            this.passwordCheck.Size = new System.Drawing.Size(153, 33);
            this.passwordCheck.TabIndex = 32;
            this.passwordCheck.Text = "Password";
            this.passwordCheck.UseVisualStyleBackColor = true;
            this.passwordCheck.CheckedChanged += new System.EventHandler(this.loginChek_CheckedChanged);
            this.passwordCheck.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // StatsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(187)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(671, 484);
            this.Controls.Add(this.passwordCheck);
            this.Controls.Add(this.loginChek);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.loginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox loginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button passwordBtn;
        private System.Windows.Forms.CheckBox loginChek;
        private System.Windows.Forms.CheckBox passwordCheck;
    }
}