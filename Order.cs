using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamStore.Images
{
    public partial class Order : Form
    {
        private decimal _total;
        private string _flavorPicked;
        public Order( decimal total , string flavor)
        {
            InitializeComponent();
            _total = total;
            _flavorPicked = flavor;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            TotalLbl.Text += _total;
            FlavorsLbl.Text += _flavorPicked;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
