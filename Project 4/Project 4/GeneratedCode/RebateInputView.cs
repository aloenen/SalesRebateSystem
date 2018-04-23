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
    public partial class RebateInputView : Form
    {
        private RebateManager.EnterRebateHandler enterRebateHandle;

        public RebateInputView(RebateManager.EnterRebateHandler r)
        {
            enterRebateHandle = r;
            InitializeComponent();
        }

        private void uxEnterRebateButton_Click(object sender, EventArgs e)
        {
            enterRebateHandle(); 
        }
    }
}
