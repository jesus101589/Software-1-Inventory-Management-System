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
            string searchText = productsSearchTxtBox.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                productsDataGridView.DataSource = productsList;
            }
            else
            { 
                filteredProductsList = new BindingList<Product>(productsList.Where(p =>
                    p.ProductName.ToLower().Contains(searchText) ||
                    p.ProductID.ToString().Contains(searchText) ||
                    p.ProductInventory.ToString().Contains(searchText) ||
                    p.ProductPrice.ToString().Contains(searchText) ||
                    p.ProductMin.ToString().Contains(searchText) ||
                    p.ProductMax.ToString().Contains(searchText)
                ).ToList());

                productsDataGridView.DataSource = filteredProductsList;
            }
        }

        private void partsDeleteBtn_Click(object sender, EventArgs e)
        {
            // Check to see if a row is selected
            if (partsDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row (part)
                int selectedIndex = partsDataGridView.SelectedRows[0].Index;
                Part selectedPart = (Part)partsDataGridView.Rows[selectedIndex].DataBoundItem;

                // Now we check if the part is associated with any products
                bool isPartAssociated = productsList.Any(product => product.AssociatedParts.Contains(selectedPart));

                if (isPartAssociated)
                {
                    MessageBox.Show("Cannot delete this part because it is associated with one or more products.", "Delete Part", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verify deletion
                var result = MessageBox.Show($"Are you sure you want to delete the part '{selectedPart.PartName}'?", "Delete Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the part from the partsList
                    partsList.RemoveAt(selectedIndex);

                    // clear the selection in the DataGridView
                    partsDataGridView.ClearSelection();
                }
            }
            else
            { 
                MessageBox.Show("Please select a part to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void productsDeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void partsSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void productsSearchTxtBox_TextChanged(object sender, EventArgs e)
        { 
        
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void partsAddBtn_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart();
            if (addPartForm.ShowDialog() == DialogResult.OK)
            {
                // Add the new part to the partsList
                partsList.Add(addPartForm.Part);
            }
        }

        private void partsModifyBtn_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count > 0)
            { 
                int selectedIndex = partsDataGridView.SelectedRows[0].Index;
                Part selectedPart = partsList[selectedIndex];

                AddPart modifyPartForm = new AddPart(selectedPart);
                if (modifyPartForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the part in the partsList
                    partsList[selectedIndex] = modifyPartForm.Part;
                }
            }
        }

        private void productsModifyBtn_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0)
            { 
                int selectedIndex = productsDataGridView.SelectedRows[0].Index;
                Product selectedProduct = productsList[selectedIndex];

                AddProduct modifyProductForm = new AddProduct(selectedProduct, partsList);
                if (modifyProductForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the product in the productsList
                    productsList[selectedIndex] = modifyProductForm.Product;
                }
            }
        }

        private void productsAddBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct(partsList);
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                // Add the new product to the productsList
                productsList.Add(addProductForm.Product);
            }
        }
    }
}
