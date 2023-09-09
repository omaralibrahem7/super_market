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

namespace supermarket.frm_add
{
    public partial class frm_req_add : DevExpress.XtraEditors.XtraForm
    {
        public frm_req_add()
        {
            InitializeComponent();
        }

        public int row()
        {
            DataTable dt = new DataTable();
            dt = CLASESS.cls_invoice.inv_data.selec_reuast();
            gridControl1.DataSource = dt;
            return dt.Rows.Count;

        }
        public void clear_data() 
        {
            DataTable dt = new DataTable();
            dt= CLASESS.cls_invoice.inv_data.selec_reuast();
            gridControl1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
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



        }
        private void frm_req_add_Load(object sender, EventArgs e)
        {
            clear_data();
        }

        private void txt_search_EditValueChanged(object sender, EventArgs e)
        {
            clear_data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          //  CLASESS.cls_request.data_req.Insert_req(txt_name.Text, txt_phon.Text,Convert.ToDateTime(string.Format( DateTime.Now.ToShortDateString(),"yyyy/mm/dd")), txt_stat.Text, txt_address.Text, txt_push_stat.Text);
            clear_data();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
//CLASESS.cls_request.data_req.Update_req(txt_name.Text, txt_phon.Text, Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyyy/mm/dd")), txt_stat.Text, txt_address.Text, txt_push_stat.Text, CLASESS.cls_request.req_id, CLASESS.cls_request.req_id);
            clear_data();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
//nclsreq.select_data(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["req_cust_name"]).ToString());
       //     txt_name.Text = CLASESS.cls_request.req_cust_name.ToString();
       //     txt_phon.Text = CLASESS.cls_request.req_phon.ToString();
       //     txt_stat.Text = CLASESS.cls_request.req_stat.ToString();
//txt_address.Text = CLASESS.cls_request.req_address.ToString();
         //   txt_push_stat.Text = CLASESS.cls_request.req_push_stat.ToString();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
         //   CLASESS.cls_request.data_req.Delete_req(CLASESS.cls_request.req_id);
            clear_data();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            clear_data();
        }
    }
}