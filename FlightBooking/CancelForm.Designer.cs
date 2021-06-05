namespace FlightBooking
{
    partial class CancelForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flightSchedTxtBox = new System.Windows.Forms.TextBox();
            this.flightSeatTxtBox = new System.Windows.Forms.TextBox();
            this.flightDistTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reasonTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flightSchedTxtBox
            // 
            this.flightSchedTxtBox.Enabled = false;
            this.flightSchedTxtBox.Location = new System.Drawing.Point(182, 122);
            this.flightSchedTxtBox.Name = "flightSchedTxtBox";
            this.flightSchedTxtBox.Size = new System.Drawing.Size(205, 26);
            this.flightSchedTxtBox.TabIndex = 1;
            // 
            // flightSeatTxtBox
            // 
            this.flightSeatTxtBox.Enabled = false;
            this.flightSeatTxtBox.Location = new System.Drawing.Point(182, 191);
            this.flightSeatTxtBox.Name = "flightSeatTxtBox";
            this.flightSeatTxtBox.Size = new System.Drawing.Size(205, 26);
            this.flightSeatTxtBox.TabIndex = 2;
            // 
            // flightDistTxtBox
            // 
            this.flightDistTxtBox.Enabled = false;
            this.flightDistTxtBox.Location = new System.Drawing.Point(182, 253);
            this.flightDistTxtBox.Name = "flightDistTxtBox";
            this.flightDistTxtBox.Size = new System.Drawing.Size(205, 26);
            this.flightDistTxtBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flight Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Flight Seat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Flight Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reason";
            // 
            // reasonTxtBox
            // 
            this.reasonTxtBox.Location = new System.Drawing.Point(182, 318);
            this.reasonTxtBox.Name = "reasonTxtBox";
            this.reasonTxtBox.Size = new System.Drawing.Size(205, 26);
            this.reasonTxtBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Flight ID";
            // 
            // CancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 437);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reasonTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flightDistTxtBox);
            this.Controls.Add(this.flightSeatTxtBox);
            this.Controls.Add(this.flightSchedTxtBox);
            this.Controls.Add(this.comboBox1);
            this.Name = "CancelForm";
            this.Text = "CancelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox flightSchedTxtBox;
        private System.Windows.Forms.TextBox flightSeatTxtBox;
        private System.Windows.Forms.TextBox flightDistTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reasonTxtBox;
        private System.Windows.Forms.Label label5;
    }
}