namespace Buoi3
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
            this.mdDangNhap1 = new UserControls.mdDangNhap();
            this.digitalClock1 = new Digital_Clock.DigitalClock();
            this.SuspendLayout();
            // 
            // mdDangNhap1
            // 
            this.mdDangNhap1.Location = new System.Drawing.Point(3, 27);
            this.mdDangNhap1.Name = "mdDangNhap1";
            this.mdDangNhap1.Size = new System.Drawing.Size(326, 150);
            this.mdDangNhap1.TabIndex = 0;
            // 
            // digitalClock1
            // 
            this.digitalClock1.Location = new System.Drawing.Point(1, 1);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(201, 49);
            this.digitalClock1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 287);
            this.Controls.Add(this.digitalClock1);
            this.Controls.Add(this.mdDangNhap1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.mdDangNhap mdDangNhap1;
        private Digital_Clock.DigitalClock digitalClock1;

    }
}

