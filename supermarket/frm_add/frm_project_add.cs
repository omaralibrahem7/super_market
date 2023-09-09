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
    public partial class frm_project_add : DevExpress.XtraEditors.XtraForm
    {
        public frm_project_add()
        {
            InitializeComponent();
        }
        CLASESS.cls_category nclscat = new CLASESS.cls_category();
        CLASESS.cls_project ncls_pro = new CLASESS.cls_project();
        public static int cat_id;
        public void clear_data()
        {
            txt_cat_name.DataSource = CLASESS.cls_category.data_cat.GetData();
            txt_cat_name.ValueMember = "cat_name";
            txt_cat_id.DataSource = txt_cat_name.DataSource;
            txt_cat_id.ValueMember = "cat_id";
            txt_cat_id.Enabled = false;


            gridControl1.DataSource = ncls_pro.select_data(txt_search.Text);
            gridView1.Columns.Remove(gridView1.Columns["cat_id"]);
            gridView1.Columns.Remove(gridView1.Columns["pro_id"]);
            gridView1.Columns["pro_name"].Caption = "اسم المنتج";
            gridView1.Columns["pro_price"].Caption = "سعر الصنف";
            gridView1.Columns["pro_quantity"].Caption = "الكمية الموجودة";
            gridView1.Columns["pro_company"].Caption = "الشركة المنتجة";
            gridView1.Columns["cat_name"].Caption = "الصنف";

            txt_quantity.Text = "0";
            txt_price.Text = "0";
            txt_company.Text = "";
            txt_cat_name.Text = "";
            txt_cat_id.Text = "";
            txt_name.Text = "";
            txt_search.Text = "";
        }
        private void frm_project_add_Load(object sender, EventArgs e)
        {
            clear_data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cat_name.Text!=""&& txt_price.Text!=""&&txt_quantity.Text!="")
                {
                    CLASESS.cls_project.pro_data.Insert_pro(txt_name.Text, txt_price.Text, txt_quantity.Text, txt_company.Text, Convert.ToInt32(txt_cat_id.Text));
                    clear_data();
                }
                else
                {
                    MessageBox.Show("قم بدخال البيانات بشكل صحيح");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            ncls_pro.select_data(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["pro_name"]).ToString());
            txt_name.Text = CLASESS.cls_project.pro_name.ToString();
            txt_price.Text = CLASESS.cls_project.pro_price.ToString();
            txt_quantity.Text = CLASESS.cls_project.pro_quantity.ToString();
            txt_company.Text = CLASESS.cls_project.pro_company.ToString();
            txt_cat_id.Text = CLASESS.cls_project.cat_id.ToString();


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                CLASESS.cls_project.pro_data.Update_project(txt_name.Text, txt_price.Text, txt_quantity.Text, txt_company.Text, Convert.ToInt32(txt_cat_id.Text), CLASESS.cls_project.pro_id, CLASESS.cls_project.pro_id);
                clear_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                CLASESS.cls_project.pro_data.Delete_project(CLASESS.cls_project.pro_id);
                clear_data();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void txt_search_EditValueChanged(object sender, EventArgs e)
        {
            clear_data();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            clear_data();
        }
    }
}