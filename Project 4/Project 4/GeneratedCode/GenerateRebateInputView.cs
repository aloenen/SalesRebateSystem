﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4.GeneratedCode
{
    public partial class GenerateRebateInputView : Form
    {
        private RebateManager.GenRebateHandler genRebateHandle;

        public GenerateRebateInputView(RebateManager.GenRebateHandler h)
        {
            genRebateHandle = h;
            InitializeComponent();
        }

        private void uxGenerateRebateButton_Click(object sender, EventArgs e)
        {
            genRebateHandle(3);
        }
    }
}