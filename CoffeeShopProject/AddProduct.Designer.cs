namespace CoffeeShopProject {
    partial class AddProduct {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.lab_ProName = new System.Windows.Forms.Label();
            this.tbox_ProName = new System.Windows.Forms.TextBox();
            this.tbox_ProPrice = new System.Windows.Forms.TextBox();
            this.lab_ProPrice = new System.Windows.Forms.Label();
            this.lab_ProType = new System.Windows.Forms.Label();
            this.cbox_ProType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_ProImg = new System.Windows.Forms.Label();
            this.btn_ChooseProImg = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbox_ProImg = new System.Windows.Forms.PictureBox();
            this.btn_AddProSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ProImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_ProName
            // 
            this.lab_ProName.AutoSize = true;
            this.lab_ProName.Location = new System.Drawing.Point(39, 15);
            this.lab_ProName.Name = "lab_ProName";
            this.lab_ProName.Size = new System.Drawing.Size(29, 12);
            this.lab_ProName.TabIndex = 0;
            this.lab_ProName.Text = "Name";
            // 
            // tbox_ProName
            // 
            this.tbox_ProName.Location = new System.Drawing.Point(115, 12);
            this.tbox_ProName.Name = "tbox_ProName";
            this.tbox_ProName.Size = new System.Drawing.Size(100, 21);
            this.tbox_ProName.TabIndex = 1;
            // 
            // tbox_ProPrice
            // 
            this.tbox_ProPrice.Location = new System.Drawing.Point(115, 55);
            this.tbox_ProPrice.Name = "tbox_ProPrice";
            this.tbox_ProPrice.Size = new System.Drawing.Size(100, 21);
            this.tbox_ProPrice.TabIndex = 3;
            // 
            // lab_ProPrice
            // 
            this.lab_ProPrice.AutoSize = true;
            this.lab_ProPrice.Location = new System.Drawing.Point(39, 58);
            this.lab_ProPrice.Name = "lab_ProPrice";
            this.lab_ProPrice.Size = new System.Drawing.Size(35, 12);
            this.lab_ProPrice.TabIndex = 2;
            this.lab_ProPrice.Text = "Price";
            // 
            // lab_ProType
            // 
            this.lab_ProType.AutoSize = true;
            this.lab_ProType.Location = new System.Drawing.Point(39, 102);
            this.lab_ProType.Name = "lab_ProType";
            this.lab_ProType.Size = new System.Drawing.Size(53, 12);
            this.lab_ProType.TabIndex = 4;
            this.lab_ProType.Text = "Category";
            // 
            // cbox_ProType
            // 
            this.cbox_ProType.FormattingEnabled = true;
            this.cbox_ProType.Location = new System.Drawing.Point(115, 99);
            this.cbox_ProType.Name = "cbox_ProType";
            this.cbox_ProType.Size = new System.Drawing.Size(121, 20);
            this.cbox_ProType.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbox_ProType);
            this.panel1.Controls.Add(this.lab_ProName);
            this.panel1.Controls.Add(this.lab_ProType);
            this.panel1.Controls.Add(this.tbox_ProName);
            this.panel1.Controls.Add(this.tbox_ProPrice);
            this.panel1.Controls.Add(this.lab_ProPrice);
            this.panel1.Location = new System.Drawing.Point(34, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 143);
            this.panel1.TabIndex = 6;
            // 
            // lab_ProImg
            // 
            this.lab_ProImg.AutoSize = true;
            this.lab_ProImg.Location = new System.Drawing.Point(26, 55);
            this.lab_ProImg.Name = "lab_ProImg";
            this.lab_ProImg.Size = new System.Drawing.Size(35, 12);
            this.lab_ProImg.TabIndex = 7;
            this.lab_ProImg.Text = "Image";
            // 
            // btn_ChooseProImg
            // 
            this.btn_ChooseProImg.Location = new System.Drawing.Point(67, 50);
            this.btn_ChooseProImg.Name = "btn_ChooseProImg";
            this.btn_ChooseProImg.Size = new System.Drawing.Size(36, 23);
            this.btn_ChooseProImg.TabIndex = 8;
            this.btn_ChooseProImg.Text = "...";
            this.btn_ChooseProImg.UseVisualStyleBackColor = true;
            this.btn_ChooseProImg.Click += new System.EventHandler(this.btn_ChooseProImg_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbox_ProImg);
            this.panel2.Controls.Add(this.lab_ProImg);
            this.panel2.Controls.Add(this.btn_ChooseProImg);
            this.panel2.Location = new System.Drawing.Point(34, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 131);
            this.panel2.TabIndex = 9;
            // 
            // pbox_ProImg
            // 
            this.pbox_ProImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbox_ProImg.ErrorImage")));
            this.pbox_ProImg.Image = ((System.Drawing.Image)(resources.GetObject("pbox_ProImg.Image")));
            this.pbox_ProImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_ProImg.InitialImage")));
            this.pbox_ProImg.Location = new System.Drawing.Point(115, 13);
            this.pbox_ProImg.Name = "pbox_ProImg";
            this.pbox_ProImg.Size = new System.Drawing.Size(121, 115);
            this.pbox_ProImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ProImg.TabIndex = 9;
            this.pbox_ProImg.TabStop = false;
            // 
            // btn_AddProSave
            // 
            this.btn_AddProSave.Location = new System.Drawing.Point(125, 336);
            this.btn_AddProSave.Name = "btn_AddProSave";
            this.btn_AddProSave.Size = new System.Drawing.Size(90, 42);
            this.btn_AddProSave.TabIndex = 10;
            this.btn_AddProSave.Text = "Save";
            this.btn_AddProSave.UseVisualStyleBackColor = true;
            this.btn_AddProSave.Click += new System.EventHandler(this.btn_AddProSave_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 402);
            this.Controls.Add(this.btn_AddProSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ProImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_ProName;
        private System.Windows.Forms.TextBox tbox_ProName;
        private System.Windows.Forms.TextBox tbox_ProPrice;
        private System.Windows.Forms.Label lab_ProPrice;
        private System.Windows.Forms.Label lab_ProType;
        private System.Windows.Forms.ComboBox cbox_ProType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_ProImg;
        private System.Windows.Forms.Button btn_ChooseProImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbox_ProImg;
        private System.Windows.Forms.Button btn_AddProSave;

    }
}