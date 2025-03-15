namespace CalendarShahanshahi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtMiladiToShamsiAndShahanshahi = new TextBox();
            lblMiladiToShamsiAndShahanshahi = new Label();
            btnMiladiToShamsiAndShahanshahi = new Button();
            txtShahanshahiToMiladi = new TextBox();
            lblShahanshahiToMiladi = new Label();
            btnShahanshahiToMiladi = new Button();
            SuspendLayout();
            // 
            // TxtMiladiToShamsiAndShahanshahi
            // 
            TxtMiladiToShamsiAndShahanshahi.Location = new Point(565, 99);
            TxtMiladiToShamsiAndShahanshahi.Name = "TxtMiladiToShamsiAndShahanshahi";
            TxtMiladiToShamsiAndShahanshahi.Size = new Size(100, 23);
            TxtMiladiToShamsiAndShahanshahi.TabIndex = 0;
            // 
            // lblMiladiToShamsiAndShahanshahi
            // 
            lblMiladiToShamsiAndShahanshahi.AutoSize = true;
            lblMiladiToShamsiAndShahanshahi.Location = new Point(590, 180);
            lblMiladiToShamsiAndShahanshahi.Name = "lblMiladiToShamsiAndShahanshahi";
            lblMiladiToShamsiAndShahanshahi.Size = new Size(38, 15);
            lblMiladiToShamsiAndShahanshahi.TabIndex = 1;
            lblMiladiToShamsiAndShahanshahi.Text = "label1";
            // 
            // btnMiladiToShamsiAndShahanshahi
            // 
            btnMiladiToShamsiAndShahanshahi.Location = new Point(526, 327);
            btnMiladiToShamsiAndShahanshahi.Name = "btnMiladiToShamsiAndShahanshahi";
            btnMiladiToShamsiAndShahanshahi.Size = new Size(191, 23);
            btnMiladiToShamsiAndShahanshahi.TabIndex = 2;
            btnMiladiToShamsiAndShahanshahi.Text = "تبدیل میلادی به شاهنشاهی";
            btnMiladiToShamsiAndShahanshahi.UseVisualStyleBackColor = true;
            btnMiladiToShamsiAndShahanshahi.Click += btnMiladiToShamsiAndShahanshahi_Click;
            // 
            // txtShahanshahiToMiladi
            // 
            txtShahanshahiToMiladi.Location = new Point(136, 99);
            txtShahanshahiToMiladi.Name = "txtShahanshahiToMiladi";
            txtShahanshahiToMiladi.Size = new Size(100, 23);
            txtShahanshahiToMiladi.TabIndex = 0;
            // 
            // lblShahanshahiToMiladi
            // 
            lblShahanshahiToMiladi.AutoSize = true;
            lblShahanshahiToMiladi.Location = new Point(161, 180);
            lblShahanshahiToMiladi.Name = "lblShahanshahiToMiladi";
            lblShahanshahiToMiladi.Size = new Size(38, 15);
            lblShahanshahiToMiladi.TabIndex = 1;
            lblShahanshahiToMiladi.Text = "label1";
            // 
            // btnShahanshahiToMiladi
            // 
            btnShahanshahiToMiladi.Location = new Point(97, 327);
            btnShahanshahiToMiladi.Name = "btnShahanshahiToMiladi";
            btnShahanshahiToMiladi.Size = new Size(191, 23);
            btnShahanshahiToMiladi.TabIndex = 2;
            btnShahanshahiToMiladi.Text = "تبدیل شاهنشاهی به میلادی";
            btnShahanshahiToMiladi.UseVisualStyleBackColor = true;
            btnShahanshahiToMiladi.Click += btnShahanshahiToMiladi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShahanshahiToMiladi);
            Controls.Add(btnMiladiToShamsiAndShahanshahi);
            Controls.Add(lblShahanshahiToMiladi);
            Controls.Add(lblMiladiToShamsiAndShahanshahi);
            Controls.Add(txtShahanshahiToMiladi);
            Controls.Add(TxtMiladiToShamsiAndShahanshahi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtMiladiToShamsiAndShahanshahi;
        private Label lblMiladiToShamsiAndShahanshahi;
        private Button btnMiladiToShamsiAndShahanshahi;
        private TextBox txtShahanshahiToMiladi;
        private Label lblShahanshahiToMiladi;
        private Button btnShahanshahiToMiladi;
    }
}
