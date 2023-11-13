using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace POS_system
{
    public partial class FrmMain : Form
    {
        private List<int> selectedIndices = new List<int>();

        string image_name = string.Empty;
        public static FrmMain instance;
        public static FrmMain GetIntance()
        {
            if(instance == null)
            {
                instance = new FrmMain();
            }
            return instance;
        }
        private FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            read_Product_DB();
            listViewCreate();

            txtTotalPrice.Enabled = false;
        }

        public void tempText(int ID, string Name, string Price, string Numeric, string subTotal)
        {
            ListViewItem item = new ListViewItem(Name);
            item.SubItems.Add(Price);
            item.SubItems.Add(Numeric);
            item.SubItems.Add(subTotal);
            item.Tag = ID;

            listViewOrderDetail.Items.Add(item);
            sum();
        }

        void listViewCreate()
        {
            listViewOrderDetail.View = View.Details;
            listViewOrderDetail.FullRowSelect = true;
            listViewOrderDetail.GridLines = true;
            //listViewOrderDetail.OwnerDraw = true;
            listViewOrderDetail.CheckBoxes = true;
            listViewOrderDetail.LabelEdit = false;
            listViewOrderDetail.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            listViewOrderDetail.Columns.Add("商品名稱", 100).Tag = "visible";
            listViewOrderDetail.Columns.Add("價錢", 100).Tag = "visible";
            listViewOrderDetail.Columns.Add("數量", 100).Tag = "visible";
            listViewOrderDetail.Columns.Add("小計", 100).Tag = "visible";


            // 隱藏標記為"hidden"的列
            foreach (ColumnHeader column in listViewOrderDetail.Columns)
            {
                if (column.Tag != null && column.Tag.ToString() == "hidden")
                {
                    column.Width = 0;
                }
            }
        }

        void read_Product_DB()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select * from PRODUCT";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
               
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            UserControlProuct ucProduct = new UserControlProuct();
                            ucProduct.SelectID = (int)reader["ProductID"];
                            ucProduct.lblProductName.Text = reader["ProductName"].ToString();
                            ucProduct.lblPrice.Text = reader["Price"].ToString();
                            image_name = reader["Image"].ToString();
                            string FullName = GlobalVar.image_dir + image_name;
                            ucProduct.pictureBoxProuct.Image = Image.FromFile(FullName);
                            flowLayoutPanel1.Controls.Add(ucProduct);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order_Add();
            listViewOrderDetail.Clear();
        }

        void Order_Add()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    int newOrderID = 0;
                    con.Open();
                    string strSQL_Order = "INSERT INTO ORDERS (CustomerID, EmployeeID, OrderDate, TotalPrice) VALUES (@newC_ID, @newE_ID, @newDate, @newTotalPrice); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd_Order = new SqlCommand(strSQL_Order, con);
                    cmd_Order.Parameters.AddWithValue("newC_ID", 14);
                    cmd_Order.Parameters.AddWithValue("newE_ID", 11);
                    cmd_Order.Parameters.AddWithValue("newDate", DateTime.Now.ToString());
                    int intTotalPrice = 0;
                    Int32.TryParse(txtTotalPrice.Text, out intTotalPrice);
                    cmd_Order.Parameters.AddWithValue("newTotalPrice", intTotalPrice);
                    newOrderID = Convert.ToInt32(cmd_Order.ExecuteScalar()); // 取最新插入的 OrderID

                    foreach (ListViewItem item in listViewOrderDetail.Items)
                    {
                        string strSQL_OrderDetail = "INSERT INTO OrderDetail (OrderID, ProductID, Quantity, Subtotal) VALUES (@newOrder, @newProduct, @newQuan, @newSubtotal)";
                        SqlCommand cmd_OrderDetail = new SqlCommand(strSQL_OrderDetail, con);

                        int intProduct = (int)item.Tag;
                        int intQuan = 0;
                        Int32.TryParse(item.SubItems[2].Text, out intQuan);
                        int intSubtotal = 0;
                        Int32.TryParse(item.SubItems[3].Text, out intSubtotal);
                        cmd_OrderDetail.Parameters.AddWithValue("newOrder", newOrderID);
                        cmd_OrderDetail.Parameters.AddWithValue("newProduct", intProduct);
                        cmd_OrderDetail.Parameters.AddWithValue("newQuan", intQuan);
                        cmd_OrderDetail.Parameters.AddWithValue("newSubtotal", intSubtotal);
                        cmd_OrderDetail.ExecuteNonQuery();
                    }
                    MessageBox.Show("訂單新增成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void sum()
        {
            int intSum = 0;
            foreach (ListViewItem item in listViewOrderDetail.Items)
            {
                int item_to_int = 0;
                Int32.TryParse(item.SubItems[3].Text, out item_to_int);
                intSum += item_to_int;
            }
            txtTotalPrice.Text = Convert.ToString(intSum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOrderManagement.GetIntance().ShowDialog();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            Load_CustomerDB();
        }

        void Load_CustomerDB()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select CustomerID, CustomerName from CUSTOMER where ContactNumber = @newContact;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("newContact", txtCusSearch.Text.Trim());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        label1.Text = reader.GetInt32(0).ToString() + reader.GetString(1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
