using System;
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
            var frmDisplayQuote = new DisplayQuote(_mainMenu);
            frmDisplayQuote.Show();

            Hide();
        }
    }
}
