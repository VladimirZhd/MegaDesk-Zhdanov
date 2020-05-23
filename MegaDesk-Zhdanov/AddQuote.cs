﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Zhdanov
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            _mainMenu.Show();
        }

        private void numericUpDownWidth_Validating(object sender, CancelEventArgs e)
        {

        }

        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            var desk = new Desk
            {
                Depth = numericUpDownDepth.Value,
                Width = numericUpDownWidth.Value,
                NumberOfDrawers = (int)numericUpDownDrawers.Value,
                Material = (DesktopMaterial)materialListDrop.SelectedValue
            };

            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = customerNameTextBox.Text,
                QuoteDate = DateTime.Now,
                DeliveryType = (Delivery)deliveryListLabel.SelectedValue
            };

            try
            {
                var price = deskQuote.GetQuotePrice();

                deskQuote.QuotePrice = price;


                DisplayQuote displayQuoteForm = new DisplayQuote(_mainMenu, deskQuote);
                displayQuoteForm.Show();
                Hide();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void SaveQuote(List<DeskQuote> quotes)
        {
            var quotesFile = @"qoute.json";

            
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            Array materialValues = Enum.GetValues(typeof(DesktopMaterial));
            Array materialNames = Enum.GetNames(typeof(DesktopMaterial));

            for (int i = 0; i < materialNames.Length; i++)
            {

            }
        }
    }
}