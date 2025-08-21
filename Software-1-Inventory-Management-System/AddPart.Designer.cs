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
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleAddPartLabel);
            this.Name = "AddPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleAddPartLabel;
    }
}