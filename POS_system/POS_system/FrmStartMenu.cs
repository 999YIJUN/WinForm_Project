﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class FrmStartMenu : Form
    {
        public static FrmStartMenu instance;
        public static FrmStartMenu GetInstance()
        {
            if (instance == null)
            {
                instance = new FrmStartMenu();
            }
            return instance;
        }
        private FrmStartMenu()
        {
            InitializeComponent();
        }

        private void FrmStartMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            FrmMain.GetIntance().ShowDialog();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            Form1.GetInstance().ShowDialog();
        }

        private void FrmStartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
