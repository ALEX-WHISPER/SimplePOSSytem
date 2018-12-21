using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopProject {
    public partial class PaymentPanel : Form {
        private float amount_TotalPrice;    //  总计
        private float amount_ToBePaid;      //  待支付
        private float amount_Paid;          //  已支付
        private float amount_Change;        //  找零

        public static event Action<bool> TransactionCompleteEvent;

        #region Properties
        public float Amount_TotalPrice { 
            get { return amount_TotalPrice; }
            set {
                amount_TotalPrice = value;
                tbox_TotalPrice.Text = string.Format("{0:c}", amount_TotalPrice);
            }
        }
        public float Amount_ToBePaid {
            get { return amount_ToBePaid; }
            set { 
                amount_ToBePaid = value;
                tbox_ToBePaid.Text = string.Format("{0:c}", amount_ToBePaid);
            }
        }

        public float Amount_Paid {
            get { return amount_Paid; }
            set {
                amount_Paid = value;
                tbox_Paid.Text = string.Format("{0:c}", amount_Paid); 
            }
        }

        public float Amount_Paying {
            get { return float.Parse(tbox_Paying.Text); }
            set { tbox_Paying.Text = value.ToString(); }
        }

        public float Amount_Change {
            get { return amount_Change; }
            set { 
                amount_Change = value;
                tbox_Change.Text = string.Format("{0:c}", amount_Change);
            }
        }
        #endregion

        public PaymentPanel() {
            InitializeComponent();
            
            tbox_Paying.KeyPress += Tbox_OnlyNumber_KeyPress;
            CoffeShopPOS.OpenPaymentPanelEvent += OnOpenPaymentPanel;
        }

        private void OnOpenPaymentPanel(float totalPrice) {
            Amount_TotalPrice = Amount_ToBePaid = totalPrice;
            Amount_Paid = 0;
            Amount_Change = 0;
        }

        private void Tbox_OnlyNumber_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        //  结算
        private void btn_ConfirmPayment_Click(object sender, EventArgs e) {
            if (Amount_ToBePaid <= 0)
                return;

            //  确认窗口
            var confirmResult = MessageBox.Show("确定结算吗？", "结算确认", MessageBoxButtons.YesNo);
            if (confirmResult == System.Windows.Forms.DialogResult.No) {
                return;
            }

            Amount_Paid += Amount_Paying;

            //  已支付 >= 总计，则计算找零，否则更新待支付的值
            if (Amount_Paid >= Amount_TotalPrice) {
                Amount_Change = Math.Abs(Amount_TotalPrice - Amount_Paid);
                Amount_ToBePaid = 0;
            } else {
                Amount_ToBePaid -= Amount_Paying;
                Amount_Change = 0f;
            }
            Amount_Paying = 0;
        }

        //  交易完成
        private void btn_ConfirmTrans_Click(object sender, EventArgs e) {
            if (Amount_ToBePaid > 0) {
                TransactionCompleteEvent(false);
            } else {
                TransactionCompleteEvent(true);
                this.Close();
            }
        }
    }
}
