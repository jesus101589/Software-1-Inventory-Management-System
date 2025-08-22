namespace Software_1_Inventory_Management_System
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleAddPartLabel = new System.Windows.Forms.Label();
            this.partInHouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.partOutsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.addPartIDLabel = new System.Windows.Forms.Label();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.addPartInventoryLabel = new System.Windows.Forms.Label();
            this.addPartPriceLabel = new System.Windows.Forms.Label();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.addPartMachineIDLabel = new System.Windows.Forms.Label();
            this.addPartIDTxtBox = new System.Windows.Forms.TextBox();
            this.addPartNameTxtBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryTxtBox = new System.Windows.Forms.TextBox();
            this.addPartPriceTxtBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTxtBox = new System.Windows.Forms.TextBox();
            this.addPartMachineIDTxtBox = new System.Windows.Forms.TextBox();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartMinTxtBox = new System.Windows.Forms.TextBox();
            this.addPartCancelBtn = new System.Windows.Forms.Button();
            this.addPartSaveBtn = new System.Windows.Forms.Button();
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.addPartCompanyNameLabel = new System.Windows.Forms.Label();
            this.addPartCompanyNameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleAddPartLabel
            // 
            this.titleAddPartLabel.AutoSize = true;
            this.titleAddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAddPartLabel.Location = new System.Drawing.Point(12, 9);
            this.titleAddPartLabel.Name = "titleAddPartLabel";
            this.titleAddPartLabel.Size = new System.Drawing.Size(79, 20);
            this.titleAddPartLabel.TabIndex = 1;
            this.titleAddPartLabel.Text = "Add Part";
            // 
            // partInHouseRadioBtn
            // 
            this.partInHouseRadioBtn.AutoSize = true;
            this.partInHouseRadioBtn.Location = new System.Drawing.Point(232, 5);
            this.partInHouseRadioBtn.Name = "partInHouseRadioBtn";
            this.partInHouseRadioBtn.Size = new System.Drawing.Size(100, 24);
            this.partInHouseRadioBtn.TabIndex = 2;
            this.partInHouseRadioBtn.TabStop = true;
            this.partInHouseRadioBtn.Text = "In-House";
            this.partInHouseRadioBtn.UseVisualStyleBackColor = true;
            this.partInHouseRadioBtn.CheckedChanged += new System.EventHandler(this.partInHouseRadioBtn_CheckedChanged);
            // 
            // partOutsourcedRadioBtn
            // 
            this.partOutsourcedRadioBtn.AutoSize = true;
            this.partOutsourcedRadioBtn.Location = new System.Drawing.Point(374, 5);
            this.partOutsourcedRadioBtn.Name = "partOutsourcedRadioBtn";
            this.partOutsourcedRadioBtn.Size = new System.Drawing.Size(117, 24);
            this.partOutsourcedRadioBtn.TabIndex = 2;
            this.partOutsourcedRadioBtn.TabStop = true;
            this.partOutsourcedRadioBtn.Text = "Outsourced";
            this.partOutsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.partOutsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.partOutsourcedRadioBtn_CheckedChanged);
            // 
            // addPartIDLabel
            // 
            this.addPartIDLabel.AutoSize = true;
            this.addPartIDLabel.Location = new System.Drawing.Point(185, 92);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(26, 20);
            this.addPartIDLabel.TabIndex = 4;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Location = new System.Drawing.Point(160, 141);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(51, 20);
            this.addPartNameLabel.TabIndex = 5;
            this.addPartNameLabel.Text = "Name";
            // 
            // addPartInventoryLabel
            // 
            this.addPartInventoryLabel.AutoSize = true;
            this.addPartInventoryLabel.Location = new System.Drawing.Point(137, 194);
            this.addPartInventoryLabel.Name = "addPartInventoryLabel";
            this.addPartInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.addPartInventoryLabel.TabIndex = 6;
            this.addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartPriceLabel
            // 
            this.addPartPriceLabel.AutoSize = true;
            this.addPartPriceLabel.Location = new System.Drawing.Point(122, 246);
            this.addPartPriceLabel.Name = "addPartPriceLabel";
            this.addPartPriceLabel.Size = new System.Drawing.Size(89, 20);
            this.addPartPriceLabel.TabIndex = 7;
            this.addPartPriceLabel.Text = "Price / Cost";
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Location = new System.Drawing.Point(173, 293);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.addPartMaxLabel.TabIndex = 8;
            this.addPartMaxLabel.Text = "Max";
            // 
            // addPartMachineIDLabel
            // 
            this.addPartMachineIDLabel.AutoSize = true;
            this.addPartMachineIDLabel.Location = new System.Drawing.Point(121, 345);
            this.addPartMachineIDLabel.Name = "addPartMachineIDLabel";
            this.addPartMachineIDLabel.Size = new System.Drawing.Size(90, 20);
            this.addPartMachineIDLabel.TabIndex = 9;
            this.addPartMachineIDLabel.Text = "Machine ID";
            // 
            // addPartIDTxtBox
            // 
            this.addPartIDTxtBox.Location = new System.Drawing.Point(253, 86);
            this.addPartIDTxtBox.Name = "addPartIDTxtBox";
            this.addPartIDTxtBox.Size = new System.Drawing.Size(141, 26);
            this.addPartIDTxtBox.TabIndex = 10;
            // 
            // addPartNameTxtBox
            // 
            this.addPartNameTxtBox.Location = new System.Drawing.Point(253, 141);
            this.addPartNameTxtBox.Name = "addPartNameTxtBox";
            this.addPartNameTxtBox.Size = new System.Drawing.Size(141, 26);
            this.addPartNameTxtBox.TabIndex = 11;
            // 
            // addPartInventoryTxtBox
            // 
            this.addPartInventoryTxtBox.Location = new System.Drawing.Point(253, 194);
            this.addPartInventoryTxtBox.Name = "addPartInventoryTxtBox";
            this.addPartInventoryTxtBox.Size = new System.Drawing.Size(141, 26);
            this.addPartInventoryTxtBox.TabIndex = 12;
            // 
            // addPartPriceTxtBox
            // 
            this.addPartPriceTxtBox.Location = new System.Drawing.Point(253, 246);
            this.addPartPriceTxtBox.Name = "addPartPriceTxtBox";
            this.addPartPriceTxtBox.Size = new System.Drawing.Size(141, 26);
            this.addPartPriceTxtBox.TabIndex = 13;
            // 
            // addPartMaxTxtBox
            // 
            this.addPartMaxTxtBox.Location = new System.Drawing.Point(253, 293);
            this.addPartMaxTxtBox.Name = "addPartMaxTxtBox";
            this.addPartMaxTxtBox.Size = new System.Drawing.Size(68, 26);
            this.addPartMaxTxtBox.TabIndex = 14;
            // 
            // addPartMachineIDTxtBox
            // 
            this.addPartMachineIDTxtBox.Location = new System.Drawing.Point(253, 345);
            this.addPartMachineIDTxtBox.Name = "addPartMachineIDTxtBox";
            this.addPartMachineIDTxtBox.Size = new System.Drawing.Size(141, 26);
            this.addPartMachineIDTxtBox.TabIndex = 15;
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Location = new System.Drawing.Point(383, 293);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(34, 20);
            this.addPartMinLabel.TabIndex = 16;
            this.addPartMinLabel.Text = "Min";
            this.addPartMinLabel.Click += new System.EventHandler(this.addPartMinLabel_Click);
            // 
            // addPartMinTxtBox
            // 
            this.addPartMinTxtBox.Location = new System.Drawing.Point(466, 293);
            this.addPartMinTxtBox.Name = "addPartMinTxtBox";
            this.addPartMinTxtBox.Size = new System.Drawing.Size(68, 26);
            this.addPartMinTxtBox.TabIndex = 17;
            // 
            // addPartCancelBtn
            // 
            this.addPartCancelBtn.Location = new System.Drawing.Point(582, 395);
            this.addPartCancelBtn.Name = "addPartCancelBtn";
            this.addPartCancelBtn.Size = new System.Drawing.Size(75, 43);
            this.addPartCancelBtn.TabIndex = 18;
            this.addPartCancelBtn.Text = "Cancel";
            this.addPartCancelBtn.UseVisualStyleBackColor = true;
            this.addPartCancelBtn.Click += new System.EventHandler(this.addPartCancelBtn_Click);
            // 
            // addPartSaveBtn
            // 
            this.addPartSaveBtn.Location = new System.Drawing.Point(491, 395);
            this.addPartSaveBtn.Name = "addPartSaveBtn";
            this.addPartSaveBtn.Size = new System.Drawing.Size(75, 43);
            this.addPartSaveBtn.TabIndex = 19;
            this.addPartSaveBtn.Text = "Save";
            this.addPartSaveBtn.UseVisualStyleBackColor = true;
            this.addPartSaveBtn.Click += new System.EventHandler(this.addPartSaveBtn_Click);
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(99, 20);
            this.modifyPartLabel.TabIndex = 20;
            this.modifyPartLabel.Text = "Modify Part";
            // 
            // addPartCompanyNameLabel
            // 
            this.addPartCompanyNameLabel.AutoSize = true;
            this.addPartCompanyNameLabel.Location = new System.Drawing.Point(89, 348);
            this.addPartCompanyNameLabel.Name = "addPartCompanyNameLabel";
            this.addPartCompanyNameLabel.Size = new System.Drawing.Size(122, 20);
            this.addPartCompanyNameLabel.TabIndex = 21;
            this.addPartCompanyNameLabel.Text = "Company Name";
            this.addPartCompanyNameLabel.Click += new System.EventHandler(this.addPartCompanyNameLabel_Click);
            // 
            // addPartCompanyNameTxtBox
            // 
            this.addPartCompanyNameTxtBox.Location = new System.Drawing.Point(253, 345);
            this.addPartCompanyNameTxtBox.Name = "addPartCompanyNameTxtBox";
            this.addPartCompanyNameTxtBox.Size = new System.Drawing.Size(141, 26);
            this.addPartCompanyNameTxtBox.TabIndex = 22;
            this.addPartCompanyNameTxtBox.TextChanged += new System.EventHandler(this.addPartCompanyNameTxtBox_TextChanged);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.addPartCompanyNameTxtBox);
            this.Controls.Add(this.addPartCompanyNameLabel);
            this.Controls.Add(this.modifyPartLabel);
            this.Controls.Add(this.addPartSaveBtn);
            this.Controls.Add(this.addPartCancelBtn);
            this.Controls.Add(this.addPartMinTxtBox);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartMachineIDTxtBox);
            this.Controls.Add(this.addPartMaxTxtBox);
            this.Controls.Add(this.addPartPriceTxtBox);
            this.Controls.Add(this.addPartInventoryTxtBox);
            this.Controls.Add(this.addPartNameTxtBox);
            this.Controls.Add(this.addPartIDTxtBox);
            this.Controls.Add(this.addPartMachineIDLabel);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.addPartPriceLabel);
            this.Controls.Add(this.addPartInventoryLabel);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.addPartIDLabel);
            this.Controls.Add(this.partOutsourcedRadioBtn);
            this.Controls.Add(this.partInHouseRadioBtn);
            this.Controls.Add(this.titleAddPartLabel);
            this.Name = "AddPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleAddPartLabel;
        private System.Windows.Forms.RadioButton partInHouseRadioBtn;
        private System.Windows.Forms.RadioButton partOutsourcedRadioBtn;
        private System.Windows.Forms.Label addPartIDLabel;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.Label addPartInventoryLabel;
        private System.Windows.Forms.Label addPartPriceLabel;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.Label addPartMachineIDLabel;
        private System.Windows.Forms.TextBox addPartIDTxtBox;
        private System.Windows.Forms.TextBox addPartNameTxtBox;
        private System.Windows.Forms.TextBox addPartInventoryTxtBox;
        private System.Windows.Forms.TextBox addPartPriceTxtBox;
        private System.Windows.Forms.TextBox addPartMaxTxtBox;
        private System.Windows.Forms.TextBox addPartMachineIDTxtBox;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.TextBox addPartMinTxtBox;
        private System.Windows.Forms.Button addPartCancelBtn;
        private System.Windows.Forms.Button addPartSaveBtn;
        private System.Windows.Forms.Label modifyPartLabel;
        private System.Windows.Forms.Label addPartCompanyNameLabel;
        private System.Windows.Forms.TextBox addPartCompanyNameTxtBox;
    }
}