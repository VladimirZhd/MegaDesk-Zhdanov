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
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;

        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            materialListDrop.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void materialListDrop_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
