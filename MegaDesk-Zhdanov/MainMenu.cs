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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            var frmAddQuote = new AddQuote(this);
            frmAddQuote.Show();

            Hide();
        }

        private void viewQuote_Click(object sender, EventArgs e)
        {
            var frmViewQuote = new ViewAllQuotes(this);
            frmViewQuote.Show();

            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            var frmSearchQuote = new SearchQuotes(this);
            frmSearchQuote.Show();

            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
