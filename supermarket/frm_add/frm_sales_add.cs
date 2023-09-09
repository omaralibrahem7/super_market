using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;


namespace supermarket.frm_add
{
    public partial class frm_sales_add : DevExpress.XtraEditors.XtraForm
    {
        public frm_sales_add()
        {
            InitializeComponent();
        }
        CLASESS.cls_project ncls_Project = new CLASESS.cls_project();
        CLASESS.cls_sales nclssal = new CLASESS.cls_sales();
        CLASESS.cls_load ncls_load = new CLASESS.cls_load();
        CLASESS.cls_cust nclscust = new CLASESS.cls_cust();
        CLASESS.cls_invoice cls_Invoice = new CLASESS.cls_invoice();
        public int pro_id1;
        public int pro_id2;
        int currentProPrice;


        public void clear_pro()
        {
            gridControl1.DataSource = ncls_Project.select_data(txt_search.Text);
           // gridView1.Columns.Remove(gridView1.Columns["pro_id"]);
            gridView1.Columns.Remove(gridView1.Columns["pro_company"]);
            gridView1.Columns.Remove(gridView1.Columns["cat_id"]);
            gridView1.Columns.Remove(gridView1.Columns["Expr1"]);
            gridView1.Columns["pro_name"].Caption = "اسم المنتج";
            gridView1.Columns["pro_price"].Caption = "سعر الصنف";
            gridView1.Columns["pro_quantity"].Caption = "الكمية الموجودة";
            gridView1.Columns["cat_name"].Caption = "اسم الصنف";



            gridControl2.DataSource = nclssal.select_data();//select_data(txt_serach_2.Text,txt_serach_2.Text);
            gridView2.Columns.Remove(gridView2.Columns["Expr1"]);
         
            gridView2.Columns.Remove(gridView2.Columns["pro_id"]);
            gridView2.Columns.Remove(gridView2.Columns["sal_id"]);
            gridView2.Columns.Remove(gridView2.Columns["sal_cust_name"]);
            gridView2.Columns.Remove(gridView2.Columns["sal_cusl_phon"]);
            gridView2.Columns.Remove(gridView2.Columns["sal_addres"]);
            gridView2.Columns.Remove(gridView2.Columns["sal_req"]);
            gridView2.Columns["sal_numaber"].Caption = "العدد";
            gridView2.Columns["sal_price"].Caption = "سعر القطعة ";
            gridView1.Columns["pro_name"].Caption = "اسم المنتج";
            gridView2.Columns["sal_date"].Caption = "تاريخ الشراء ";
            gridView2.Columns["sal_time"].Caption = "وقت الشراء ";
            gridView2.Columns["cust_id"].Caption = "الرقم";
            gridView2.Columns["sal_push_stat"].Caption = "حالة الدفع";
            gridView2.Columns["pro_name"].Caption = "اسم المنتج";

            txt_cust_name.Enabled=false;
            txt_cust_phon.Enabled = false;
            txt_address.Enabled = false;
            txt_push_stat.Enabled = false;

            DataTable dtResult = CLASESS.cls_sales.sales_data.sum_price();

            // التحقق مما إذا كانت هناك بيانات في الجدول قبل الوصول إليها
            if (dtResult.Rows.Count == 1)
            {
                int totalPrice;
                int sum_number;

                // حاول تحويل قيمة "sum_price" إلى int
                if (int.TryParse(dtResult.Rows[0]["sum_price"].ToString(), out totalPrice))
                {
                    // حاول تحويل قيمة "sum_number" إلى int
                    if (int.TryParse(dtResult.Rows[0]["sum_number"].ToString(), out sum_number))
                    {
                        // التحويل الناجح لكلا الـ totalPrice و sum_number
                        // قم بتحديث TextBoxes بشكل آمن
                        txt_total_price.Text = totalPrice.ToString();
                        txt_total_number.Text = sum_number.ToString();
                    }
                    else
                    {
                        // في حالة فشل تحويل "sum_number" إلى int
                        txt_total_price.Text = "0";
                        txt_total_number.Text = "0";
                    }
                }
                else
                {
                    // في حالة فشل تحويل "sum_price" إلى int
                    txt_total_price.Text = "0";
                    txt_total_number.Text = "0";
                }
            }
            else
            {
                // في حالة عدم وجود بيانات في الجدول
                txt_total_price.Text = "0";
                txt_total_number.Text = "0";
            }

            
          


        }

        private void frm_sales_add_Load(object sender, EventArgs e)
        {
            clear_pro();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_req.Text == "طلبية" || txt_req.Text == "بيع" && Convert.ToInt32(txt_number.Text) > 0 && txt_push_stat.Text == "دين"|| txt_push_stat.Text == "نقدي")
                {
                    if (Convert.ToInt32(txt_number.Text) <= Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["pro_quantity"]).ToString()))
                    {
                        //  CLASESS.cls_sales.sales_data.insart_sales(Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyyy/mm/dd").ToString()), gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["pro_price"]).ToString(), txt_number.Text, txt_stat.Text,Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["pro_id"]).ToString()));
                        int total_price = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["pro_price"]).ToString()) * Convert.ToInt32(txt_number.Text);
                     
                        CLASESS.cls_sales.sales_data.Insert_sales(1,txt_req.Text,txt_push_stat.Text,total_price,Convert.ToInt32( txt_number.Text),Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyyy/mm/dd").ToString()), TimeSpan.Parse(string.Format(DateTime.Now.Hour.ToString(), "") + ":" + string.Format(DateTime.Now.Minute.ToString(), "")),"","","" , pro_id1);
                        nclscust.select_data(txt_serach_2.Text);
                        CLASESS.cls_sa_list.sal_list_data.Insert_SAL_LIST(CLASESS.cls_cust.cust_id, pro_id1, "");


                        int quantityToSubtract = Convert.ToInt32(txt_number.Text);
                        int result = currentProPrice - quantityToSubtract;

                        CLASESS.cls_project.pro_data.Update_pro_by_minos(result.ToString(), pro_id1, pro_id1);
                       
                    }
                    else
                    {
                        MessageBox.Show("لا توجد لديك بضاعة كافية لهذه الكمية");
                    }
                }
                else
                {
                    MessageBox.Show("يوجد خطأ في ادخال القيم");
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clear_pro();
            
        }

        private void txt_search_EditValueChanged(object sender, EventArgs e)
        {
            clear_pro();
        }

        private void txt_stat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_req.Text== "بيع")
            {
                txt_push_stat.Enabled = true;
            }
            else
            {
                txt_push_stat.Text = "دين";
                txt_push_stat.Enabled = false;
            }
        }

        private void txt_push_stat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_push_stat.Text == "دين")
            {
                txt_cust_name.Enabled = true;
                txt_cust_phon.Enabled = true;
                txt_address.Enabled = true;
            }
            else
            {
                txt_cust_name.Enabled = false;
                txt_cust_phon.Enabled = false;
                txt_address.Enabled = false;
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            StringBuilder valuesBuilder = new StringBuilder();

            // الحصول على GridView الحالي من GridControl
            GridView gridView = gridControl2.MainView as GridView;

            // التأكد من أن GridView غير فارغ وتم تحميل البيانات
            if (gridView != null && gridView.RowCount > 0)
            {
                // الحصول على جميع الصفوف في GridView
                for (int rowIndex = 0; rowIndex < gridView.RowCount; rowIndex++)
                {
                    // احصل على الصف الحالي
                    DataRow row = gridView.GetDataRow(rowIndex);

                    // احصل على قيمة العمود بالاسم
                    object cellValue = row["pro_name"];

                    // إضافة القيمة إلى StringBuilder مع فاصلة (, أو أي فاصلة أخرى تناسب احتياجاتك)
                    valuesBuilder.Append(cellValue.ToString());
                    valuesBuilder.Append(","); // هذه فاصلة، يمكنك تغييرها حسب الحاجة
                }
            }
            string columnValuesString = valuesBuilder.ToString().TrimEnd(',');

            CLASESS.cls_cust.cust_data.Insertcust(txt_cust_name.Text, txt_cust_phon.Text, txt_address.Text);
            nclscust.select_data(txt_serach_2.Text);
            clear_pro();
            CLASESS.cls_invoice.inv_data.Insert_inv(Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyyy/mm/dd").ToString()), TimeSpan.Parse(string.Format(DateTime.Now.Hour.ToString(), "") + ":" + string.Format(DateTime.Now.Minute.ToString(), "")), Convert.ToInt32(txt_total_price.Text), txt_req.Text, columnValuesString, CLASESS.cls_cust.cust_id);// CLASESS.cls_project.pro_id);
//////////////////////////////////////            
            CLASESS.cls_sales.sales_data.Deleteall();
            if (txt_push_stat.Text == "دين")
            {
                cls_Invoice.select_data_inse("", "");
              //  clear_pro();
                CLASESS.cls_load.loan_data.Insert_loan(Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "yyyy/mm/dd").ToString()), TimeSpan.Parse(string.Format(DateTime.Now.Hour.ToString(), "") + ":" + string.Format(DateTime.Now.Minute.ToString(), "")), txt_cust_name.Text, txt_cust_phon.Text, txt_address.Text, columnValuesString, CLASESS.cls_invoice.inv_id);
                MessageBox.Show("تمت الاضافة الى قائمة الدين");
            }

            txt_cust_name.Text = "";
            txt_cust_phon.Text = "";
            txt_address.Text = "";
            txt_push_stat.Text = "";
            txt_req.Text = "";
            txt_number.Text = "0";
            clear_pro();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            currentProPrice = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["pro_quantity"]).ToString());
            ncls_Project.select_data(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["pro_name"]).ToString());
            pro_id1 = CLASESS.cls_project.pro_id;
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            nclssal.select_data_BY_DELETE(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["pro_name"]).ToString());
            pro_id2 = CLASESS.cls_sales.sal_id;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            CLASESS.cls_sales.sales_data.DeleteSAL(pro_id2);
            clear_pro();
        }

       
       

        // يمكنك استدعاء هذه الدالة عند النقر على زر العرض أو الطباعة
      

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //if (printPreviewDialog1.ShowDialog()==DialogResult.)
            //{
            //    printDocument1.Print();
            //}

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            int margen = 30;
            Font f = new Font("Arial",18,FontStyle.Bold);
            e.Graphics.DrawImage(Properties.Resources.developer, 5,5,200,200);

          

            string str_No ="المستخدم " +CLASESS.cls_user.user_name;
            string str_date = "التاريخ " + DateTime.Now.ToShortDateString();
            string str_time = "الوقت " + DateTime.Now.ToShortTimeString();
            string str_cust_name = ".... :مطلوب من السيد " + txt_cust_name.Text;
            string str_all_total = txt_total_price.Text+"السعر الاجمالي : ";

            SizeF fontsizeno = e.Graphics.MeasureString(str_No, f);
            SizeF fontsizedate = e.Graphics.MeasureString(str_date, f);
            SizeF fontsizetime = e.Graphics.MeasureString(str_time, f);
            SizeF fontsizecust_name = e.Graphics.MeasureString(str_cust_name, f);
            SizeF fontsizecust_total_price = e.Graphics.MeasureString(str_all_total, f);

            e.Graphics.DrawString(str_No, f, Brushes.Black,(e.PageBounds.Width- fontsizeno.Width)/2,50);
            e.Graphics.DrawString(str_date, f, Brushes.Black, (e.PageBounds.Width -200) , margen);
            e.Graphics.DrawString(str_time, f, Brushes.Black, (e.PageBounds.Width - 200), margen + fontsizeno.Height);
            e.Graphics.DrawString(str_cust_name, f, Brushes.Black, (e.PageBounds.Width - 200)- margen, 90 +fontsizetime.Height+fontsizeno.Height);

            float heights_all1 = margen + fontsizeno.Height + fontsizetime.Height + fontsizedate.Height + fontsizecust_name.Height+70;
            e.Graphics.DrawRectangle(Pens.Black, 50, heights_all1, e.PageBounds.Width - 50 * 2, e.PageBounds.Height-50*2-heights_all1);

            int col1heiheight = 50;
            
            int col1width = 300;
            int col2width = -110;
            int col3width = -80+ col2width;
            int col4width = -80 + col3width;
            int col5width = -80 + col4width;
            int col6width = -80 + col5width;

            e.Graphics.DrawLine(Pens.Black, col1heiheight,  300, e.PageBounds.Width - col1heiheight, 300);
            e.Graphics.DrawString("اسم المنتج", f, Brushes.Black, e.PageBounds.Width - 140*2, 260);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - 200 * 2, heights_all1, e.PageBounds.Width - 200* 2, e.PageBounds.Height - 50 * 2 );

            //e.Graphics.DrawString("وقت البيع", f, Brushes.Black, col2width+ e.PageBounds.Width - 80 * 2, 260);
            //e.Graphics.DrawLine(Pens.Black, col2width+e.PageBounds.Width - 90 * 2, heights_all1, col2width+e.PageBounds.Width - 90 * 2, e.PageBounds.Height - 50 * 2);

            //e.Graphics.DrawString("تاريخ البيع", f, Brushes.Black, col3width + e.PageBounds.Width - 100 * 2, 260);
            //e.Graphics.DrawLine(Pens.Black, col3width + e.PageBounds.Width - 110 * 2, heights_all1, col3width + e.PageBounds.Width - 110 * 2, e.PageBounds.Height - 50 * 2);

            e.Graphics.DrawString("عدد النتجات", f, Brushes.Black, col4width+ e.PageBounds.Width - 120 * 2, 260);
            e.Graphics.DrawLine(Pens.Black, col4width+ e.PageBounds.Width - 130 * 2, heights_all1, col4width+ e.PageBounds.Width - 130 * 2, e.PageBounds.Height - 50 * 2);

            e.Graphics.DrawString("السعر", f, Brushes.Black, col5width+ e.PageBounds.Width - 140 * 2, 260);
            e.Graphics.DrawLine(Pens.Black, col5width+ e.PageBounds.Width - 150 * 2, heights_all1, col5width+ e.PageBounds.Width - 150 * 2, e.PageBounds.Height - 50 * 2);

            e.Graphics.DrawString("حالة الدفع", f, Brushes.Black, col6width+ e.PageBounds.Width - 160 * 2, 260);
            //  e.Graphics.DrawLine(Pens.Black, col6width+ e.PageBounds.Width - 170 * 2, heights_all1, col6width+ e.PageBounds.Width - 170 * 2, e.PageBounds.Height - 50 * 2);

            ///////////////////////////////////////////////////////
            
            
            float rowheight = 85;

            // تأكد أن لديك using المناسبة


            // افتراضيًا، نفترض أن gridView2 هو اسم GridView الذي تستخدمه في GridControl
            GridView gridView2 = gridControl2.MainView as GridView;

            // استخدم خاصية RowCount للوصول إلى عدد الصفوف في GridView
            int rowCount = gridView2.RowCount;

            // الآن يمكنك استخدام rowCount في حلقة الـ for كما ترغب
            for (int i = 0; i < rowCount; i++)
            {
                e.Graphics.DrawString(gridView2.GetRowCellValue(i, gridView2.Columns[6]).ToString(),f,Brushes.Navy, e.PageBounds.Width-margen*2-90,heights_all1+rowheight+10);
            //    e.Graphics.DrawString(gridView2.GetRowCellValue(i, gridView2.Columns[5]).ToString(), f, Brushes.Navy, col3width-40+ e.PageBounds.Width - margen * 2 , heights_all1 + rowheight+10);
                e.Graphics.DrawString(gridView2.GetRowCellValue(i, gridView2.Columns[3]).ToString(), f, Brushes.Navy, col5width - 85 + e.PageBounds.Width - margen * 2, heights_all1 + rowheight+10);
                e.Graphics.DrawString(gridView2.GetRowCellValue(i, gridView2.Columns[2]).ToString(), f, Brushes.Navy, col6width - 130 + e.PageBounds.Width - margen * 2, heights_all1 + rowheight+10);
                e.Graphics.DrawString(gridView2.GetRowCellValue(i, gridView2.Columns[1]).ToString(), f, Brushes.Navy, col6width -250 + e.PageBounds.Width - margen * 2, heights_all1 + rowheight+10);

                rowheight += 45;
                e.Graphics.DrawLine(Pens.Black, col1heiheight, heights_all1 + rowheight, e.PageBounds.Width - 50, heights_all1 + rowheight);

            }

            e.Graphics.DrawString(str_all_total, f, Brushes.Black, col6width - 130 + e.PageBounds.Width - margen * 2, e.PageBounds.Height - 50 * 2 +30);



        }
    }
}