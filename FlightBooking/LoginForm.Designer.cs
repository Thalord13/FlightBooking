namespace FlightBooking
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Location = new System.Drawing.Point(214, 111);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(148, 26);
            this.txtbx_username.TabIndex = 2;
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(214, 183);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.PasswordChar = '*';
            this.txtbx_password.Size = new System.Drawing.Size(148, 26);
            this.txtbx_password.TabIndex = 3;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(232, 258);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(112, 35);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Log-in";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 392);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button btn_submit;
    }
}