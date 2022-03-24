namespace Buoi3
{
    partial class ReverseTimes
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
            this.dongHoDemNguoc1 = new Digital_Clock.DongHoDemNguoc();
            this.SuspendLayout();
            // 
            // dongHoDemNguoc1
            // 
            this.dongHoDemNguoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongHoDemNguoc1.Location = new System.Drawing.Point(31, 43);
            this.dongHoDemNguoc1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dongHoDemNguoc1.Name = "dongHoDemNguoc1";
            this.dongHoDemNguoc1.Size = new System.Drawing.Size(358, 168);
            this.dongHoDemNguoc1.TabIndex = 0;
            // 
            // ReverseTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 253);
            this.Controls.Add(this.dongHoDemNguoc1);
            this.Name = "ReverseTimes";
            this.Text = "ReverseTimes";
            this.ResumeLayout(false);

        }

        #endregion

        private Digital_Clock.DongHoDemNguoc dongHoDemNguoc1;
    }
}