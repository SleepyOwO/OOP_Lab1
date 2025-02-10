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
        private void InitializeComponent() {
            this.ToStringTB = new System.Windows.Forms.RichTextBox();
            this.writeAll = new System.Windows.Forms.Button();
            this.writeSlctd = new System.Windows.Forms.Button();
            this.name_chb = new System.Windows.Forms.CheckBox();
            this.region_chb = new System.Windows.Forms.CheckBox();
            this.price_chb = new System.Windows.Forms.CheckBox();
            this.abonentCount_chb = new System.Windows.Forms.CheckBox();
            this.age_chb = new System.Windows.Forms.CheckBox();
            this.benefits_chb = new System.Windows.Forms.CheckBox();
            this.supports5g_chb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ToStringTB
            // 
            this.ToStringTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToStringTB.Location = new System.Drawing.Point(679, 396);
            this.ToStringTB.Name = "ToStringTB";
            this.ToStringTB.Size = new System.Drawing.Size(315, 265);
            this.ToStringTB.TabIndex = 0;
            this.ToStringTB.Text = "";
            // 
            // writeAll
            // 
            this.writeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeAll.Location = new System.Drawing.Point(426, 396);
            this.writeAll.Name = "writeAll";
            this.writeAll.Size = new System.Drawing.Size(247, 47);
            this.writeAll.TabIndex = 1;
            this.writeAll.Text = "Вывести всё";
            this.writeAll.UseVisualStyleBackColor = true;
            this.writeAll.Click += new System.EventHandler(this.writeAll_Click);
            // 
            // writeSlctd
            // 
            this.writeSlctd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeSlctd.Location = new System.Drawing.Point(426, 475);
            this.writeSlctd.Name = "writeSlctd";
            this.writeSlctd.Size = new System.Drawing.Size(247, 47);
            this.writeSlctd.TabIndex = 2;
            this.writeSlctd.Text = "Вывести выбранное";
            this.writeSlctd.UseVisualStyleBackColor = true;
            this.writeSlctd.Click += new System.EventHandler(this.writeSlctd_Click);
            // 
            // name_chb
            // 
            this.name_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_chb.Location = new System.Drawing.Point(27, 534);
            this.name_chb.Name = "name_chb";
            this.name_chb.Size = new System.Drawing.Size(132, 33);
            this.name_chb.TabIndex = 3;
            this.name_chb.Text = "Name";
            this.name_chb.UseVisualStyleBackColor = true;
            // 
            // region_chb
            // 
            this.region_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.region_chb.Location = new System.Drawing.Point(27, 573);
            this.region_chb.Name = "region_chb";
            this.region_chb.Size = new System.Drawing.Size(132, 33);
            this.region_chb.TabIndex = 4;
            this.region_chb.Text = "Region";
            this.region_chb.UseVisualStyleBackColor = true;
            // 
            // price_chb
            // 
            this.price_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_chb.Location = new System.Drawing.Point(154, 534);
            this.price_chb.Name = "price_chb";
            this.price_chb.Size = new System.Drawing.Size(132, 33);
            this.price_chb.TabIndex = 5;
            this.price_chb.Text = "Price";
            this.price_chb.UseVisualStyleBackColor = true;
            // 
            // abonentCount_chb
            // 
            this.abonentCount_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abonentCount_chb.Location = new System.Drawing.Point(154, 573);
            this.abonentCount_chb.Name = "abonentCount_chb";
            this.abonentCount_chb.Size = new System.Drawing.Size(132, 33);
            this.abonentCount_chb.TabIndex = 6;
            this.abonentCount_chb.Text = "Abonents";
            this.abonentCount_chb.UseVisualStyleBackColor = true;
            // 
            // age_chb
            // 
            this.age_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_chb.Location = new System.Drawing.Point(303, 534);
            this.age_chb.Name = "age_chb";
            this.age_chb.Size = new System.Drawing.Size(132, 33);
            this.age_chb.TabIndex = 7;
            this.age_chb.Text = "Age";
            this.age_chb.UseVisualStyleBackColor = true;
            // 
            // benefits_chb
            // 
            this.benefits_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.benefits_chb.Location = new System.Drawing.Point(303, 573);
            this.benefits_chb.Name = "benefits_chb";
            this.benefits_chb.Size = new System.Drawing.Size(132, 33);
            this.benefits_chb.TabIndex = 8;
            this.benefits_chb.Text = "Benefits";
            this.benefits_chb.UseVisualStyleBackColor = true;
            // 
            // supports5g_chb
            // 
            this.supports5g_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supports5g_chb.Location = new System.Drawing.Point(441, 534);
            this.supports5g_chb.Name = "supports5g_chb";
            this.supports5g_chb.Size = new System.Drawing.Size(151, 33);
            this.supports5g_chb.TabIndex = 9;
            this.supports5g_chb.Text = "5G support";
            this.supports5g_chb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.supports5g_chb);
            this.Controls.Add(this.benefits_chb);
            this.Controls.Add(this.age_chb);
            this.Controls.Add(this.abonentCount_chb);
            this.Controls.Add(this.price_chb);
            this.Controls.Add(this.region_chb);
            this.Controls.Add(this.name_chb);
            this.Controls.Add(this.writeSlctd);
            this.Controls.Add(this.writeAll);
            this.Controls.Add(this.ToStringTB);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox name_chb;
        private System.Windows.Forms.CheckBox region_chb;
        private System.Windows.Forms.CheckBox price_chb;
        private System.Windows.Forms.CheckBox abonentCount_chb;
        private System.Windows.Forms.CheckBox age_chb;
        private System.Windows.Forms.CheckBox benefits_chb;
        private System.Windows.Forms.CheckBox supports5g_chb;

        private System.Windows.Forms.Button writeSlctd;

        private System.Windows.Forms.RichTextBox ToStringTB;
        private System.Windows.Forms.Button writeAll;

        #endregion
    }
}