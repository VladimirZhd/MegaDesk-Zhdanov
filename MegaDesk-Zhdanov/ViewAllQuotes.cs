using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MegaDesk_Zhdanov
{
    public partial class ViewAllQuotes : Form
    {
        private Form _mainMenu;
        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void returnToMainBtn_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            Hide();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            var file = @"quotes.json";
            using (StreamReader reader = new StreamReader(file))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskOrders = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                viewAllQuotesGrid.DataSource = deskOrders.Select(d => new
                {
                    Customer = d.CustomerName,
                    Width = d.Desk.Width,
                    Depth = d.Desk.Depth,
                    Drawers = d.Desk.NumberOfDrawers,
                    SurfaceMaterial = d.Desk.Material,
                    Delivery = d.DeliveryType,
                    QuoteTotal = d.QuotePrice.ToString("C")

                }).ToList();
            }
        }
    }
}
