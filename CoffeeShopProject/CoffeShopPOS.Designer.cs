namespace CoffeeShopProject {
    partial class CoffeShopPOS {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbox_ChosenProducts = new System.Windows.Forms.ListBox();
            this.btn_DecreaseAmount = new System.Windows.Forms.Button();
            this.tabCon_MenuPanel = new System.Windows.Forms.TabControl();
            this.tbox_CurProduct = new System.Windows.Forms.TextBox();
            this.tbox_TotalPrice = new System.Windows.Forms.TextBox();
            this.btn_OpenPaymentPanel = new System.Windows.Forms.Button();
            this.btn_IncreaseAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_ChosenProducts
            // 
            this.lbox_ChosenProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_ChosenProducts.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_ChosenProducts.FormattingEnabled = true;
            this.lbox_ChosenProducts.ItemHeight = 16;
            this.lbox_ChosenProducts.Location = new System.Drawing.Point(584, 13);
            this.lbox_ChosenProducts.Name = "lbox_ChosenProducts";
            this.lbox_ChosenProducts.Size = new System.Drawing.Size(332, 436);
            this.lbox_ChosenProducts.TabIndex = 0;
            // 
            // btn_DecreaseAmount
            // 
            this.btn_DecreaseAmount.Location = new System.Drawing.Point(762, 458);
            this.btn_DecreaseAmount.Name = "btn_DecreaseAmount";
            this.btn_DecreaseAmount.Size = new System.Drawing.Size(73, 36);
            this.btn_DecreaseAmount.TabIndex = 1;
            this.btn_DecreaseAmount.Text = "Delete";
            this.btn_DecreaseAmount.UseVisualStyleBackColor = true;
            this.btn_DecreaseAmount.Click += new System.EventHandler(this.OnClick_DecreaseAmount);
            // 
            // tabCon_MenuPanel
            // 
            this.tabCon_MenuPanel.Location = new System.Drawing.Point(24, 68);
            this.tabCon_MenuPanel.Name = "tabCon_MenuPanel";
            this.tabCon_MenuPanel.SelectedIndex = 0;
            this.tabCon_MenuPanel.Size = new System.Drawing.Size(517, 381);
            this.tabCon_MenuPanel.TabIndex = 2;
            // 
            // tbox_CurProduct
            // 
            this.tbox_CurProduct.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_CurProduct.Location = new System.Drawing.Point(24, 13);
            this.tbox_CurProduct.Name = "tbox_CurProduct";
            this.tbox_CurProduct.Size = new System.Drawing.Size(517, 41);
            this.tbox_CurProduct.TabIndex = 3;
            this.tbox_CurProduct.Text = "CurProduct";
            // 
            // tbox_TotalPrice
            // 
            this.tbox_TotalPrice.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbox_TotalPrice.Location = new System.Drawing.Point(584, 500);
            this.tbox_TotalPrice.Name = "tbox_TotalPrice";
            this.tbox_TotalPrice.ReadOnly = true;
            this.tbox_TotalPrice.Size = new System.Drawing.Size(332, 54);
            this.tbox_TotalPrice.TabIndex = 4;
            this.tbox_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_OpenPaymentPanel
            // 
            this.btn_OpenPaymentPanel.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenPaymentPanel.Location = new System.Drawing.Point(143, 458);
            this.btn_OpenPaymentPanel.Name = "btn_OpenPaymentPanel";
            this.btn_OpenPaymentPanel.Size = new System.Drawing.Size(206, 96);
            this.btn_OpenPaymentPanel.TabIndex = 5;
            this.btn_OpenPaymentPanel.Text = "PAY";
            this.btn_OpenPaymentPanel.UseVisualStyleBackColor = true;
            this.btn_OpenPaymentPanel.Click += new System.EventHandler(this.btn_OpenPaymentPanel_Click);
            // 
            // btn_IncreaseAmount
            // 
            this.btn_IncreaseAmount.Location = new System.Drawing.Point(658, 458);
            this.btn_IncreaseAmount.Name = "btn_IncreaseAmount";
            this.btn_IncreaseAmount.Size = new System.Drawing.Size(73, 36);
            this.btn_IncreaseAmount.TabIndex = 6;
            this.btn_IncreaseAmount.Text = "ADD";
            this.btn_IncreaseAmount.UseVisualStyleBackColor = true;
            this.btn_IncreaseAmount.Click += new System.EventHandler(this.OnClick_IncreaseAmount);
            // 
            // CoffeShopPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 604);
            this.Controls.Add(this.btn_IncreaseAmount);
            this.Controls.Add(this.btn_OpenPaymentPanel);
            this.Controls.Add(this.tbox_TotalPrice);
            this.Controls.Add(this.tbox_CurProduct);
            this.Controls.Add(this.tabCon_MenuPanel);
            this.Controls.Add(this.btn_DecreaseAmount);
            this.Controls.Add(this.lbox_ChosenProducts);
            this.Name = "CoffeShopPOS";
            this.Text = "CoffeShopPOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_ChosenProducts;
        private System.Windows.Forms.Button btn_DecreaseAmount;
        private System.Windows.Forms.TabControl tabCon_MenuPanel;
        private System.Windows.Forms.TextBox tbox_CurProduct;
        private System.Windows.Forms.TextBox tbox_TotalPrice;
        private System.Windows.Forms.Button btn_OpenPaymentPanel;
        private System.Windows.Forms.Button btn_IncreaseAmount;
    }
}