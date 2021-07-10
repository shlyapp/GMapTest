
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.imagePlace = new System.Windows.Forms.PictureBox();
            this.labelText = new System.Windows.Forms.TextBox();
            this.mainText = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.routeBtn = new System.Windows.Forms.Button();
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
            this.labelText.ReadOnly = true;
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
            this.mainText.ReadOnly = true;
            this.mainText.Size = new System.Drawing.Size(557, 365);
            this.mainText.TabIndex = 2;
            // 
            // testBtn
            // 
            this.testBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testBtn.Location = new System.Drawing.Point(26, 418);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(220, 78);
            this.testBtn.TabIndex = 3;
            this.testBtn.Text = "Перейти к тесту.";
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // routeBtn
            // 
            this.routeBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.routeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routeBtn.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routeBtn.Location = new System.Drawing.Point(26, 310);
            this.routeBtn.Name = "routeBtn";
            this.routeBtn.Size = new System.Drawing.Size(220, 78);
            this.routeBtn.TabIndex = 4;
            this.routeBtn.Text = "Маршрут.";
            this.routeBtn.UseVisualStyleBackColor = false;
            this.routeBtn.Click += new System.EventHandler(this.routeBtn_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.routeBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.imagePlace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Историческая справка";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePlace;
        private System.Windows.Forms.TextBox labelText;
        private System.Windows.Forms.TextBox mainText;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button routeBtn;
    }
}