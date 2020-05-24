using System;
using System.Windows.Forms;

namespace MegaDesk_Zhdanov
{
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu; 
        public DisplayQuote(Form mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            deskQuoteCustomer.Text = deskQuote.CustomerName;
            deskQuoteWidth.Text = deskQuote.Desk.Width.ToString();
            deskQuoteDepth.Text = deskQuote.Desk.Depth.ToString();
            deskQuoteDrawers.Text = deskQuote.Desk.NumberOfDrawers.ToString();
            deskQuoteMaterial.Text = deskQuote.Desk.Material.ToString();
            deskQuoteDelivery.Text = deskQuote.DeliveryType.ToString();
            priceQuoteTxt.Text = deskQuote.QuotePrice.ToString("C");
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void deskQuoteDelivery_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            _mainMenu.Show();
        }
    }
}
