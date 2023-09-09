using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket.frm_main
{
    public partial class main_item : DevExpress.XtraEditors.XtraForm
    {
        public main_item()
        {
            InitializeComponent();
        }
        frm_add.frm_req_add f = new frm_add.frm_req_add();
        private void main_item_Load(object sender, EventArgs e)
        {
           int num_row=0;
           f.row();
            tileItem4.Text = f.row().ToString()+" عدد الطلبات الحالية";
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            
            
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_add.frm_sales_add fs = new frm_add.frm_sales_add();
            fs.ShowDialog();
        }

        private void tileItem4_ItemClick_1(object sender, TileItemEventArgs e)
        {
            f.ShowDialog();
        }
    }
}