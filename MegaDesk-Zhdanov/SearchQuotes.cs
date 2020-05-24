using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Zhdanov
{
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;

        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();
            materialListDrop.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            _mainMenu = mainMenu;
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void returnToMainBtn_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            Hide();
        }

        private void materialListDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var orderFile = @"quotes.json";

                string selected = materialListDrop.SelectedItem.ToString();

                using (StreamReader reader = new StreamReader(orderFile))
                {
                    string newQuotes = reader.ReadToEnd();
                    List<DeskQuote> deskOrders = JsonConvert.DeserializeObject<List<DeskQuote>>(newQuotes);
                    List<DeskQuote> showOrders = new List<DeskQuote>();

                    foreach (DeskQuote selectedQuote in deskOrders)
                    {
                        if (selectedQuote.Desk.Material.ToString() == selected)
                        {
                            showOrders.Add(selectedQuote);
                        }
                    }

                    searchQuotesGrid.DataSource = deskOrders.Select(d => new
                    {
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.NumberOfDrawers,
                        SurfaceMaterial = d.Desk.Material,
                        Delivery = d.DeliveryType,
                        QuoteAmount = d.QuotePrice.ToString("c")
                    }).Where(q => q.SurfaceMaterial == (DesktopMaterial)materialListDrop.SelectedItem).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
