using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.DataSet1TableAdapters;

namespace supermarket.CLASESS
{
    class cls_load
    {
        public static int load_id;
        public static string loan_date;
        public static string loan_time;
        public static string loan_cust_anme;
        public static string loan_cust_phon;
        public static string loan_cust_addres;
        public static string loan_name_pro;
        public static int inv_id;

        public static loan_tblTableAdapter loan_data = new loan_tblTableAdapter();

        public DataTable datalist()
        {
            DataTable dt = new DataTable();
           // if (dt.Rows.Count>0)
         //   {
               // dt = loan_data.GetData();
               
         //   }
            return dt;
        }

        public DataTable select_data(string s_cust_name)
        {
            DataTable dt = new DataTable();
            dt = loan_data.select_data(s_cust_name);
           
            if (dt.Rows.Count > 0)
            {
                load_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                loan_date = dt.Rows[0][1].ToString();
                loan_time = dt.Rows[0][2].ToString();
                loan_cust_anme = dt.Rows[0][3].ToString();
                loan_cust_phon = dt.Rows[0][4].ToString();
                loan_cust_addres = dt.Rows[0][5].ToString();
                loan_name_pro = dt.Rows[0][6].ToString();
                inv_id = Convert.ToInt32(dt.Rows[0]["inv_id"].ToString());

            }
            return dt;
        }
    }
}
