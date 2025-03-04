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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.midCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.supports5g_chb = new System.Windows.Forms.CheckBox();
            this.benefits_chb = new System.Windows.Forms.CheckBox();
            this.age_chb = new System.Windows.Forms.CheckBox();
            this.abonentCount_chb = new System.Windows.Forms.CheckBox();
            this.price_chb = new System.Windows.Forms.CheckBox();
            this.region_chb = new System.Windows.Forms.CheckBox();
            this.name_chb = new System.Windows.Forms.CheckBox();
            this.writeSlctd = new System.Windows.Forms.Button();
            this.writeAll = new System.Windows.Forms.Button();
            this.ToStringTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.region_TB = new System.Windows.Forms.TextBox();
            this.name_edit_btn = new System.Windows.Forms.Button();
            this.region_edit_btn = new System.Windows.Forms.Button();
            this.abonents_edit_btn = new System.Windows.Forms.Button();
            this.price_edit_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.price_Nud = new System.Windows.Forms.NumericUpDown();
            this.abonents_Nud = new System.Windows.Forms.NumericUpDown();
            this.age_Nud = new System.Windows.Forms.NumericUpDown();
            this.age_edit_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.haveBenefits_chb = new System.Windows.Forms.CheckBox();
            this.have5G_chb = new System.Windows.Forms.CheckBox();
            this.createOp = new System.Windows.Forms.Button();
            this.operatorDGV = new System.Windows.Forms.DataGridView();
            this.operChB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.operName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price_Nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonents_Nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_Nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.midCalc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.supports5g_chb);
            this.panel1.Controls.Add(this.benefits_chb);
            this.panel1.Controls.Add(this.age_chb);
            this.panel1.Controls.Add(this.abonentCount_chb);
            this.panel1.Controls.Add(this.price_chb);
            this.panel1.Controls.Add(this.region_chb);
            this.panel1.Controls.Add(this.name_chb);
            this.panel1.Controls.Add(this.writeSlctd);
            this.panel1.Controls.Add(this.writeAll);
            this.panel1.Controls.Add(this.ToStringTB);
            this.panel1.Location = new System.Drawing.Point(-3, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 322);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(23, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(397, 30);
            this.label8.TabIndex = 40;
            this.label8.Text = "Посчитать среднюю прибыль в год?";
            // 
            // midCalc
            // 
            this.midCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.midCalc.Location = new System.Drawing.Point(22, 96);
            this.midCalc.Name = "midCalc";
            this.midCalc.Size = new System.Drawing.Size(134, 35);
            this.midCalc.TabIndex = 39;
            this.midCalc.Text = "Посчитать";
            this.midCalc.UseVisualStyleBackColor = true;
            this.midCalc.Click += new System.EventHandler(this.midCalc_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 44);
            this.label1.TabIndex = 20;
            this.label1.Text = "Вывод информации об операторе";
            // 
            // supports5g_chb
            // 
            this.supports5g_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supports5g_chb.Location = new System.Drawing.Point(458, 194);
            this.supports5g_chb.Name = "supports5g_chb";
            this.supports5g_chb.Size = new System.Drawing.Size(151, 33);
            this.supports5g_chb.TabIndex = 19;
            this.supports5g_chb.Text = "5G support";
            this.supports5g_chb.UseVisualStyleBackColor = true;
            // 
            // benefits_chb
            // 
            this.benefits_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.benefits_chb.Location = new System.Drawing.Point(320, 233);
            this.benefits_chb.Name = "benefits_chb";
            this.benefits_chb.Size = new System.Drawing.Size(132, 33);
            this.benefits_chb.TabIndex = 18;
            this.benefits_chb.Text = "Benefits";
            this.benefits_chb.UseVisualStyleBackColor = true;
            // 
            // age_chb
            // 
            this.age_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_chb.Location = new System.Drawing.Point(320, 194);
            this.age_chb.Name = "age_chb";
            this.age_chb.Size = new System.Drawing.Size(132, 33);
            this.age_chb.TabIndex = 17;
            this.age_chb.Text = "Age";
            this.age_chb.UseVisualStyleBackColor = true;
            // 
            // abonentCount_chb
            // 
            this.abonentCount_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abonentCount_chb.Location = new System.Drawing.Point(171, 233);
            this.abonentCount_chb.Name = "abonentCount_chb";
            this.abonentCount_chb.Size = new System.Drawing.Size(132, 33);
            this.abonentCount_chb.TabIndex = 16;
            this.abonentCount_chb.Text = "Abonents";
            this.abonentCount_chb.UseVisualStyleBackColor = true;
            // 
            // price_chb
            // 
            this.price_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_chb.Location = new System.Drawing.Point(171, 194);
            this.price_chb.Name = "price_chb";
            this.price_chb.Size = new System.Drawing.Size(132, 33);
            this.price_chb.TabIndex = 15;
            this.price_chb.Text = "Price";
            this.price_chb.UseVisualStyleBackColor = true;
            // 
            // region_chb
            // 
            this.region_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.region_chb.Location = new System.Drawing.Point(44, 233);
            this.region_chb.Name = "region_chb";
            this.region_chb.Size = new System.Drawing.Size(132, 33);
            this.region_chb.TabIndex = 14;
            this.region_chb.Text = "Region";
            this.region_chb.UseVisualStyleBackColor = true;
            // 
            // name_chb
            // 
            this.name_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_chb.Location = new System.Drawing.Point(44, 194);
            this.name_chb.Name = "name_chb";
            this.name_chb.Size = new System.Drawing.Size(132, 33);
            this.name_chb.TabIndex = 13;
            this.name_chb.Text = "Name";
            this.name_chb.UseVisualStyleBackColor = true;
            // 
            // writeSlctd
            // 
            this.writeSlctd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeSlctd.Location = new System.Drawing.Point(443, 135);
            this.writeSlctd.Name = "writeSlctd";
            this.writeSlctd.Size = new System.Drawing.Size(247, 47);
            this.writeSlctd.TabIndex = 12;
            this.writeSlctd.Text = "Вывести выбранное";
            this.writeSlctd.UseVisualStyleBackColor = true;
            this.writeSlctd.Click += new System.EventHandler(this.writeSlctd_Click);
            // 
            // writeAll
            // 
            this.writeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeAll.Location = new System.Drawing.Point(443, 56);
            this.writeAll.Name = "writeAll";
            this.writeAll.Size = new System.Drawing.Size(247, 47);
            this.writeAll.TabIndex = 11;
            this.writeAll.Text = "Вывести всё";
            this.writeAll.UseVisualStyleBackColor = true;
            this.writeAll.Click += new System.EventHandler(this.writeAll_Click);
            // 
            // ToStringTB
            // 
            this.ToStringTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToStringTB.Location = new System.Drawing.Point(696, 56);
            this.ToStringTB.Name = "ToStringTB";
            this.ToStringTB.Size = new System.Drawing.Size(315, 265);
            this.ToStringTB.TabIndex = 10;
            this.ToStringTB.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 44);
            this.label2.TabIndex = 21;
            this.label2.Text = "Редактирование информации об операторе";
            // 
            // name_TB
            // 
            this.name_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_TB.Location = new System.Drawing.Point(21, 85);
            this.name_TB.Name = "name_TB";
            this.name_TB.Size = new System.Drawing.Size(186, 27);
            this.name_TB.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "Region";
            // 
            // region_TB
            // 
            this.region_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.region_TB.Location = new System.Drawing.Point(21, 156);
            this.region_TB.Name = "region_TB";
            this.region_TB.Size = new System.Drawing.Size(186, 27);
            this.region_TB.TabIndex = 24;
            // 
            // name_edit_btn
            // 
            this.name_edit_btn.Enabled = false;
            this.name_edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_edit_btn.Location = new System.Drawing.Point(235, 81);
            this.name_edit_btn.Name = "name_edit_btn";
            this.name_edit_btn.Size = new System.Drawing.Size(66, 35);
            this.name_edit_btn.TabIndex = 26;
            this.name_edit_btn.Text = "edit";
            this.name_edit_btn.UseVisualStyleBackColor = true;
            this.name_edit_btn.Click += new System.EventHandler(this.name_edit_btn_Click);
            // 
            // region_edit_btn
            // 
            this.region_edit_btn.Enabled = false;
            this.region_edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.region_edit_btn.Location = new System.Drawing.Point(235, 152);
            this.region_edit_btn.Name = "region_edit_btn";
            this.region_edit_btn.Size = new System.Drawing.Size(66, 35);
            this.region_edit_btn.TabIndex = 27;
            this.region_edit_btn.Text = "edit";
            this.region_edit_btn.UseVisualStyleBackColor = true;
            this.region_edit_btn.Click += new System.EventHandler(this.region_edit_btn_Click);
            // 
            // abonents_edit_btn
            // 
            this.abonents_edit_btn.Enabled = false;
            this.abonents_edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abonents_edit_btn.Location = new System.Drawing.Point(583, 152);
            this.abonents_edit_btn.Name = "abonents_edit_btn";
            this.abonents_edit_btn.Size = new System.Drawing.Size(66, 35);
            this.abonents_edit_btn.TabIndex = 33;
            this.abonents_edit_btn.Text = "edit";
            this.abonents_edit_btn.UseVisualStyleBackColor = true;
            this.abonents_edit_btn.Click += new System.EventHandler(this.abonents_edit_btn_Click);
            // 
            // price_edit_btn
            // 
            this.price_edit_btn.Enabled = false;
            this.price_edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_edit_btn.Location = new System.Drawing.Point(583, 81);
            this.price_edit_btn.Name = "price_edit_btn";
            this.price_edit_btn.Size = new System.Drawing.Size(66, 35);
            this.price_edit_btn.TabIndex = 32;
            this.price_edit_btn.Text = "edit";
            this.price_edit_btn.UseVisualStyleBackColor = true;
            this.price_edit_btn.Click += new System.EventHandler(this.price_edit_btn_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(369, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Abonents Count";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(369, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "Price";
            // 
            // price_Nud
            // 
            this.price_Nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_Nud.Location = new System.Drawing.Point(369, 86);
            this.price_Nud.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.price_Nud.Name = "price_Nud";
            this.price_Nud.Size = new System.Drawing.Size(186, 27);
            this.price_Nud.TabIndex = 34;
            // 
            // abonents_Nud
            // 
            this.abonents_Nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abonents_Nud.Location = new System.Drawing.Point(369, 157);
            this.abonents_Nud.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.abonents_Nud.Name = "abonents_Nud";
            this.abonents_Nud.Size = new System.Drawing.Size(186, 27);
            this.abonents_Nud.TabIndex = 35;
            // 
            // age_Nud
            // 
            this.age_Nud.DecimalPlaces = 1;
            this.age_Nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_Nud.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.age_Nud.Location = new System.Drawing.Point(714, 86);
            this.age_Nud.Name = "age_Nud";
            this.age_Nud.Size = new System.Drawing.Size(186, 27);
            this.age_Nud.TabIndex = 38;
            // 
            // age_edit_btn
            // 
            this.age_edit_btn.Enabled = false;
            this.age_edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_edit_btn.Location = new System.Drawing.Point(928, 81);
            this.age_edit_btn.Name = "age_edit_btn";
            this.age_edit_btn.Size = new System.Drawing.Size(66, 35);
            this.age_edit_btn.TabIndex = 37;
            this.age_edit_btn.Text = "edit";
            this.age_edit_btn.UseVisualStyleBackColor = true;
            this.age_edit_btn.Click += new System.EventHandler(this.age_edit_btn_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(714, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 30);
            this.label7.TabIndex = 36;
            this.label7.Text = "Age";
            // 
            // haveBenefits_chb
            // 
            this.haveBenefits_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.haveBenefits_chb.Location = new System.Drawing.Point(714, 150);
            this.haveBenefits_chb.Name = "haveBenefits_chb";
            this.haveBenefits_chb.Size = new System.Drawing.Size(132, 33);
            this.haveBenefits_chb.TabIndex = 21;
            this.haveBenefits_chb.Text = "Benefits";
            this.haveBenefits_chb.UseVisualStyleBackColor = true;
            this.haveBenefits_chb.CheckedChanged += new System.EventHandler(this.haveBenefits_chb_CheckedChanged);
            // 
            // have5G_chb
            // 
            this.have5G_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.have5G_chb.Location = new System.Drawing.Point(843, 150);
            this.have5G_chb.Name = "have5G_chb";
            this.have5G_chb.Size = new System.Drawing.Size(151, 33);
            this.have5G_chb.TabIndex = 21;
            this.have5G_chb.Text = "5G support";
            this.have5G_chb.UseVisualStyleBackColor = true;
            this.have5G_chb.CheckedChanged += new System.EventHandler(this.have5G_chb_CheckedChanged);
            // 
            // createOp
            // 
            this.createOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createOp.Location = new System.Drawing.Point(748, 205);
            this.createOp.Name = "createOp";
            this.createOp.Size = new System.Drawing.Size(246, 30);
            this.createOp.TabIndex = 39;
            this.createOp.Text = "Создать оператора";
            this.createOp.UseVisualStyleBackColor = true;
            this.createOp.Click += new System.EventHandler(this.createOp_Click);
            // 
            // operatorDGV
            // 
            this.operatorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operatorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.operChB, this.operName, this.objLink });
            this.operatorDGV.Location = new System.Drawing.Point(21, 205);
            this.operatorDGV.Name = "operatorDGV";
            this.operatorDGV.RowTemplate.Height = 24;
            this.operatorDGV.Size = new System.Drawing.Size(534, 137);
            this.operatorDGV.TabIndex = 40;
            this.operatorDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.operatorDGV_CellContentClick);
            // 
            // operChB
            // 
            this.operChB.HeaderText = "";
            this.operChB.Name = "operChB";
            // 
            // operName
            // 
            this.operName.HeaderText = "Название оператора";
            this.operName.Name = "operName";
            // 
            // objLink
            // 
            this.objLink.HeaderText = "link";
            this.objLink.Name = "objLink";
            this.objLink.ReadOnly = true;
            this.objLink.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.operatorDGV);
            this.Controls.Add(this.createOp);
            this.Controls.Add(this.have5G_chb);
            this.Controls.Add(this.haveBenefits_chb);
            this.Controls.Add(this.age_Nud);
            this.Controls.Add(this.age_edit_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.abonents_Nud);
            this.Controls.Add(this.price_Nud);
            this.Controls.Add(this.abonents_edit_btn);
            this.Controls.Add(this.price_edit_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.region_edit_btn);
            this.Controls.Add(this.name_edit_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.region_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.price_Nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonents_Nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_Nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewLinkColumn objLink;

        private System.Windows.Forms.DataGridViewCheckBoxColumn operChB;
        private System.Windows.Forms.DataGridViewTextBoxColumn operName;

        private System.Windows.Forms.DataGridView operatorDGV;

        private System.Windows.Forms.Button createOp;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Button midCalc;

        private System.Windows.Forms.CheckBox haveBenefits_chb;
        private System.Windows.Forms.CheckBox have5G_chb;

        private System.Windows.Forms.NumericUpDown abonents_Nud;
        private System.Windows.Forms.NumericUpDown age_Nud;
        private System.Windows.Forms.Button age_edit_btn;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Button abonents_edit_btn;
        private System.Windows.Forms.Button price_edit_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown price_Nud;

        private System.Windows.Forms.Button region_edit_btn;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox region_TB;
        private System.Windows.Forms.Button name_edit_btn;

        private System.Windows.Forms.TextBox name_TB;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;

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