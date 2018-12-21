namespace CoffeeShopProject {
    partial class ViewProducts {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducts));
            this.dataGrid_Viewer = new System.Windows.Forms.DataGridView();
            this.cbox_Filter = new System.Windows.Forms.ComboBox();
            this.coffeeShopDBDataSet = new CoffeeShopProject.CoffeeShopDBDataSet();
            this.coffeeShopDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProTypeTableAdapter = new CoffeeShopProject.CoffeeShopDBDataSetTableAdapters.TblProTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Viewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Viewer
            // 
            this.dataGrid_Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Viewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_Viewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Viewer.Location = new System.Drawing.Point(13, 13);
            this.dataGrid_Viewer.Name = "dataGrid_Viewer";
            this.dataGrid_Viewer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid_Viewer.RowTemplate.Height = 23;
            this.dataGrid_Viewer.Size = new System.Drawing.Size(538, 355);
            this.dataGrid_Viewer.TabIndex = 0;
            // 
            // cbox_Filter
            // 
            this.cbox_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbox_Filter.FormattingEnabled = true;
            this.cbox_Filter.Location = new System.Drawing.Point(13, 392);
            this.cbox_Filter.Name = "cbox_Filter";
            this.cbox_Filter.Size = new System.Drawing.Size(201, 20);
            this.cbox_Filter.TabIndex = 1;
            // 
            // coffeeShopDBDataSet
            // 
            this.coffeeShopDBDataSet.DataSetName = "CoffeeShopDBDataSet";
            this.coffeeShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeeShopDBDataSetBindingSource
            // 
            this.coffeeShopDBDataSetBindingSource.DataSource = this.coffeeShopDBDataSet;
            this.coffeeShopDBDataSetBindingSource.Position = 0;
            // 
            // tblProTypeBindingSource
            // 
            this.tblProTypeBindingSource.DataMember = "TblProType";
            this.tblProTypeBindingSource.DataSource = this.coffeeShopDBDataSetBindingSource;
            // 
            // tblProTypeTableAdapter
            // 
            this.tblProTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 445);
            this.Controls.Add(this.cbox_Filter);
            this.Controls.Add(this.dataGrid_Viewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProducts";
            this.Text = "View Products";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Viewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Viewer;
        private System.Windows.Forms.ComboBox cbox_Filter;
        private System.Windows.Forms.BindingSource coffeeShopDBDataSetBindingSource;
        private CoffeeShopDBDataSet coffeeShopDBDataSet;
        private System.Windows.Forms.BindingSource tblProTypeBindingSource;
        private CoffeeShopDBDataSetTableAdapters.TblProTypeTableAdapter tblProTypeTableAdapter;
    }
}