﻿using ManagementSoftware.GUI.Section;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI
{
    public partial class PurchaseOrder : Form
    {
        // Aleart
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;

        //change form
        public delegate void ChangeForm(Form form);
        public ChangeForm changeForm;
        public PurchaseOrder()
        {
            InitializeComponent();
        }
    }
}
