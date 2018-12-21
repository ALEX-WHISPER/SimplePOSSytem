using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeShopProject {
    public partial class Form1 : Form {

        private static string conStr = 
        @"Data Source=(LocalDB)\v11.0;
        AttachDbFilename=G:\VS Projects\CoffeeShopProject\CoffeeShopProject\CoffeeShopDB.mdf;
        Integrated Security=True";
        
        public static SqlConnection con = new SqlConnection(conStr);

        public Form1() {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e) {
            AddProduct frm_AddPro = new AddProduct();
            frm_AddPro.Show();
        }

        private void btn_View_Click(object sender, EventArgs e) {
            ViewProducts frm_ViewPro = new ViewProducts();
            frm_ViewPro.Show();
        }

        private void btn_OpenPOS_Click(object sender, EventArgs e) {
            CoffeShopPOS frm_POS = new CoffeShopPOS();
            frm_POS.Show();
        }
    }
    public sealed class DBEntitiesInstance {
        private static CoffeeShopDBEntities instance = new CoffeeShopDBEntities();
        public static CoffeeShopDBEntities Instance { get { return instance; } }
    }
}
