
namespace ConsinmentShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.header_txtlbl = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.itemListBox_lbl = new System.Windows.Forms.Label();
            this.addToCart_btn = new System.Windows.Forms.Button();
            this.cartitemList_lbl = new System.Windows.Forms.Label();
            this.cartList_box = new System.Windows.Forms.ListBox();
            this.makePurchese_btn = new System.Windows.Forms.Button();
            this.vendor_lbl = new System.Windows.Forms.Label();
            this.VendorListBox = new System.Windows.Forms.ListBox();
            this.StoreProfit_lbl = new System.Windows.Forms.Label();
            this.store_value_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header_txtlbl
            // 
            this.header_txtlbl.AutoSize = true;
            this.header_txtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_txtlbl.Location = new System.Drawing.Point(72, 33);
            this.header_txtlbl.Name = "header_txtlbl";
            this.header_txtlbl.Size = new System.Drawing.Size(196, 25);
            this.header_txtlbl.TabIndex = 0;
            this.header_txtlbl.Text = "Consignment Shop";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 20;
            this.itemListBox.Location = new System.Drawing.Point(66, 111);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(202, 144);
            this.itemListBox.TabIndex = 1;
            // 
            // itemListBox_lbl
            // 
            this.itemListBox_lbl.AutoSize = true;
            this.itemListBox_lbl.Location = new System.Drawing.Point(62, 86);
            this.itemListBox_lbl.Name = "itemListBox_lbl";
            this.itemListBox_lbl.Size = new System.Drawing.Size(96, 20);
            this.itemListBox_lbl.TabIndex = 2;
            this.itemListBox_lbl.Text = "Store Items ";
            // 
            // addToCart_btn
            // 
            this.addToCart_btn.Location = new System.Drawing.Point(337, 163);
            this.addToCart_btn.Name = "addToCart_btn";
            this.addToCart_btn.Size = new System.Drawing.Size(125, 32);
            this.addToCart_btn.TabIndex = 3;
            this.addToCart_btn.Text = "AddTo Cart->";
            this.addToCart_btn.UseVisualStyleBackColor = true;
            this.addToCart_btn.Click += new System.EventHandler(this.addToCart_btn_Click);
            // 
            // cartitemList_lbl
            // 
            this.cartitemList_lbl.AutoSize = true;
            this.cartitemList_lbl.Location = new System.Drawing.Point(535, 86);
            this.cartitemList_lbl.Name = "cartitemList_lbl";
            this.cartitemList_lbl.Size = new System.Drawing.Size(115, 20);
            this.cartitemList_lbl.TabIndex = 5;
            this.cartitemList_lbl.Text = "Shopping Cart ";
            // 
            // cartList_box
            // 
            this.cartList_box.FormattingEnabled = true;
            this.cartList_box.ItemHeight = 20;
            this.cartList_box.Location = new System.Drawing.Point(524, 111);
            this.cartList_box.Name = "cartList_box";
            this.cartList_box.Size = new System.Drawing.Size(202, 144);
            this.cartList_box.TabIndex = 4;
            // 
            // makePurchese_btn
            // 
            this.makePurchese_btn.Location = new System.Drawing.Point(645, 261);
            this.makePurchese_btn.Name = "makePurchese_btn";
            this.makePurchese_btn.Size = new System.Drawing.Size(81, 31);
            this.makePurchese_btn.TabIndex = 6;
            this.makePurchese_btn.Text = "Purchese";
            this.makePurchese_btn.UseVisualStyleBackColor = true;
            this.makePurchese_btn.Click += new System.EventHandler(this.makePurchese_btn_Click);
            // 
            // vendor_lbl
            // 
            this.vendor_lbl.AutoSize = true;
            this.vendor_lbl.Location = new System.Drawing.Point(62, 278);
            this.vendor_lbl.Name = "vendor_lbl";
            this.vendor_lbl.Size = new System.Drawing.Size(69, 20);
            this.vendor_lbl.TabIndex = 8;
            this.vendor_lbl.Text = "Vendors";
            // 
            // VendorListBox
            // 
            this.VendorListBox.FormattingEnabled = true;
            this.VendorListBox.ItemHeight = 20;
            this.VendorListBox.Location = new System.Drawing.Point(66, 301);
            this.VendorListBox.Name = "VendorListBox";
            this.VendorListBox.Size = new System.Drawing.Size(202, 144);
            this.VendorListBox.TabIndex = 7;
            // 
            // StoreProfit_lbl
            // 
            this.StoreProfit_lbl.AutoSize = true;
            this.StoreProfit_lbl.Location = new System.Drawing.Point(492, 301);
            this.StoreProfit_lbl.Name = "StoreProfit_lbl";
            this.StoreProfit_lbl.Size = new System.Drawing.Size(93, 20);
            this.StoreProfit_lbl.TabIndex = 9;
            this.StoreProfit_lbl.Text = "Store Profit:";
            // 
            // store_value_lbl
            // 
            this.store_value_lbl.AutoSize = true;
            this.store_value_lbl.Location = new System.Drawing.Point(587, 301);
            this.store_value_lbl.Name = "store_value_lbl";
            this.store_value_lbl.Size = new System.Drawing.Size(49, 20);
            this.store_value_lbl.TabIndex = 10;
            this.store_value_lbl.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.store_value_lbl);
            this.Controls.Add(this.StoreProfit_lbl);
            this.Controls.Add(this.vendor_lbl);
            this.Controls.Add(this.VendorListBox);
            this.Controls.Add(this.makePurchese_btn);
            this.Controls.Add(this.cartitemList_lbl);
            this.Controls.Add(this.cartList_box);
            this.Controls.Add(this.addToCart_btn);
            this.Controls.Add(this.itemListBox_lbl);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.header_txtlbl);
            this.Name = "Form1";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header_txtlbl;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Label itemListBox_lbl;
        private System.Windows.Forms.Button addToCart_btn;
        private System.Windows.Forms.Label cartitemList_lbl;
        private System.Windows.Forms.ListBox cartList_box;
        private System.Windows.Forms.Button makePurchese_btn;
        private System.Windows.Forms.Label vendor_lbl;
        private System.Windows.Forms.ListBox VendorListBox;
        private System.Windows.Forms.Label StoreProfit_lbl;
        private System.Windows.Forms.Label store_value_lbl;
    }
}

