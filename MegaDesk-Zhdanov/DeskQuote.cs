using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Zhdanov
{
    public enum Delivery
    {
        [Description("Rush 3 Days")]
        Rush3Day,

        [Description("Rush 5 Days")]
        Rush5Day,

        [Description("Rush 7 Days")]
        Rush7Day,

        [Description("No Rush")]
        Normal14Days
    }

    class DeskQuote
    {

        private int[,] _rushOrderPrices;

        private const decimal BASE_DESK_PRICE = 200.00M;
        private const decimal SURFACE_AREA_COST = 1.00M;
        private const decimal DRAWER_COST = 50.00M;
        private const decimal OAK_COST = 200.00M;
        private const decimal LAMINATE_COST = 100.00M;
        private const decimal PINE_COST = 50.00M;
        private const decimal ROSEWOOD_COST = 300.00M;
        private const decimal VENEER_COST = 125.00M;


        public Desk Desk { get; set; }

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public Delivery DeliveryType { get; set; }

        public decimal QuotePrice { get; set; }

        public decimal GetQuotePrice()
        {
            getRushOrderPrices();

            decimal quotePrice = BASE_DESK_PRICE;

            decimal surfaceArea = this.Desk.Depth * this.Desk.Width;

            decimal surfacePrice = 0.00M;

            

            return 0;
        }

        private void getRushOrderPrices()
        {
            _rushOrderPrices = new int[3, 3];

            var pricesFile = @"rushOrderPrices.txt";

            try
            {
                string[] prices = File.ReadAllLines(pricesFile);
                int i = 0, j = 0;

                foreach (string price in prices)
                {
                    _rushOrderPrices[i, j] = int.Parse(price);

                    if (j == 2)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
