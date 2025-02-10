using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Lab1.MyClass;

namespace OOP_Lab1
{
    
    public partial class Form1 : Form
    {

        private InternetOp _operator;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _operator = new InternetOp();
            MessageBox.Show("Лабораторная работа 1, 23ВП1, Сёмкин К.М. Ермаков Д.А.", "Лабораторная работа №1");
        }

        private void writeAll_Click(object sender, EventArgs e)
        {
            ToStringTB.Text = _operator.ToString();
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void writeSlctd_Click(object sender, EventArgs e) {
            string res = "";
            if (name_chb.Checked) {
                res += "\r\nName: " + _operator.getName();
            }
            if (region_chb.Checked) {
                res += "\r\nRegion: " + _operator.getRegion();
            }
            if (price_chb.Checked) {
                res += "\r\nPrice: " + _operator.getPrice();
            }
            if (abonentCount_chb.Checked) {
                res += "\r\nAbonent count: " + _operator.getAbonentCount();
            }
            if (age_chb.Checked) {
                res += "\r\nAge: " + _operator.getAge();
            }
            if (benefits_chb.Checked) {
                res += "\r\nBenefits: " + _operator.getBenefits();
            }
            if (supports5g_chb.Checked) {
                res += "\r\n5G support: " + _operator.get5gSupport();
            }

            ToStringTB.Text = res.Substring(2);
        }
    }
}