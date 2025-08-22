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
    public partial class AddProduct : Form
    {
        public Product Product { get; private set; }
        private BindingList<Part> associatedPartsList = new BindingList<Part>();
        private BindingList<Part> partsList;
        public AddProduct(BindingList <Part> partsList)
        {
            InitializeComponent();
            this.partsList = partsList;
            InitializeForm(null, partsList);
        }

        public AddProduct(Product product, BindingList<Part> partsList)
        {
            InitializeComponent();
            this.partsList = partsList;
            InitializeForm(product, partsList);
        }

        private void InitializeForm(Product product, BindingList<Part> partsList)
        {
            // This will Bind the partsList to the DataGridView in the AddProduct form
            addProductCandidateDgv.DataSource = partsList;
            addProductAssociatedDgv.DataSource = associatedPartsList;

            // Customize the DataGridViews
            CustomizeAddProductCandidateDgv();
            CustomizeAddProductAssociatedDgv();

            if (product != null)
            {
                modifyProductLabel.Visible = true;
                addProductTitleLabel.Visible = false;

                // Populate the fields with the product data
                addProductIDTxtBox.Text = product.ProductID.ToString();
                addProductNameTxtBox.Text = product.ProductName;
                addProductInventoryTxtBox.Text = product.ProductInventory.ToString();
                addProductPriceTxtBox.Text = product.ProductPrice.ToString();
                addProductMinTxtBox.Text = product.ProductMin.ToString();
                addProductMaxTxtBox.Text = product.ProductMax.ToString();

                // Populate the associated parts list
                foreach (var part in product.AssociatedParts)
                {
                    associatedPartsList.Add(part);
                }
            }
            else
            { 
                modifyProductLabel.Visible = false;
                addProductTitleLabel.Visible = true;
            }
        }

        private void CustomizeAddProductCandidateDgv()
        {
            if (addProductCandidateDgv.Columns.Contains("PartMachineID"))
            {
                addProductCandidateDgv.Columns["PartMachineId"].Visible = false;
            }

            if (addProductCandidateDgv.Columns.Contains("PartCompanyName"))
            {
                addProductCandidateDgv.Columns["PartCompanyName"].Visible = false;
            }

            addProductCandidateDgv.ReadOnly = true;
            addProductCandidateDgv.RowHeadersVisible = false;
            addProductCandidateDgv.AllowUserToAddRows = false;
            addProductCandidateDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Modify the Headers in the addProductCandidateDgv
            addProductCandidateDgv.Columns["PartID"].HeaderText = "Part ID";
            addProductCandidateDgv.Columns["PartName"].HeaderText = "Name";
            addProductCandidateDgv.Columns["PartInventory"].HeaderText = "Inventory";
            addProductCandidateDgv.Columns["PartPrice"].HeaderText = "Price";
            addProductCandidateDgv.Columns["PartMin"].HeaderText = "Min";
            addProductCandidateDgv.Columns["PartMax"].HeaderText = "Max";
        }

        private void CustomizeAddProductAssociatedDgv()
        { 
            if (addProductAssociatedDgv.Columns.Contains("PartMachineID"))
            {
                addProductAssociatedDgv.Columns["PartMachineId"].Visible = false;
            }

            if (addProductAssociatedDgv.Columns.Contains("PartCompanyName"))
            {
                addProductAssociatedDgv.Columns["PartCompanyName"].Visible = false;
            }

            addProductAssociatedDgv.ReadOnly = true;
            addProductAssociatedDgv.RowHeadersVisible = false;
            addProductAssociatedDgv.AllowUserToAddRows = false;
            addProductAssociatedDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Modify the Headers in the addProductAssociatedDgv
            addProductAssociatedDgv.Columns["PartID"].HeaderText = "Part ID";
            addProductAssociatedDgv.Columns["PartName"].HeaderText = "Name";
            addProductAssociatedDgv.Columns["PartInventory"].HeaderText = "Inventory";
            addProductAssociatedDgv.Columns["PartPrice"].HeaderText = "Price";
            addProductAssociatedDgv.Columns["PartMin"].HeaderText = "Min";
            addProductAssociatedDgv.Columns["PartMax"].HeaderText = "Max";
        }

        private void addProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProductSaveBtn_Click(object sender, EventArgs e)
        {
            // We will parse and validate the input fields here
            int inventory = int.Parse(addProductInventoryTxtBox.Text);
            int min = int.Parse(addProductMinTxtBox.Text);
            int max = int.Parse(addProductMaxTxtBox.Text);

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max values.", "validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create or update the Product object
            Product = new Product
            {
                ProductID = int.Parse(addProductIDTxtBox.Text),
                ProductName = addProductNameTxtBox.Text,
                ProductInventory = inventory,
                ProductPrice = decimal.Parse(addProductPriceTxtBox.Text),
                ProductMin = min,
                ProductMax = max
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // place holder for additional modifications
        }

        private void addProductDeleteBtn_Click(object sender, EventArgs e)
        {
            if (addProductAssociatedDgv.SelectedRows.Count > 0)
            {
                // retrieve select part from the grid
                int selectedIndex = addProductAssociatedDgv.SelectedRows[0].Index;
                Part selectedPart = (Part)addProductAssociatedDgv.Rows[selectedIndex].DataBoundItem;

                // Delete the associated part from the associated parts list
                associatedPartsList.Remove(selectedPart);
            }
            else
            { 
                MessageBox.Show("Please select a part to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addPartBtn_Click(object sender, EventArgs e)
        {
            if (addProductCandidateDgv.SelectedRows.Count > 0)
            {
                int selectedIndex = addProductCandidateDgv.SelectedRows[0].Index;
                Part selectedPart = (Part)addProductCandidateDgv.Rows[selectedIndex].DataBoundItem;

                if (!associatedPartsList.Contains(selectedPart))
                {
                    associatedPartsList.Add(selectedPart);
                }
                else
                {
                    MessageBox.Show("This part is already associated with the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addPartSaveBtn_Click(object sender, EventArgs e)
        {
            // Scan for empty fields
            if (string.IsNullOrWhiteSpace(addProductIDTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addProductNameTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addProductInventoryTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addProductPriceTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addProductMinTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addProductMaxTxtBox.Text))

            { 
                MessageBox.Show("All fields are required. Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate data types for numeric values
            if (!int.TryParse(addProductIDTxtBox.Text, out _) ||
                !int.TryParse(addProductInventoryTxtBox.Text, out _) ||
                !decimal.TryParse(addProductPriceTxtBox.Text, out _) ||
                !int.TryParse(addProductMinTxtBox.Text, out _) ||
                !int.TryParse(addProductMaxTxtBox.Text, out _))
            { 
                MessageBox.Show("Please enter valid numeric values for ID, Inventory, Price, Min, and Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse input values
            int inventory = int.Parse(addProductInventoryTxtBox.Text);
            int min = int.Parse(addProductMinTxtBox.Text);
            int max = int.Parse(addProductMaxTxtBox.Text);

            if (min > max)
            {
                MessageBox.Show("Min value cannot be greater than Max value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory value must be between Min and Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check that the associated parts list is updated or createe a new product object
            if (Product == null)
            {
                Product = new Product();
            }

            // Update the product fields
            Product.ProductID = int.Parse(addProductIDTxtBox.Text);
            Product.ProductName = addProductNameTxtBox.Text;
            Product.ProductInventory = inventory;
            Product.ProductPrice = decimal.Parse(addProductPriceTxtBox.Text);
            Product.ProductMin = min;
            Product.ProductMax = max;

            // Update the associated parts list
            Product.AssociatedParts = associatedPartsList.ToList();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void addProductSearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = addProductSearchTxtBox.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // reset grid
                addProductCandidateDgv.DataSource = partsList;
            }
            else 
            {
                var filteredPartsList = partsList.Where(p =>
                    p.PartName.ToLower().Contains(searchText) ||
                    p.PartID.ToString().Contains(searchText) ||
                    p.PartInventory.ToString().Contains(searchText) ||
                    p.PartPrice.ToString().Contains(searchText) ||
                    p.PartMin.ToString().Contains(searchText) ||
                    p.PartMax.ToString().Contains(searchText)).ToList();
                addProductCandidateDgv.DataSource = new BindingList<Part>(filteredPartsList);
            }
        }
    }
}
