using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsginementLibrary;

namespace ConsinmentShop
{
    public partial class Form1 : Form
    {

        //List of vendors
        //List of Item per vendor rate
        //Each vendor can have default commision rate
        //Track hou much to pay the vendor
        // Track ho much to pay to store

       // List<Item> items = new List<Item>();

        List<Item> cartItem = new List<Item>();
        Vendor vendor = new Vendor();
        Store store = new Store();
        BindingSource itemBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();

        

        
    
        public Form1()
        {
            InitializeComponent();
            SeedData();

           // itemBinding.DataSource = store.Items.Where(c => c.sold == false).ToList();
            itemBinding.DataSource = store.Items ;
            itemListBox.DataSource = itemBinding;

            vendorBinding.DataSource = store.Vendors;
            VendorListBox.DataSource = vendorBinding;

            cartBinding.DataSource = cartItem;          ;
            cartList_box.DataSource = cartBinding;

            itemListBox.DisplayMember = "Display";
            itemListBox.ValueMember = "Display";

            cartList_box.DisplayMember = "Display";
            cartList_box.ValueMember = "Display";

            VendorListBox.DisplayMember = "Display";
            VendorListBox.ValueMember = "Display";
        }

        public void SeedData()
        {
            Vendor vendor = new Vendor
            {
                FirstName="Gillaine",
                LastName="jane",
                Commission=0.5
            };

            store.Vendors.Add(vendor);

            Vendor vendor1 = new Vendor
            {
                FirstName="Clara",
                LastName="Dyr",
                Commission=0.7

            };

            store.Vendors.Add(vendor1);
     
            store.Items.Add(new Item { Name = "S9", Price = 30M, sold = false, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Name = "S10", Price = 10M, sold = false, Owner = store.Vendors[1] });
          
           
        }

        private void addToCart_btn_Click(object sender, EventArgs e)
        {
            // Item selectedItem = (Item)itemListBox.SelectedItem;
            //MessageBox.Show(selectedItem.Name);
            Item SelectedItem = (Item)itemListBox.SelectedItem;
            cartItem.Add(SelectedItem);
            
            cartBinding.ResetBindings(false);
         
        }

        private void makePurchese_btn_Click(object sender, EventArgs e)
        {
            foreach (var item in cartItem)
            {
                item.sold = true;

                item.Owner.PaymenttDue += (decimal)item.Owner.Commission * item.Price;
            }

            cartItem.Clear();
            // it will show to item display which one sold ==false 

            itemBinding.DataSource = store.Items.Where(c => c.sold == false).ToList();

            itemBinding.ResetBindings(false);
            cartBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);
          
        }
    }
}
