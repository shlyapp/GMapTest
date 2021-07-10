
namespace GMapApp
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            this.answerText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkBtn = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answerText
            // 
            this.answerText.BackColor = System.Drawing.Color.LavenderBlush;
            this.answerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerText.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerText.Location = new System.Drawing.Point(23, 249);
            this.answerText.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.answerText.Multiline = true;
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(409, 49);
            this.answerText.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.checkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBtn.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBtn.Location = new System.Drawing.Point(135, 315);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(181, 57);
            this.checkBtn.TabIndex = 3;
            this.checkBtn.Text = "Проверить";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.LavenderBlush;
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.question.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question.Location = new System.Drawing.Point(12, 12);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.Size = new System.Drawing.Size(431, 221);
            this.question.TabIndex = 4;
            this.question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(455, 394);
            this.Controls.Add(this.question);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.answerText);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox question;
    }
}