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
            this.partsDateGridView = new System.Windows.Forms.DataGridView();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.partsDataGridViewLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partsSearchTxtBox = new System.Windows.Forms.TextBox();
            this.productsSearchTxtBox = new System.Windows.Forms.TextBox();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.productsSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDateGridView)).BeginInit();
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
            // partsDateGridView
            // 
            this.partsDateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDateGridView.Location = new System.Drawing.Point(10, 170);
            this.partsDateGridView.Name = "partsDateGridView";
            this.partsDateGridView.RowHeadersWidth = 62;
            this.partsDateGridView.RowTemplate.Height = 28;
            this.partsDateGridView.Size = new System.Drawing.Size(567, 181);
            this.partsDateGridView.TabIndex = 1;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(627, 170);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 62;
            this.productsDataGridView.RowTemplate.Height = 28;
            this.productsDataGridView.Size = new System.Drawing.Size(543, 181);
            this.productsDataGridView.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(627, 143);
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
            // 
            // productsSearchTxtBox
            // 
            this.productsSearchTxtBox.Location = new System.Drawing.Point(1007, 134);
            this.productsSearchTxtBox.Name = "productsSearchTxtBox";
            this.productsSearchTxtBox.Size = new System.Drawing.Size(163, 26);
            this.productsSearchTxtBox.TabIndex = 6;
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.Location = new System.Drawing.Point(308, 126);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(89, 36);
            this.partsSearchBtn.TabIndex = 7;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            // 
            // productsSearchBtn
            // 
            this.productsSearchBtn.Location = new System.Drawing.Point(903, 127);
            this.productsSearchBtn.Name = "productsSearchBtn";
            this.productsSearchBtn.Size = new System.Drawing.Size(89, 36);
            this.productsSearchBtn.TabIndex = 8;
            this.productsSearchBtn.Text = "Search";
            this.productsSearchBtn.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 523);
            this.Controls.Add(this.productsSearchBtn);
            this.Controls.Add(this.partsSearchBtn);
            this.Controls.Add(this.productsSearchTxtBox);
            this.Controls.Add(this.partsSearchTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partsDataGridViewLabel);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.partsDateGridView);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partsDateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView partsDateGridView;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Label partsDataGridViewLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partsSearchTxtBox;
        private System.Windows.Forms.TextBox productsSearchTxtBox;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.Button productsSearchBtn;
    }
}

