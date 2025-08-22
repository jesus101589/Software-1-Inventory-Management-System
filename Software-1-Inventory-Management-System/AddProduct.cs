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
            // line 38 on github AddProduct.cs Still need to create GUI first.
        }
    }
}
