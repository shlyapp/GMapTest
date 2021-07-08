
namespace GMapApp
{
    partial class InfoForm
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
            this.imagePlace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlace)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePlace
            // 
            this.imagePlace.Location = new System.Drawing.Point(12, 12);
            this.imagePlace.Name = "imagePlace";
            this.imagePlace.Size = new System.Drawing.Size(156, 156);
            this.imagePlace.TabIndex = 0;
            this.imagePlace.TabStop = false;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.imagePlace);
            this.Name = "InfoForm";
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.imagePlace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePlace;
    }
}