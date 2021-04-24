using IceCreamStore.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamStore
{
    public partial class IceCreamMelts : Form
    {

        private decimal _bill = 0.00M;
        private string _flavorpicked;
        public IceCreamMelts()
        {
            InitializeComponent();
        }

       






        private void OneScoopLbl_Click(object sender, EventArgs e)
        {
            OrderlistBox.Items.Add("One scoop - $2.20");
            _bill += 2.20M;

        }

        private void Scoopes2Lbl_Click(object sender, EventArgs e)
        {
            OrderlistBox.Items.Add("Two scoops - $3.00");
            _bill += 3.00M;

        }

        private void Scoopes3Lbl_Click(object sender, EventArgs e)
        {
            OrderlistBox.Items.Add("Three scoops - $4.00");
            _bill += 4.00M;
            
        }

        private void FlavorPicBox1_Click(object sender, EventArgs e)
        {
            OrderlistBox.Items.Add(" Chcolate Flavor");
            _flavorpicked = "Chcolate Flavor";
        }

        private void FlavorPicBox2_Click(object sender, EventArgs e)
        {
            OrderlistBox.Items.Add(" Vanilla Flavor");
            _flavorpicked = "Vanilla Flavor";
        }

        private void FlavorPicBox3_Click(object sender, EventArgs e)
        {
            OrderlistBox.Items.Add("  Oreo Flavor");
            _flavorpicked = "Oreo Flavor";
        }

        private void TopPicBox1_Click(object sender, EventArgs e)
        {
            OrderlistBox.Items.Add(" nuts topping - .$50");
            _bill += .50M;
        }

        private void TopPicBox2_Click(object sender, EventArgs e)
        {
            OrderlistBox.Items.Add(" cherries topping - .$50");
            _bill += .50M;
        }

        private void TopPicBox3_Click(object sender, EventArgs e)
        {
            OrderlistBox.Items.Add(" sryup topping - .$50");
            _bill += .50M;
        }

        private void OrderlistBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            string item = (string)OrderlistBox.SelectedItem;

           if (item == null) 
                return;

            if (item.Contains("topping"))
            {
                _bill -= .50M;
                OrderlistBox.Items.RemoveAt(OrderlistBox.SelectedIndex);
            }

          
            
            
            
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            var OrderForm = new Order(_bill, _flavorpicked);
            OrderForm.Show();
            this.Hide();
        }
    }
}
