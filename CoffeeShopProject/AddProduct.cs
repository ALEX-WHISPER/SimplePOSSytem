using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopProject {
    public partial class AddProduct : Form {
        private static string attrName_ProType_Description = "Description";
        private static string attrName_ProType_Type = "ProductType";
        private byte[] ProImgByArr;

        public AddProduct() {
            InitializeComponent();

            cbox_ProType.DataSource = DBEntitiesInstance.Instance.TblProType.ToList<TblProType>();
            cbox_ProType.DisplayMember = attrName_ProType_Description;
            cbox_ProType.ValueMember = attrName_ProType_Type;
        }

        private void btn_ChooseProImg_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK) {
                FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read);
                ProImgByArr = new byte[fs.Length];
                fs.Read(ProImgByArr, 0, ProImgByArr.Length);

                pbox_ProImg.Image = Image.FromStream(fs);
                
                fs.Close();
            }
        }

        private void btn_AddProSave_Click(object sender, EventArgs e) {
            var newProduct = new TblProduct();

            newProduct.ProName = tbox_ProName.Text.Trim();
            newProduct.Price = Decimal.Parse(tbox_ProPrice.Text.Trim());
            newProduct.ProductType = (int)(cbox_ProType.SelectedValue);
            newProduct.Image = ProImgByArr;

            DBEntitiesInstance.Instance.TblProduct.Add(newProduct);
            DBEntitiesInstance.Instance.SaveChanges();

            MessageBox.Show("Saved");
        }
    }
}
