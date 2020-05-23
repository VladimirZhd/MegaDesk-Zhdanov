﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Zhdanov
{
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu;
        private DeskQuote _quote; 
        public DisplayQuote(Form mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
