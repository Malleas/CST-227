using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();
        DateTime moment = new DateTime();
        BindingSource carListBinding = new BindingSource();
        BindingSource shoppingListBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            SetBindings();
        }

        private void SetBindings()
        {
            carListBinding.DataSource = store.CarList;
            carInventoryListBox.DataSource = carListBinding;
            carInventoryListBox.DisplayMember = "Display";
            carInventoryListBox.ValueMember = "Display";

            shoppingListBinding.DataSource = store.ShoppingList;
            shoppingCartListBox.DataSource = shoppingListBinding;
            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void createCarGroupBox_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carInventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createCarBtn_Click(object sender, EventArgs e)
        {
            Car newCar = new Car();

            try
            {
                if (makeTextBox.Text.Equals(""))
                {
                    throw new Exception("***Make empty, input required.***");
                }
                else
                {
                    newCar.Make = makeTextBox.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (modelTextBox.Text.Equals(""))
                {
                    throw new Exception("***Model empty, input required.***");
                }
                else
                {
                    newCar.Model = modelTextBox.Text;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


            try
            {
                if (Decimal.Parse(priceTextBox.Text) <= 0)
                {
                    throw new Exception("***Price required greater than 0.****");
                }
                else
                {
                    newCar.Price = Decimal.Parse(priceTextBox.Text);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            try
            {

                if ((int.Parse(yearTextBox.Text) < 1945) || (int.Parse(yearTextBox.Text) > 2021))
                {
                    throw new Exception("*** Year required between 1945 and " + 2021 + "***");
                }
                else
                {
                    newCar.Year = int.Parse(yearTextBox.Text);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
                try { 
                if (colorTextBox.Text.Equals(""))
                {
                    throw new Exception("***Color empty, input required.***");
                }
                else {
                    newCar.Color = colorTextBox.Text;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


            if (!newCar.Make.Equals("") && !newCar.Model.Equals("") && newCar.Price != 0 && newCar.Year != 0 && !newCar.Color.Equals("")) {
                store.CarList.Add(newCar);
                makeTextBox.Clear();
                modelTextBox.Clear();
                priceTextBox.Clear();
                yearTextBox.Clear();
                colorTextBox.Clear();

                carListBinding.ResetBindings(false);
            }
            
            

            
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            store.ShoppingList.Add((Car)carInventoryListBox.SelectedItem);

            shoppingListBinding.ResetBindings(false);
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            decimal total = store.checkout();
            totalCostOutputLabel.Text = total.ToString();
        }
    }
}
