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
    public partial class CashierView : Form
    {
        private EventHandler eventHandler;

        public CashierView(EventHandler h)
        {
            eventHandler = h;
            InitializeComponent();
        }

        private void uxNewTransaction_Click(object sender, EventArgs e)
        {
            eventHandler(sender, e);
        }

        private void uxFinishTransaction_Click(object sender, EventArgs e)
        {

        }

        private void uxAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
