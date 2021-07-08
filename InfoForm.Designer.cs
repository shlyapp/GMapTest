
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
            this.labelText = new System.Windows.Forms.TextBox();
            this.mainText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlace)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePlace
            // 
            this.imagePlace.BackColor = System.Drawing.Color.LavenderBlush;
            this.imagePlace.Location = new System.Drawing.Point(26, 21);
            this.imagePlace.Name = "imagePlace";
            this.imagePlace.Size = new System.Drawing.Size(220, 220);
            this.imagePlace.TabIndex = 0;
            this.imagePlace.TabStop = false;
            // 
            // labelText
            // 
            this.labelText.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelText.Font = new System.Drawing.Font("Book Antiqua", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(277, 21);
            this.labelText.Multiline = true;
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(557, 137);
            this.labelText.TabIndex = 1;
            this.labelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainText
            // 
            this.mainText.BackColor = System.Drawing.Color.LavenderBlush;
            this.mainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainText.Location = new System.Drawing.Point(276, 172);
            this.mainText.Multiline = true;
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(557, 365);
            this.mainText.TabIndex = 2;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.imagePlace);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.imagePlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePlace;
        private System.Windows.Forms.TextBox labelText;
        private System.Windows.Forms.TextBox mainText;
    }
}