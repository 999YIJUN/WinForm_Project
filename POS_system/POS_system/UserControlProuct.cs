using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class UserControlProuct : UserControl
    {
        public int SelectID;
        public UserControlProuct()
        {
            InitializeComponent();
        }

        private void UserControlProuct_Load(object sender, EventArgs e)
        {
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if(numericQuan.Value > 0)
            {
                int intPrice = 0;
                Int32.TryParse(lblPrice.Text, out intPrice);
                int subtotal = intPrice * (int)numericQuan.Value;
                FrmMain.GetIntance().tempText(SelectID, lblProductName.Text, lblPrice.Text, numericQuan.Value.ToString(), subtotal.ToString());
            }
            else
            {
                MessageBox.Show("未選擇商品數量");
            }
            
        }
    }
}
