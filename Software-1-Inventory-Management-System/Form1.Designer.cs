namespace Software_1_Inventory_Management_System
{
    partial class MainScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.partsDataGridViewLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partsSearchTxtBox = new System.Windows.Forms.TextBox();
            this.productsSearchTxtBox = new System.Windows.Forms.TextBox();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.productsSearchBtn = new System.Windows.Forms.Button();
            this.partsAddBtn = new System.Windows.Forms.Button();
            this.partsModifyBtn = new System.Windows.Forms.Button();
            this.partsDeleteBtn = new System.Windows.Forms.Button();
            this.productsAddBtn = new System.Windows.Forms.Button();
            this.productsModifyBtn = new System.Windows.Forms.Button();
            this.productsDeleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(256, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Inventory Management System";
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(10, 170);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowHeadersWidth = 62;
            this.partsDataGridView.RowTemplate.Height = 28;
            this.partsDataGridView.Size = new System.Drawing.Size(567, 244);
            this.partsDataGridView.TabIndex = 1;
            this.partsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsDataGridView_CellContentClick);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(601, 170);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 62;
            this.productsDataGridView.RowTemplate.Height = 28;
            this.productsDataGridView.Size = new System.Drawing.Size(569, 244);
            this.productsDataGridView.TabIndex = 2;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // partsDataGridViewLabel
            // 
            this.partsDataGridViewLabel.AutoSize = true;
            this.partsDataGridViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsDataGridViewLabel.Location = new System.Drawing.Point(10, 144);
            this.partsDataGridViewLabel.Name = "partsDataGridViewLabel";
            this.partsDataGridViewLabel.Size = new System.Drawing.Size(51, 20);
            this.partsDataGridViewLabel.TabIndex = 3;
            this.partsDataGridViewLabel.Text = "Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // partsSearchTxtBox
            // 
            this.partsSearchTxtBox.Location = new System.Drawing.Point(413, 133);
            this.partsSearchTxtBox.Name = "partsSearchTxtBox";
            this.partsSearchTxtBox.Size = new System.Drawing.Size(163, 26);
            this.partsSearchTxtBox.TabIndex = 5;
            this.partsSearchTxtBox.TextChanged += new System.EventHandler(this.partsSearchTxtBox_TextChanged);
            // 
            // productsSearchTxtBox
            // 
            this.productsSearchTxtBox.Location = new System.Drawing.Point(1007, 134);
            this.productsSearchTxtBox.Name = "productsSearchTxtBox";
            this.productsSearchTxtBox.Size = new System.Drawing.Size(163, 26);
            this.productsSearchTxtBox.TabIndex = 6;
            this.productsSearchTxtBox.TextChanged += new System.EventHandler(this.productsSearchTxtBox_TextChanged);
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.Location = new System.Drawing.Point(308, 126);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(89, 36);
            this.partsSearchBtn.TabIndex = 7;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            this.partsSearchBtn.Click += new System.EventHandler(this.partsSearchBtn_Click);
            // 
            // productsSearchBtn
            // 
            this.productsSearchBtn.Location = new System.Drawing.Point(903, 127);
            this.productsSearchBtn.Name = "productsSearchBtn";
            this.productsSearchBtn.Size = new System.Drawing.Size(89, 36);
            this.productsSearchBtn.TabIndex = 8;
            this.productsSearchBtn.Text = "Search";
            this.productsSearchBtn.UseVisualStyleBackColor = true;
            this.productsSearchBtn.Click += new System.EventHandler(this.productsSearchBtn_Click);
            // 
            // partsAddBtn
            // 
            this.partsAddBtn.Location = new System.Drawing.Point(261, 420);
            this.partsAddBtn.Name = "partsAddBtn";
            this.partsAddBtn.Size = new System.Drawing.Size(89, 35);
            this.partsAddBtn.TabIndex = 9;
            this.partsAddBtn.Text = "Add";
            this.partsAddBtn.UseVisualStyleBackColor = true;
            this.partsAddBtn.Click += new System.EventHandler(this.partsAddBtn_Click);
            // 
            // partsModifyBtn
            // 
            this.partsModifyBtn.Location = new System.Drawing.Point(375, 420);
            this.partsModifyBtn.Name = "partsModifyBtn";
            this.partsModifyBtn.Size = new System.Drawing.Size(89, 35);
            this.partsModifyBtn.TabIndex = 10;
            this.partsModifyBtn.Text = "Modify";
            this.partsModifyBtn.UseVisualStyleBackColor = true;
            this.partsModifyBtn.Click += new System.EventHandler(this.partsModifyBtn_Click);
            // 
            // partsDeleteBtn
            // 
            this.partsDeleteBtn.Location = new System.Drawing.Point(488, 420);
            this.partsDeleteBtn.Name = "partsDeleteBtn";
            this.partsDeleteBtn.Size = new System.Drawing.Size(89, 35);
            this.partsDeleteBtn.TabIndex = 11;
            this.partsDeleteBtn.Text = "Delete";
            this.partsDeleteBtn.UseVisualStyleBackColor = true;
            this.partsDeleteBtn.Click += new System.EventHandler(this.partsDeleteBtn_Click);
            // 
            // productsAddBtn
            // 
            this.productsAddBtn.Location = new System.Drawing.Point(848, 420);
            this.productsAddBtn.Name = "productsAddBtn";
            this.productsAddBtn.Size = new System.Drawing.Size(89, 35);
            this.productsAddBtn.TabIndex = 12;
            this.productsAddBtn.Text = "Add";
            this.productsAddBtn.UseVisualStyleBackColor = true;
            // 
            // productsModifyBtn
            // 
            this.productsModifyBtn.Location = new System.Drawing.Point(968, 420);
            this.productsModifyBtn.Name = "productsModifyBtn";
            this.productsModifyBtn.Size = new System.Drawing.Size(89, 35);
            this.productsModifyBtn.TabIndex = 13;
            this.productsModifyBtn.Text = "Modify";
            this.productsModifyBtn.UseVisualStyleBackColor = true;
            this.productsModifyBtn.Click += new System.EventHandler(this.productsModifyBtn_Click);
            // 
            // productsDeleteBtn
            // 
            this.productsDeleteBtn.Location = new System.Drawing.Point(1081, 420);
            this.productsDeleteBtn.Name = "productsDeleteBtn";
            this.productsDeleteBtn.Size = new System.Drawing.Size(89, 35);
            this.productsDeleteBtn.TabIndex = 14;
            this.productsDeleteBtn.Text = "Delete";
            this.productsDeleteBtn.UseVisualStyleBackColor = true;
            this.productsDeleteBtn.Click += new System.EventHandler(this.productsDeleteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1071, 471);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(99, 40);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 523);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.productsDeleteBtn);
            this.Controls.Add(this.productsModifyBtn);
            this.Controls.Add(this.productsAddBtn);
            this.Controls.Add(this.partsDeleteBtn);
            this.Controls.Add(this.partsModifyBtn);
            this.Controls.Add(this.partsAddBtn);
            this.Controls.Add(this.productsSearchBtn);
            this.Controls.Add(this.partsSearchBtn);
            this.Controls.Add(this.productsSearchTxtBox);
            this.Controls.Add(this.partsSearchTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partsDataGridViewLabel);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Label partsDataGridViewLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partsSearchTxtBox;
        private System.Windows.Forms.TextBox productsSearchTxtBox;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.Button productsSearchBtn;
        private System.Windows.Forms.Button partsAddBtn;
        private System.Windows.Forms.Button partsModifyBtn;
        private System.Windows.Forms.Button partsDeleteBtn;
        private System.Windows.Forms.Button productsAddBtn;
        private System.Windows.Forms.Button productsModifyBtn;
        private System.Windows.Forms.Button productsDeleteBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

