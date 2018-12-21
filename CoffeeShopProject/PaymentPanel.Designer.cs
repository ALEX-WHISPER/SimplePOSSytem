namespace CoffeeShopProject {
    partial class PaymentPanel {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_ToBePaid = new System.Windows.Forms.TextBox();
            this.tbox_Paid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Paying = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConfirmPayment = new System.Windows.Forms.Button();
            this.btn_ConfirmTrans = new System.Windows.Forms.Button();
            this.tbox_Change = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_TotalPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "待支付：";
            // 
            // tbox_ToBePaid
            // 
            this.tbox_ToBePaid.Location = new System.Drawing.Point(173, 99);
            this.tbox_ToBePaid.Name = "tbox_ToBePaid";
            this.tbox_ToBePaid.ReadOnly = true;
            this.tbox_ToBePaid.Size = new System.Drawing.Size(100, 21);
            this.tbox_ToBePaid.TabIndex = 1;
            // 
            // tbox_Paid
            // 
            this.tbox_Paid.Location = new System.Drawing.Point(173, 154);
            this.tbox_Paid.Name = "tbox_Paid";
            this.tbox_Paid.ReadOnly = true;
            this.tbox_Paid.Size = new System.Drawing.Size(100, 21);
            this.tbox_Paid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "已支付：";
            // 
            // tbox_Paying
            // 
            this.tbox_Paying.Location = new System.Drawing.Point(173, 212);
            this.tbox_Paying.Name = "tbox_Paying";
            this.tbox_Paying.Size = new System.Drawing.Size(100, 21);
            this.tbox_Paying.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "付款：";
            // 
            // btn_ConfirmPayment
            // 
            this.btn_ConfirmPayment.Location = new System.Drawing.Point(65, 346);
            this.btn_ConfirmPayment.Name = "btn_ConfirmPayment";
            this.btn_ConfirmPayment.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfirmPayment.TabIndex = 6;
            this.btn_ConfirmPayment.Text = "确认";
            this.btn_ConfirmPayment.UseVisualStyleBackColor = true;
            this.btn_ConfirmPayment.Click += new System.EventHandler(this.btn_ConfirmPayment_Click);
            // 
            // btn_ConfirmTrans
            // 
            this.btn_ConfirmTrans.Location = new System.Drawing.Point(248, 346);
            this.btn_ConfirmTrans.Name = "btn_ConfirmTrans";
            this.btn_ConfirmTrans.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfirmTrans.TabIndex = 7;
            this.btn_ConfirmTrans.Text = "交易完成";
            this.btn_ConfirmTrans.UseVisualStyleBackColor = true;
            this.btn_ConfirmTrans.Click += new System.EventHandler(this.btn_ConfirmTrans_Click);
            // 
            // tbox_Change
            // 
            this.tbox_Change.Location = new System.Drawing.Point(173, 267);
            this.tbox_Change.Name = "tbox_Change";
            this.tbox_Change.ReadOnly = true;
            this.tbox_Change.Size = new System.Drawing.Size(100, 21);
            this.tbox_Change.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "找零：";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(36, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "总计：";
            // 
            // tbox_TotalPrice
            // 
            this.tbox_TotalPrice.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbox_TotalPrice.Location = new System.Drawing.Point(136, 8);
            this.tbox_TotalPrice.Name = "tbox_TotalPrice";
            this.tbox_TotalPrice.ReadOnly = true;
            this.tbox_TotalPrice.Size = new System.Drawing.Size(212, 46);
            this.tbox_TotalPrice.TabIndex = 11;
            // 
            // PaymentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 397);
            this.Controls.Add(this.tbox_TotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_Change);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ConfirmTrans);
            this.Controls.Add(this.btn_ConfirmPayment);
            this.Controls.Add(this.tbox_Paying);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_Paid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_ToBePaid);
            this.Controls.Add(this.label1);
            this.Name = "PaymentPanel";
            this.Text = "PaymentPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_ToBePaid;
        private System.Windows.Forms.TextBox tbox_Paid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Paying;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ConfirmPayment;
        private System.Windows.Forms.Button btn_ConfirmTrans;
        private System.Windows.Forms.TextBox tbox_Change;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_TotalPrice;
    }
}