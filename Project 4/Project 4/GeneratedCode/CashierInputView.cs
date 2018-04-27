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
    public partial class CashierInputView : Form
    {
        private SalesManager.TransactionHandler transHandler;
        private SalesManager.ItemHandler itemHandler;
        private int transactionID = 0;
        public CashierInputView(SalesManager.TransactionHandler h, SalesManager.ItemHandler i)
        {
            transHandler = h;
            itemHandler = i;
            InitializeComponent();
            uxAdd.Enabled = false;
            uxFinishTransaction.Enabled = false;
            uxItemName.Enabled = false;
            uxPrice.Enabled = false;
            uxQuantity.Enabled = false;

        }

        private void uxNewTransaction_Click(object sender, EventArgs e)
        {
            uxFinishTransaction.Enabled = true;
            uxItemName.Enabled = true;
            uxPrice.Enabled = true;
            uxQuantity.Enabled = true;
            uxNewTransaction.Enabled = false;
            transactionID++;
            uxTransactionID.Text = transactionID.ToString();
            transHandler(transactionID);
        }

        private void uxFinishTransaction_Click(object sender, EventArgs e)
        {
            uxFinishTransaction.Enabled = false;
            uxItemName.Enabled = false;
            uxPrice.Enabled = false;
            uxQuantity.Enabled = false;
            uxNewTransaction.Enabled = true;
            uxItemName.Clear();

        }

     

        private void uxItemName_TextChanged(object sender, EventArgs e)
        {
            uxAdd.Enabled = true;
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {

            itemHandler((int)uxQuantity.Value, (float)uxPrice.Value, uxItemName.Text);
            uxItemName.Clear();
            uxAdd.Enabled = false;
        }

    }
}
