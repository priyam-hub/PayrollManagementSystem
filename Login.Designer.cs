
namespace PayrollManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Label_Heading = new System.Windows.Forms.Label();
            this.GroupBox_Login = new System.Windows.Forms.GroupBox();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Textbox_Username = new System.Windows.Forms.TextBox();
            this.Textbox_Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.LinkLabel_ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.GroupBox_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.BackColor = System.Drawing.Color.Transparent;
            this.Label_Heading.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label_Heading.Location = new System.Drawing.Point(627, 53);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(445, 40);
            this.Label_Heading.TabIndex = 0;
            this.Label_Heading.Text = "Payroll Management System";
            // 
            // GroupBox_Login
            // 
            this.GroupBox_Login.Controls.Add(this.Button_Cancel);
            this.GroupBox_Login.Controls.Add(this.Button_Login);
            this.GroupBox_Login.Controls.Add(this.LinkLabel_ForgetPassword);
            this.GroupBox_Login.Controls.Add(this.Textbox_Password);
            this.GroupBox_Login.Controls.Add(this.Label_Password);
            this.GroupBox_Login.Controls.Add(this.Textbox_Username);
            this.GroupBox_Login.Controls.Add(this.Label_Username);
            this.GroupBox_Login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Login.Location = new System.Drawing.Point(611, 110);
            this.GroupBox_Login.Name = "GroupBox_Login";
            this.GroupBox_Login.Size = new System.Drawing.Size(476, 381);
            this.GroupBox_Login.TabIndex = 1;
            this.GroupBox_Login.TabStop = false;
            this.GroupBox_Login.Text = "Please Login first";
            // 
            // PictureBox_Logo
            // 
            this.PictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Logo.Image")));
            this.PictureBox_Logo.Location = new System.Drawing.Point(188, 110);
            this.PictureBox_Logo.Name = "PictureBox_Logo";
            this.PictureBox_Logo.Size = new System.Drawing.Size(380, 380);
            this.PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_Logo.TabIndex = 2;
            this.PictureBox_Logo.TabStop = false;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Location = new System.Drawing.Point(58, 77);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(119, 23);
            this.Label_Username.TabIndex = 0;
            this.Label_Username.Text = "User Name : ";
            // 
            // Textbox_Username
            // 
            this.Textbox_Username.Location = new System.Drawing.Point(183, 68);
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.Size = new System.Drawing.Size(243, 32);
            this.Textbox_Username.TabIndex = 1;
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.Location = new System.Drawing.Point(183, 111);
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.PasswordChar = '*';
            this.Textbox_Password.Size = new System.Drawing.Size(243, 32);
            this.Textbox_Password.TabIndex = 3;
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(71, 120);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(106, 23);
            this.Label_Password.TabIndex = 2;
            this.Label_Password.Text = "Password : ";
            // 
            // LinkLabel_ForgetPassword
            // 
            this.LinkLabel_ForgetPassword.AutoSize = true;
            this.LinkLabel_ForgetPassword.Location = new System.Drawing.Point(228, 146);
            this.LinkLabel_ForgetPassword.Name = "LinkLabel_ForgetPassword";
            this.LinkLabel_ForgetPassword.Size = new System.Drawing.Size(160, 23);
            this.LinkLabel_ForgetPassword.TabIndex = 4;
            this.LinkLabel_ForgetPassword.TabStop = true;
            this.LinkLabel_ForgetPassword.Text = "Forget Password?";
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Location = new System.Drawing.Point(183, 182);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(243, 38);
            this.Button_Login.TabIndex = 5;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Location = new System.Drawing.Point(183, 226);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(243, 38);
            this.Button_Cancel.TabIndex = 6;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.PictureBox_Logo);
            this.Controls.Add(this.GroupBox_Login);
            this.Controls.Add(this.Label_Heading);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GroupBox_Login.ResumeLayout(false);
            this.GroupBox_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Heading;
        private System.Windows.Forms.GroupBox GroupBox_Login;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.LinkLabel LinkLabel_ForgetPassword;
        private System.Windows.Forms.TextBox Textbox_Password;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox Textbox_Username;
        private System.Windows.Forms.Label Label_Username;
    }
}

