namespace CoffeeShopProject {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_OpenPOS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 21);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(260, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(12, 73);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(260, 23);
            this.btn_View.TabIndex = 2;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_OpenPOS
            // 
            this.btn_OpenPOS.Location = new System.Drawing.Point(12, 136);
            this.btn_OpenPOS.Name = "btn_OpenPOS";
            this.btn_OpenPOS.Size = new System.Drawing.Size(260, 23);
            this.btn_OpenPOS.TabIndex = 3;
            this.btn_OpenPOS.Text = "Open POS";
            this.btn_OpenPOS.UseVisualStyleBackColor = true;
            this.btn_OpenPOS.Click += new System.EventHandler(this.btn_OpenPOS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_OpenPOS);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.btn_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_OpenPOS;
    }
}

