namespace AUT
{
    partial class Form1
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.StatusLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(9, 10);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(76, 20);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(9, 32);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(76, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(9, 55);
            this.btConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(56, 19);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "button1";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // StatusLogin
            // 
            this.StatusLogin.AutoSize = true;
            this.StatusLogin.Location = new System.Drawing.Point(157, 13);
            this.StatusLogin.Name = "StatusLogin";
            this.StatusLogin.Size = new System.Drawing.Size(0, 13);
            this.StatusLogin.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 205);
            this.Controls.Add(this.StatusLogin);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label StatusLogin;
    }
}

