namespace logbookPLV
{
    partial class CapturePreviewForm
    {
        private System.ComponentModel.IContainer components = null;
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.takePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // takePhoto
            // 
            this.takePhoto.Location = new System.Drawing.Point(196, 518);
            this.takePhoto.Name = "takePhoto";
            this.takePhoto.Size = new System.Drawing.Size(120, 48);
            this.takePhoto.TabIndex = 1;
            this.takePhoto.Text = "Take Photo";
            this.takePhoto.UseVisualStyleBackColor = true;
            this.takePhoto.Click += new System.EventHandler(this.takePhoto_Click);
            // 
            // CapturePreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 577);
            this.Controls.Add(this.takePhoto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CapturePreviewForm";
            this.Text = "CapturePreviewForm";
            this.Load += new System.EventHandler(this.CapturePreviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button takePhoto;
    }
}