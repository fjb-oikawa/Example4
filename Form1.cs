﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int iValue; //変数 iValueの宣言
            
            iValue = int.Parse(tbxNum.Text);
            lblAns.Text = String.Format("{0}",iValue*10);
            
        }
    }
}
