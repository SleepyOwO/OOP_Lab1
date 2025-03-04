using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OOP_Lab1.MyClass;
using OOP_Lab1.MyExceptions;

namespace OOP_Lab1
{
    
    public partial class Form1 : Form
    {

        private ArrayList _operatorList = new ArrayList();
        private InternetOp _operator;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox(IntPtr.Zero, "Лабораторная работа 1, 23ВП1, Сёмкин К.М. Ермаков Д.А.", "Лабораторная работа №1", 0x00000000);
        }
        
        
        
        private void createOp_Click(object sender, EventArgs e) {
            string name = name_TB.Text;
            string region = region_TB.Text;
            int price = (int)price_Nud.Value;
            int abonents = (int)abonents_Nud.Value;
            double age = (double)age_Nud.Value;
            bool benefits = benefits_chb.Checked;
            bool support5G = supports5g_chb.Checked;
            _operator = new InternetOp(name, region, price, abonents, age, benefits, support5G);
            if (_operator != null) {
                _operatorList.Add(_operator);
                operatorDGV.Rows.Add(false, _operator.getName(), _operator);
            }

            name_edit_btn.Enabled = true;
            region_edit_btn.Enabled = true;
            price_edit_btn.Enabled = true;
            abonents_edit_btn.Enabled = true;
            age_edit_btn.Enabled = true;
        }
        
        private void writeAll_Click(object sender, EventArgs e)
        {
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            if (curOp != null) {
                ToStringTB.Text = curOp.ToString();
            } else {
                throw new UndefinedOperatorException();
            }
        }
        


        private void writeSlctd_Click(object sender, EventArgs e) {
            if (_operator == null) throw new UndefinedOperatorException();
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            string res = "";
            if (name_chb.Checked) {
                res += "\r\nName: " + curOp.getName();
            }
            if (region_chb.Checked) {
                res += "\r\nRegion: " + curOp.getRegion();
            }
            if (price_chb.Checked) {
                res += "\r\nPrice: " + curOp.getPrice();
            }
            if (abonentCount_chb.Checked) {
                res += "\r\nAbonent count: " + curOp.getAbonentCount().ToString("X");
            }
            if (age_chb.Checked) {
                res += "\r\nAge: " + curOp.getAge();
            }
            if (benefits_chb.Checked) {
                res += "\r\nBenefits: " + curOp.getBenefits();
            }
            if (supports5g_chb.Checked) {
                res += "\r\n5G support: " + curOp._supports5g;
            }

            ToStringTB.Text = res == ""? res : res.Substring(2);
        }

        private void haveBenefits_chb_CheckedChanged(object sender, EventArgs e) {
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            if (_operator != null) 
                curOp.setBenefits(haveBenefits_chb.Checked);
        }

        private void have5G_chb_CheckedChanged(object sender, EventArgs e) {
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            if (_operator != null)
                curOp.set5gSupport(haveBenefits_chb.Checked);
        }

        private void name_edit_btn_Click(object sender, EventArgs e) {
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            if(name_TB.Text != "") curOp.setName(name_TB.Text);
        }

        private void region_edit_btn_Click(object sender, EventArgs e) {
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            if(region_TB.Text != "") curOp.setRegion(region_TB.Text);
        }

        private void price_edit_btn_Click(object sender, EventArgs e) {
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            curOp.setPrice((int)price_Nud.Value);
        }

        private void abonents_edit_btn_Click(object sender, EventArgs e) {
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            curOp.setAbonentCount((int)abonents_Nud.Value);
        }

        private void age_edit_btn_Click(object sender, EventArgs e) {
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            curOp.setAge((int)age_Nud.Value);
        }
        
        //Средний прирост клиентов за год работы компании

        private void midCalc_Click(object sender, EventArgs e) {
            InternetOp curOp = (InternetOp) operatorDGV.Rows[0].Cells[2].Value;
            try {
                double midAbonentCount = 
                    curOp.getAbonentCount() * curOp.getPrice() * (int)curOp.getAge() / (int)
                    curOp.getAge();
                MessageBox(IntPtr.Zero, midAbonentCount.ToString(), "Средняя прибыль", 0x00000000);
            }
            catch (DivideByZeroException ex) {
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка деления на ноль!", 0x00000000);
            }
        }


        private void operatorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int col = 0;
            for (int r = 0; r < operatorDGV.Rows.Count; r++)
                if (r != e.RowIndex && e.ColumnIndex == col ) 
                    operatorDGV[col , r].Value = false;
        }
    }
}