using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
//using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopProject {
    public partial class ViewProducts : Form {
        public ViewProducts() {
            InitializeComponent();
            
            InitializeDataGrid();
            InitializeFilter();
        }

        #region Initialization of data grid
        protected void InitializeDataGrid() {
            //  数据源为 TblProduct，与该表具有直接联系的表(TblProType, TblTransItem)也将被包含在数据源中
            dataGrid_Viewer.DataSource = DBEntitiesInstance.Instance.TblProduct.ToList<TblProduct>();

            dataGrid_Viewer.AllowUserToOrderColumns = true; //  用户可自行调整属性列顺序
            GetCol_Name.DisplayIndex = 1;    //  商品名属性排第1位

            //  隐藏部分属性列
            HideColumnByName("ProductType");
            HideColumnByName("TblProType");
            HideColumnByName("TblTransItem");

            //  设置属性列名称
            GetCol_ID.HeaderText = "序号";
            GetCol_Name.HeaderText = "商品名";
            GetCol_Price.HeaderText = "价格";
            GetCol_Image.HeaderText = "图片";            
        }

        //  getters for columns
        public DataGridViewColumn GetCol_ID { get { return dataGrid_Viewer.Columns["ProductID"]; } }
        public DataGridViewColumn GetCol_Name { get { return dataGrid_Viewer.Columns["ProName"]; } }
        public DataGridViewColumn GetCol_Price { get { return dataGrid_Viewer.Columns["Price"]; } }
        public DataGridViewColumn GetCol_Image { get { return dataGrid_Viewer.Columns["Image"]; } }

        private void HideColumnByName(string colName) { 
            var col = dataGrid_Viewer.Columns[colName];
            if (col != null)
                col.Visible = false;
        }
        #endregion

        #region Initialization of filter combobox
        protected void InitializeFilter() {
            var filterTable = new DataTable();
            var recordList = DBEntitiesInstance.Instance.TblProType.ToList<TblProType>();

            #region custmize the data source of cbox_Filter
            //  in case there's no way to add items to combobox after binding it to a data source
            //  so you have to custmize a new table to add item "ALL", which doesn't exist in the database

            filterTable.Columns.Add("ProductType");
            filterTable.Columns.Add("Description");

            //  add a record "ALL" to display all the products
            filterTable.Rows.Add(4, "ALL");

            //  copy those records from TblProType to the custom table
            for (int i = 0; i < recordList.Count; i++) {
                filterTable.Rows.Add(recordList[i].ProductType, recordList[i].Description);
            }

            cbox_Filter.DataSource = filterTable;
            cbox_Filter.DisplayMember = "Description";
            cbox_Filter.ValueMember = "ProductType";
            #endregion

            cbox_Filter.SelectedIndexChanged += FilteringByProductType;
        }

        void FilteringByProductType(object sender, EventArgs e) {
            int proTypeVal = int.Parse((string)cbox_Filter.SelectedValue);
            var allFlag = proTypeVal >= cbox_Filter.Items.Count;

            ObjectQuery<TblProduct> filteredProducts = new ObjectQuery<TblProduct> 
            (
                allFlag ? "SELECT VALUE product FROM TblProduct AS product" : 
                "SELECT VALUE product FROM TblProduct AS product WHERE product.ProductType = " + proTypeVal,
                ((IObjectContextAdapter)DBEntitiesInstance.Instance).ObjectContext
            );

            dataGrid_Viewer.DataSource = filteredProducts;
        }
        #endregion

        private void ViewProducts_Load(object sender, EventArgs e) {
            // TODO:  这行代码将数据加载到表“coffeeShopDBDataSet.TblProType”中。您可以根据需要移动或删除它。
            this.tblProTypeTableAdapter.Fill(this.coffeeShopDBDataSet.TblProType);
        }
    }
}
