namespace OOP_Lab1
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
            this.ToStringTB = new System.Windows.Forms.RichTextBox();
            this.infBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToStringTB
            // 
            this.ToStringTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToStringTB.Location = new System.Drawing.Point(0, 0);
            this.ToStringTB.Name = "ToStringTB";
            this.ToStringTB.Size = new System.Drawing.Size(315, 265);
            this.ToStringTB.TabIndex = 0;
            this.ToStringTB.Text = "";
            // 
            // infBtn
            // 
            this.infBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infBtn.Location = new System.Drawing.Point(321, 12);
            this.infBtn.Name = "infBtn";
            this.infBtn.Size = new System.Drawing.Size(304, 47);
            this.infBtn.TabIndex = 1;
            this.infBtn.Text = "Вывести информацию";
            this.infBtn.UseVisualStyleBackColor = true;
            this.infBtn.Click += new System.EventHandler(this.infBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.infBtn);
            this.Controls.Add(this.ToStringTB);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox ToStringTB;
        private System.Windows.Forms.Button infBtn;

        #endregion
    }
}