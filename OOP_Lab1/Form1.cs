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

        private void infBtn_Click(object sender, EventArgs e)
        {
            ToStringTB.Text = _operator.ToString();
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new System.NotImplementedException();
        }
        
    }
}