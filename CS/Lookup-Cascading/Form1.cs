using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookup_Cascading {
    public partial class Form1 : Form {
        public Form1() {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            List<Category> categories = new List<Category> {
                new Category(){ Key = 0, CategoryName = "Beverages" },
                new Category(){ Key = 1, CategoryName = "Grains" },
                new Category(){ Key = 2, CategoryName = "Seafood" },
            };
            lookUpEdit1.Properties.DataSource = categories;
            lookUpEdit1.Properties.DisplayMember = "CategoryName";
            lookUpEdit1.Properties.KeyMember = "Key";


            List <Product>  products = new List<Product> {
                new Product(){ ID=0, ProductName="Chang", CategoryID =  0  },
                new Product(){ ID=1, ProductName="Ipoh Coffee", CategoryID =  0  },
                new Product(){ ID=2, ProductName="Ravioli Angelo", CategoryID = 1  },
                new Product(){ ID=3, ProductName="Filo Mix", CategoryID = 1  },
                new Product(){ ID=4, ProductName="Tunnbröd", CategoryID  = 1  },
                new Product(){ ID=5, ProductName="Konbu", CategoryID  = 2  },
                new Product(){ ID=6, ProductName="Boston Crab Meat", CategoryID  = 2  }
            };
            lookUpEdit2.Properties.DataSource = products;
            lookUpEdit2.Properties.KeyMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "ProductName";
            lookUpEdit2.CascadingOwner = lookUpEdit1;
            // The following line is not required, as lookUpEdit2 automatically identifies a foreign key ("CategoryID") in its data source
            // by appending the "ID" suffix to primary object's class name ("Category")
            //lookUpEdit2.Properties.CascadingMember = "CategoryID";


        }

        string getObjectString(object obj) {
            if (obj == null) return "EditValue: null";
            return obj.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e) {
            labelControl1.Text = getObjectString(lookUpEdit1.EditValue);
            labelControl2.Text = getObjectString(lookUpEdit2.EditValue);
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            lookUpEdit2.EditValue = null;
        }
    }

    public class Category {
        public int Key { get; set; }
        public string CategoryName { get; set; }
        public override string ToString() {
            return "Category object" + " { Key:" + Key + ", CategoryName:" + CategoryName + "}";
        }
    }

    public class Product {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public override string ToString() {
            return "Product object" + " { CategoryID:" + CategoryID + ", ProductName:" + ProductName + "}";
        }
    }


}
