using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.DataSet1TableAdapters;

namespace supermarket.CLASESS
{
    class cls_sales
    {
        public static int sal_id;
        public static int sal_code;
        public static string sal_req;
        public static string sal_push_stat;
        public static int sal_price;
        public static int sal_number;
        public static string sal_date;
        public static string sal_time;
        public static string sal_cust_name;
        public static string sal_cusl_phon;
        public static string sal_addes;
        public static int pro_id;

        public static sales_tblTableAdapter sales_data = new sales_tblTableAdapter();

        public DataTable datalist()
        {
            DataTable dt = new DataTable();
            dt = sales_data.GetData();
            return dt;
        }

        public DataTable select_data()
        {
            DataTable dt = new DataTable();
            dt = sales_data.selec_sal();
            if (dt.Rows.Count > 0)
            {
                sal_id = Convert.ToInt32(dt.Rows[0][0].ToString());
               sal_code = Convert.ToInt32(dt.Rows[0][1].ToString());
                sal_req= dt.Rows[0][2].ToString();
                sal_push_stat = dt.Rows[0][3].ToString();
                sal_price = Convert.ToInt32(dt.Rows[0][4].ToString());
                sal_number = Convert.ToInt32(dt.Rows[0][5].ToString());
                sal_date = dt.Rows[0][6].ToString();
                sal_time = dt.Rows[0][7].ToString();
                sal_cust_name = dt.Rows[0][8].ToString();
                sal_cusl_phon = dt.Rows[0][9].ToString();
                sal_addes = dt.Rows[0][10].ToString();
                pro_id = Convert.ToInt32(dt.Rows[0][11].ToString());
            }
            return dt;
        }
        public DataTable sum1()
        {
            DataTable dt = new DataTable();
            dt = sales_data.sum_price();
            return dt;
        }


        public DataTable select_data_BY_DELETE(string S_PRO)
        {
            DataTable dt = new DataTable();
            dt = sales_data.GetData_BY_DELET(S_PRO);
            if (dt.Rows.Count > 0)
            {
                sal_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                sal_code = Convert.ToInt32(dt.Rows[0][1].ToString());
                sal_req = dt.Rows[0][2].ToString();
                sal_push_stat = dt.Rows[0][3].ToString();
                sal_price = Convert.ToInt32(dt.Rows[0][4].ToString());
                sal_number = Convert.ToInt32(dt.Rows[0][5].ToString());
                sal_date = dt.Rows[0][6].ToString();
                sal_time = dt.Rows[0][7].ToString();
                sal_cust_name = dt.Rows[0][8].ToString();
                sal_cusl_phon = dt.Rows[0][9].ToString();
                sal_addes = dt.Rows[0][10].ToString();
                pro_id = Convert.ToInt32(dt.Rows[0][11].ToString());
            }
            return dt;
        }


    }
}
