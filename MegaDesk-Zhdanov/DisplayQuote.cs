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
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu;
        private DeskQuote _quote;


        public DisplayQuote()
        {
            InitializeComponent();
 
        }
        public DisplayQuote(DeskQuote deskQuote) : this()
        {
            _quote = deskQuote;
        }


        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
