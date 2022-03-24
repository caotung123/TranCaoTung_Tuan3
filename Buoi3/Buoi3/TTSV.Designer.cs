namespace Buoi3
{
    partial class TTSV
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
            this.customControls1 = new Controls.CustomControls();
            this.SuspendLayout();
            // 
            // customControls1
            // 
            this.customControls1.Location = new System.Drawing.Point(39, 32);
            this.customControls1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.customControls1.Name = "customControls1";
            this.customControls1.Size = new System.Drawing.Size(663, 177);
            this.customControls1.TabIndex = 0;
            this.customControls1.Load += new System.EventHandler(this.customControls1_Load);
            this.customControls1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customControls1_KeyDown);
            // 
            // TTSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 322);
            this.Controls.Add(this.customControls1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TTSV";
            this.Text = "TTSV";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomControls customControls1;
    }
}