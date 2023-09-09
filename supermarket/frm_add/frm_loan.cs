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
    public partial class frm_loan : DevExpress.XtraEditors.XtraForm
    {
        public frm_loan()
        {
            InitializeComponent();
        }
        CLASESS.cls_load nclsload = new CLASESS.cls_load();
        public  void cear_data()
        {
            gridControl1.DataSource = nclsload.select_data(txt_search.Text);
            gridView1.Columns.Remove(gridView1.Columns["Expr1"]);
            gridView1.Columns.Remove(gridView1.Columns["loan_id"]);
            gridView1.Columns.Remove(gridView1.Columns["cust_id"]);
            gridView1.Columns.Remove(gridView1.Columns["inv_id"]);
            gridView1.Columns.Remove(gridView1.Columns["loan_name_project"]);
            gridView1.Columns["inv_stat"].Caption = "حالة البيع ";
            gridView1.Columns["inv_time"].Caption = "وقت الدين";
            gridView1.Columns["cust_name"].Caption = "اسم الزبون";
            gridView1.Columns["cust_address"].Caption = "موقع الزبون";
            gridView1.Columns["cust_phon"].Caption = "موقع الزبون";


        }

        private void frm_loan_Load(object sender, EventArgs e)
        {
            cear_data();
        }

        private void txt_search_EditValueChanged(object sender, EventArgs e)
        {
            cear_data();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
          //  CLASESS.cls_load.loan_data.Deleteloan(CLASESS.cls_load.load_id);
            cear_data();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
        //    nclsload.select_data(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["loan_cust_name"]).ToString(), gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["loan_cust_name"]).ToString());

        }
    }
}