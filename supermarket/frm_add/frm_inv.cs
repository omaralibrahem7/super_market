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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace supermarket.frm_add
{
    public partial class frm_inv : DevExpress.XtraEditors.XtraForm
    {
        public frm_inv()
        {
            InitializeComponent();
        }
        CLASESS.cls_invoice ncls_inv = new CLASESS.cls_invoice();
        
        public void clear_data()
        {
            try
                {
                gridControl1.DataSource = ncls_inv.select_data(txt_search.Text, txt_search.Text);
                gridView1.Columns.Remove(gridView1.Columns["inv_id"]);
                gridView1.Columns.Remove(gridView1.Columns["Expr3"]);
                gridView1.Columns.Remove(gridView1.Columns["cust_id"]);
                gridView1.Columns.Remove(gridView1.Columns["Expr1"]);
                gridView1.Columns.Remove(gridView1.Columns["Expr2"]);
                gridView1.Columns.Remove(gridView1.Columns["sal_list_id"]);
                gridView1.Columns.Remove(gridView1.Columns["pro_id"]);
                gridView1.Columns.Remove(gridView1.Columns["pro_name"]);
                gridView1.Columns["inv_date"].Caption = "تاريخ الفاتورة";
                gridView1.Columns["inv_time"].Caption = "وقت الفاتورة";
                gridView1.Columns["inv_total"].Caption = "سعر الفاتورة";
                gridView1.Columns["inv_stat"].Caption = "حالة الدفع ";
                gridView1.Columns["cust_name"].Caption = "اسم الزبون";
                gridView1.Columns["inv_note"].Caption = "المنتجات";
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            




        }
        public void frm_inv_Load(object sender, EventArgs e)
        {
            clear_data();

        }

        public void txt_search_EditValueChanged(object sender, EventArgs e)
        {
            clear_data();
        }

        public void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }



       

    }
}