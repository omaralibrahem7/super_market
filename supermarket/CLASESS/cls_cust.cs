using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.DataSet1TableAdapters;

namespace supermarket.CLASESS
{
    class cls_cust
    {
        public static int cust_id;
        public static string sal_cust_name;
        public static string sal_cusl_phon;
        public static string sal_addes;
        public static int sal_id;

        public static cust_tbl1TableAdapter cust_data = new cust_tbl1TableAdapter();


        public DataTable datalist()
        {
            DataTable DT = new DataTable();
            DT = cust_data.GetData();
            return DT;
        }

        public DataTable select_data(string s_cust_name)
        {
            DataTable dt = new DataTable();
            dt = cust_data.select_data_by_name(s_cust_name);
            
            
                if (dt.Rows.Count > 0)
                {
                    cust_id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString());
                    sal_cust_name = dt.Rows[dt.Rows.Count-1][1].ToString();
                    sal_cusl_phon = dt.Rows[dt.Rows.Count-1][2].ToString();
                    sal_addes = dt.Rows[dt.Rows.Count - 1][3].ToString();
                   // sal_id = Convert.ToInt32(dt.Rows[dt.Rows.Count][4].ToString());
                }
             
            return dt;
        }
    }
}
