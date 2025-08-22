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
    public partial class AddPart : Form
    {
        public Part Part { get; private set; }
        public AddPart()
        {
            InitializeComponent();
            InitializeForm(null); // No part to edit so it adds. Add Operation
        }

        public AddPart(Part part)
        {
            InitializeComponent();
            InitializeForm(part); // Part to edit so it updates. Modify Operation
        }

        private void InitializeForm(Part part)
        {   


            partInHouseRadioBtn.CheckedChanged += new EventHandler(partInHouseRadioBtn_CheckedChanged);
            partOutsourcedRadioBtn.CheckedChanged += new EventHandler(partOutsourcedRadioBtn_CheckedChanged);

            if (part != null)
            {
                modifyPartLabel.Visible = true;
                addPartCompanyNameLabel.Visible = false;

                // Populate the form fields with the part details
                addPartIDTxtBox.Text = part.PartID.ToString();
                addPartNameTxtBox.Text = part.PartName;
                addPartInventoryTxtBox.Text = part.PartInventory.ToString();
                addPartPriceTxtBox.Text = part.PartPrice.ToString();
                addPartMinTxtBox.Text = part.PartMin.ToString();
                addPartMaxTxtBox.Text = part.PartMax.ToString();

                if (part.PartMachineID.HasValue)
                {
                    partInHouseRadioBtn.Checked = true;
                    addPartMachineIDTxtBox.Text = part.PartMachineID.ToString();
                }
                else
                {
                    partOutsourcedRadioBtn.Checked = true;
                    addPartCompanyNameTxtBox.Text = part.PartCompanyName;
                }
            }
            else 
            {
                modifyPartLabel.Visible = false;
                addPartCompanyNameLabel.Visible = true;

                partInHouseRadioBtn.Checked = true; // Default to In-House
            }
        }

        private void partOutsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (partInHouseRadioBtn.Checked)
            {
                addPartMachineIDLabel.Visible = true;
                addPartMachineIDTxtBox.Visible = true;
            }
            else if (partOutsourcedRadioBtn.Checked)
            {
                addPartMachineIDLabel.Visible = false;
                addPartMachineIDTxtBox.Visible = false;
            }
        }

        private void partInHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (partInHouseRadioBtn.Checked)
            { 
                
                addPartCompanyNameLabel.Visible = false;
                addPartCompanyNameTxtBox.Visible = false;
            }
            else if (partOutsourcedRadioBtn.Checked)
            { 
                addPartCompanyNameLabel.Visible = true;
                addPartCompanyNameTxtBox.Visible = true;
            }
        }

        private void addPartCompanyNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            // This is just a placeholder for the text changed event
        }

        private void addPartCompanyNameLabel_Click(object sender, EventArgs e)
        {
            // This is just a placeholder for the label click event
        }

        private void addPartCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without saving
        }

        private void addPartSaveBtn_Click(object sender, EventArgs e)
        {
            // need to add logic here....will come back to this later
        }

        private void addPartMinLabel_Click(object sender, EventArgs e)
        {
            // This is just a placeholder for the label click event
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            // This is just a placeholder for the form load event
        }

        private void addPartPriceLabel_Click(object sender, EventArgs e)
        {
            // This is just a placeholder for the label click event
        }

        
        private void addPartSaveBtn_Click_1(object sender, EventArgs e)
        {
            // Checks if any of the required fields are empty before saving
            if (string.IsNullOrWhiteSpace(addPartIDTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addPartNameTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addPartInventoryTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addPartPriceTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addPartMinTxtBox.Text) ||
                string.IsNullOrWhiteSpace(addPartMaxTxtBox.Text) ||
                (partInHouseRadioBtn.Checked && string.IsNullOrWhiteSpace(addPartMachineIDTxtBox.Text)) || //This validates Machine ID if In-House
                (partOutsourcedRadioBtn.Checked && string.IsNullOrWhiteSpace(addPartCompanyNameTxtBox.Text))) //This validates Company Name if Outsourced

            { 
                MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validata Numeric fields data types
            if (!int.TryParse(addPartIDTxtBox.Text, out _) ||
                !int.TryParse(addPartInventoryTxtBox.Text, out _) ||
                !decimal.TryParse(addPartPriceTxtBox.Text, out _) ||
                !int.TryParse(addPartMinTxtBox.Text, out _) ||
                !int.TryParse(addPartMaxTxtBox.Text, out _) ||
                partInHouseRadioBtn.Checked && !int.TryParse(addPartMachineIDTxtBox.Text, out _)) // Validate Machine ID if In-House
            {
                MessageBox.Show("Please enter valid numeric values for ID, Inventory, Price, Min, and Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Now we parse the input values
            int inventory = int.Parse(addPartInventoryTxtBox.Text);
            int min = int.Parse(addPartMinTxtBox.Text);
            int max = int.Parse(addPartMaxTxtBox.Text);

            // Check if Min is less than Max and Inventory is within the range
            if (min > max)
            { 
                MessageBox.Show("Minimum value cannot be greater than Maximum value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inventory < min || inventory > max)
            { 
                MessageBox.Show("Inventory must be between Minimum and Maximum values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (partInHouseRadioBtn.Checked)
            {
                // Create a new In-House part
                Part = new Part
                {
                    PartID = int.Parse(addPartIDTxtBox.Text),
                    PartName = addPartNameTxtBox.Text,
                    PartInventory = inventory,
                    PartPrice = decimal.Parse(addPartPriceTxtBox.Text),
                    PartMin = min,
                    PartMax = max,
                    PartMachineID = int.Parse(addPartMachineIDTxtBox.Text),
                    PartCompanyName = null // In-House parts do not have a company name
                };
            }
            else if (partOutsourcedRadioBtn.Checked)
            {
                // Create a new Outsourced part
                Part = new Part
                {
                    PartID = int.Parse(addPartIDTxtBox.Text),
                    PartName = addPartNameTxtBox.Text,
                    PartInventory = inventory,
                    PartPrice = decimal.Parse(addPartPriceTxtBox.Text),
                    PartMin = min,
                    PartMax = max,
                    PartMachineID = null, // Outsourced parts do not have a machine ID
                    PartCompanyName = addPartCompanyNameTxtBox.Text
                };
            }

            this.DialogResult = DialogResult.OK; // Set the dialog result to OK to indicate success
            this.Close(); // Close the form after saving

        }
    }
}
