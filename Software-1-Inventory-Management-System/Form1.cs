using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_1_Inventory_Management_System.Models;

namespace Software_1_Inventory_Management_System
{
    public partial class MainScreen : Form
    {
        private BindingList<Models.Part> partsList = new BindingList<Models.Part>();
        private BindingList<Product> productsList = new BindingList<Product>();
        private BindingList<Models.Part> filteredPartsList;
        private BindingList<Product> filteredProductsList; 

        public MainScreen()
        {
            InitializeComponent();
            InitializeData();

            // Wire up Event Handlers
            partsDeleteBtn.Click += new EventHandler(partsDeleteBtn_Click);
            partsSearchBtn.Click += new EventHandler(partsSearchBtn_Click);
            productsDeleteBtn.Click += new EventHandler(productsDeleteBtn_Click);
            productsSearchBtn.Click += new EventHandler(productsSearchBtn_Click);
        }


        private void InitializeData()
        {
            partsList.Add(new Models.Part { PartID = 0, PartName = "Wheel", PartInventory = 15, PartPrice = 12.11m, PartMin = 5, PartMax = 25 });
            partsList.Add(new Models.Part { PartID = 1, PartName = "Pedal", PartInventory = 11, PartPrice = 8.22m, PartMin = 5, PartMax = 25 });
            partsList.Add(new Models.Part { PartID = 2, PartName = "Chain", PartInventory = 12, PartPrice = 8.33m, PartMin = 5, PartMax = 25 });
            partsList.Add(new Models.Part { PartID = 3, PartName = "Seat", PartInventory = 18, PartPrice = 4.55m, PartMin = 2, PartMax = 15 });

            productsList.Add(new Product { ProductID = 0, ProductName = "Red Bicycle", ProductInventory = 15, ProductPrice = 11.44m, ProductMin = 1, ProductMax = 25 });
            productsList.Add(new Product { ProductID = 1, ProductName = "Yellow Bicycle", ProductInventory = 19, ProductPrice = 9.66m, ProductMin = 1, ProductMax = 20 });
            productsList.Add(new Product { ProductID = 2, ProductName = "Blue Bicycle", ProductInventory = 5, ProductPrice = 12.77m, ProductMin = 1, ProductMax = 25 });

            // This will Bind the lists to the DataGridViews
            partsDataGridView.DataSource = partsList;
            productsDataGridView.DataSource = productsList;

            // partsDGV customization
            partsDataGridView.Columns["PartMachineID"].Visible = false;
            partsDataGridView.Columns["PartCompanyName"].Visible = false;
            partsDataGridView.ReadOnly = true;
            partsDataGridView.RowHeadersVisible = false;
            partsDataGridView.AllowUserToAddRows = false;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Modify the Headers in the partsDataGridView
            partsDataGridView.Columns["PartID"].HeaderText = "Part ID";
            partsDataGridView.Columns["PartName"].HeaderText = "Part Name";
            partsDataGridView.Columns["PartInventory"].HeaderText = "Inventory";
            partsDataGridView.Columns["PartPrice"].HeaderText = "Price";
            partsDataGridView.Columns["PartMin"].HeaderText = "Min";
            partsDataGridView.Columns["PartMax"].HeaderText = "Max";

            // productsDGV customization
            productsDataGridView.ReadOnly = true;
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Modify the Headers in the productsDataGridView
            productsDataGridView.Columns["ProductID"].HeaderText = "Product ID";
            productsDataGridView.Columns["ProductName"].HeaderText = "Product Name";
            productsDataGridView.Columns["ProductInventory"].HeaderText = "Inventory";
            productsDataGridView.Columns["ProductPrice"].HeaderText = "Price";
            productsDataGridView.Columns["ProductMin"].HeaderText = "Min";
            productsDataGridView.Columns["ProductMax"].HeaderText = "Max";
        }

        private void partsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void partsSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void productsSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void partsDeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void productsDeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
