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
    public partial class category_add : DevExpress.XtraEditors.XtraForm
    {
        public category_add()
        {
            InitializeComponent();
        }

        CLASESS.cls_category nclscat = new CLASESS.cls_category();
        public void clear_data()
        {
            DataTable dt = new DataTable();
            dt = CLASESS.cls_category.data_cat.getdata_by_name(txt_search.Text);
            
            gridControl1.DataSource = dt;
            gridView1.Columns.Remove(gridView1.Columns["cat_id"]);
            gridView1.Columns["cat_name"].Caption = "اسم الصنف";
            gridView1.Columns["cat_description"].Caption = "موصفات الصنف";
            txt_name.Text = "";
            txt_discription.Text = "";
            txt_search.Text = "";

        }
        private void category_add_Load(object sender, EventArgs e)
        {
            clear_data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CLASESS.cls_category.data_cat.insert_category(txt_name.Text, txt_discription.Text);
            clear_data();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CLASESS.cls_category.data_cat.update_cat(txt_name.Text, txt_discription.Text, CLASESS.cls_category.cat_id, CLASESS.cls_category.cat_id);
            clear_data();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            nclscat.select_data(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["cat_name"]).ToString());
            txt_name.Text = CLASESS.cls_category.cat_name.ToString();
            txt_discription.Text = CLASESS.cls_category.cat_description.ToString();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            CLASESS.cls_category.data_cat.Delete_cat(CLASESS.cls_category.cat_id);
            clear_data();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            clear_data();
        }

      
        private void txt_search_EditValueChanged(object sender, EventArgs e)
        {
            clear_data();
        }
    }
}