using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeShopProject {
    public partial class CoffeShopPOS : Form {
        private CoffeeShopDBEntities cse = DBEntitiesInstance.Instance;
        private BindingList<OrderedProductItemInfo> bindingList = new BindingList<OrderedProductItemInfo>();
        private Dictionary<TblProduct, int> orderedItem_Name_Amount = new Dictionary<TblProduct, int>();
        private float totalPrice = 0f;

        //  Action: delegate with void return type, no paras.
        //  Action<T>, Action<T1, T2>, and so on: delegate with void return type, custom paras.
        public static event Action<float> OpenPaymentPanelEvent;

        public enum OperateType {
            OrderProduct, DelProduct, RESET
        }

        //  the struct of the item info in listbox
        public struct OrderedProductItemInfo {
            public TblProduct productRecord;
            public int itemCount;

            public OrderedProductItemInfo(TblProduct productRecord, int itemCount) {
                this.productRecord = productRecord;
                this.itemCount = itemCount;
            }
        }
        public CoffeShopPOS() {
            InitializeComponent();

            PaymentPanel.TransactionCompleteEvent += OnTransCompleted;

            InitializeListBox();
            InitializeTabPanel();
        }

        public float TotalPrice {
            get { return totalPrice; }
        }

        private void OnTransCompleted(bool isCompleted) {
            if (!isCompleted)
                return;

            //  reset the total price to 0
            UpdateTotalPrice(OperateType.RESET, 0);

            //  new transaction record for TblTransaction
            var transRecord = new TblTransaction();
            transRecord.TransID = DBQueryHelper.GenerateTransID();
            transRecord.TransDate = DateTime.Now;   //  assign TblTransaction.TransDate

            #region DB query during the connection is opened
            DBQueryHelper.OpenConnection();

            //  insert data into TblTransaction BEFORE TblTransItem
            DBQueryHelper.Insert_TblTransaction(transRecord);

            //  insert values into TblTransItem
            foreach (var orderedItemInfo in bindingList) {
                var product = orderedItemInfo.productRecord;
                
                var transItem = new TblTransItem() { 
                    TransID = transRecord.TransID, 
                    ProductID = product.ProductID, 
                    ProductCount = (short)orderedItemInfo.itemCount
                };

                DBQueryHelper.Insert_TblTransItem(transItem);
            }
            DBQueryHelper.CloseConnection();
            #endregion

            //  clear all the ordered items in listbox
            bindingList.Clear();
        }

        #region Initialization of listbox that displays the chosen product items
        private void InitializeListBox() {
            lbox_ChosenProducts.DataSource = bindingList;
            lbox_ChosenProducts.DisplayMember = "ProName";
            lbox_ChosenProducts.Format += FormatListItem;
        }
        #endregion

        #region Initialization of tabcontrol
        private void InitializeTabPanel() {
            //  use this dictionary for value-to-key mapping for the convinience of "get the key by value"
            var val2keyDic = new Dictionary<string, string>();
            
            //  create tabs based on the product types            
            foreach(var pt in cse.TblProType){
                tabCon_MenuPanel.TabPages.Add(pt.ProductType.ToString(), pt.Description);   //  Add(key, value)
                val2keyDic.Add(pt.Description, pt.ProductType.ToString()); //  Add(value, key)
            }

            //  add products to panel based on the tab
            for (int i = 0; i < tabCon_MenuPanel.TabPages.Count; i++) {
                var curTab = tabCon_MenuPanel.TabPages[i];
                var tabPageKey = val2keyDic[curTab.Text];

                var filteredProducts = new ObjectQuery<TblProduct> (
                    "SELECT VALUE product FROM TblProduct AS product WHERE product.ProductType = " + tabPageKey, 
                    ((IObjectContextAdapter)cse).ObjectContext
                );

                curTab.Controls.Add(LayoutBeenAddedToTab(filteredProducts));
            }
        }

        //  return the layout which contains specified products, that been added to the current tab
        private FlowLayoutPanel LayoutBeenAddedToTab(ObjectQuery<TblProduct> filteredProducts) {
            var layoutPan = new FlowLayoutPanel();
            layoutPan.Dock = DockStyle.Fill;    //  the layout will fill the parent containter, which is the current tab

            foreach (var product in filteredProducts) {
                var interactable = new Button();
                interactable.Size = new System.Drawing.Size(100, 60);
                interactable.Text = product.ProName;
                interactable.Tag = product;
                interactable.Click += OnClick_OrderProduct;

                layoutPan.Controls.Add(interactable);
            }

            return layoutPan;
        }
        #endregion

        #region callback on order and delete products
        private void OnClick_OrderProduct(object sender, EventArgs e) {
            var btn = (Button)sender;
            var productItem = (TblProduct)btn.Tag;

            //  what kind of product and how much of it has been selected so far
            if (orderedItem_Name_Amount.ContainsKey(productItem)) {
                //  count++ for the item which has been selected before
                int currentCount = orderedItem_Name_Amount[productItem]++;

                //  find the element whose count needs to be updated from the bindingList based on index
                int index = FindIndexOfBindingListItem(productItem);

                //  index == -1 means such element does not exist in the bindingList
                if (index != -1) {
                    //  update the element
                    bindingList[index] = new OrderedProductItemInfo(productItem, orderedItem_Name_Amount[productItem]);
                }
            } else {
                orderedItem_Name_Amount.Add(productItem, 1);
                bindingList.Add(new OrderedProductItemInfo(productItem, 1));
            }

            UpdateTotalPrice(OperateType.OrderProduct, (float)productItem.Price);

            //  make the selected one always be the newest item
            lbox_ChosenProducts.SelectedIndex = lbox_ChosenProducts.Items.Count - 1;

            //  display the current product been chosen in the text box
            UpdateCurProductInfo(productItem);
        }

        private void OnClick_DecreaseAmount(object sender, EventArgs e) {
            if (bindingList.Count <= 0)
                return;
            var selectedItemInfo = (OrderedProductItemInfo)lbox_ChosenProducts.SelectedItem;
            var proRecord = selectedItemInfo.productRecord;
            int index = FindIndexOfBindingListItem(proRecord);
            
            //  if the item's current amount is less or euqal than 1, remove it out of the bindList
            if (selectedItemInfo.itemCount <= 1) {
                if (orderedItem_Name_Amount.ContainsKey(proRecord)) {
                    orderedItem_Name_Amount.Remove(proRecord);
                }
                if (index != -1) {
                    bindingList.Remove(selectedItemInfo);
                    UpdateTotalPrice(OperateType.DelProduct, (float)proRecord.Price);
                }
            } 
            //  if the amount is more than 1, decrease it by 1
            else {
                if (orderedItem_Name_Amount.ContainsKey(proRecord)) {
                    orderedItem_Name_Amount[proRecord]--;
                }
                if (index != -1) {
                    bindingList[index] = new OrderedProductItemInfo(proRecord, orderedItem_Name_Amount[proRecord]);
                    UpdateTotalPrice(OperateType.DelProduct, (float)proRecord.Price);
                }
            }
        }

        private void OnClick_IncreaseAmount(object sender, EventArgs e) {
            var selectedItemInfo = (OrderedProductItemInfo)lbox_ChosenProducts.SelectedItem;
            var proRecord = selectedItemInfo.productRecord;
            int index = lbox_ChosenProducts.SelectedIndex;

            if (orderedItem_Name_Amount.ContainsKey(proRecord)) {
                orderedItem_Name_Amount[proRecord]++;
            }

            if (index != -1) {
                bindingList[index] = new OrderedProductItemInfo(proRecord, orderedItem_Name_Amount[proRecord]);
                UpdateTotalPrice(OperateType.OrderProduct, (float)proRecord.Price);
            }
        }

        #endregion

        //  update the total price of all selected products
        private void UpdateTotalPrice(OperateType operType, float diff) {
            if (operType == OperateType.OrderProduct) {
                totalPrice += diff;
            } else if (operType == OperateType.DelProduct) {
                totalPrice = totalPrice <= 0 ? 0 : totalPrice - diff;
            } else if (operType == OperateType.RESET) {
                totalPrice = 0;
            }

            var hintStr = "Total: ";
            tbox_TotalPrice.Text = hintStr.PadRight(10) + string.Format("{0:c}", totalPrice);
        }

        private void UpdateCurProductInfo(TblProduct curProduct) {
            var proName = curProduct.ProName;
            var price = String.Format("{0:c}", curProduct.Price); //  c: currency format
            var formattedStr = proName.PadRight(20) + price;

            tbox_CurProduct.Text = formattedStr;
        }

        private int FindIndexOfBindingListItem(TblProduct product) {
            for (int i = 0; i < bindingList.Count; i++) {
                if (product.ProductID == bindingList[i].productRecord.ProductID) {
                    return i;
                } else {
                    continue;
                }
            }
            return -1;
        }

        void FormatListItem(object sender, ListControlConvertEventArgs e) {
            var orderedItemInfo = (OrderedProductItemInfo)e.ListItem;

            var proName = orderedItemInfo.productRecord.ProName;
            var price = string.Format("{0:c}", orderedItemInfo.productRecord.Price); //  c: currency format
            var count = string.Format("x {0}", orderedItemInfo.itemCount);

            var formattedStr = proName.PadRight(10) + price.PadRight(10) + count;
            e.Value = formattedStr;
        }

        protected new void OnClosed(EventArgs e) {
            lbox_ChosenProducts.Format -= FormatListItem;
        }

        private void btn_OpenPaymentPanel_Click(object sender, EventArgs e) {
            var paymentPanel = new PaymentPanel();
            paymentPanel.Show();
            OpenPaymentPanelEvent(TotalPrice);
        }

    }
}
