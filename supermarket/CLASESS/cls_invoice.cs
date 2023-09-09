using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.DataSet1TableAdapters;

namespace supermarket.CLASESS
{
    class cls_invoice
    {
        public static int inv_id;
        public static string inv_date;
        public static string inv_time;
        public static int inv_total;
        public static string inv_stat;
        public static string inv_note;
        public static int pro_id;
        public static invoice_tblTableAdapter inv_data = new invoice_tblTableAdapter();

        public DataTable datalist()
        {
            DataTable dt = new DataTable();
            dt = inv_data.GetData();
            return dt;
        }

        public DataTable select_data_inse(string nite,string cust)
        {
            DataTable dt = new DataTable();
            dt = inv_data.selectall_data(nite, cust);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows.Count > 0)
                {
                    inv_id = Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0].ToString());
                }
            }
           

            return dt;
        }
        public DataTable select_data(string nite, string cust)
        {
            DataTable dt = new DataTable();
            dt = inv_data.selectall_data(nite, cust);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows.Count > 0)
                {
                    inv_id = Convert.ToInt32(dt.Rows[0]["inv_id"].ToString());
                    inv_date = dt.Rows[0][1].ToString();
                    inv_time = dt.Rows[0][2].ToString();
                    inv_total = Convert.ToInt32(dt.Rows[0][3].ToString());
                    inv_stat = dt.Rows[0][4].ToString();
                    inv_note = dt.Rows[0][5].ToString();
                    pro_id = Convert.ToInt32(dt.Rows[0][6].ToString());
                }
            }


            return dt;
        }
        public DataTable select_req()
        {
            DataTable dt = new DataTable();
            dt = inv_data.selec_reuast();
            if (dt.Rows.Count > 0)
            {
                inv_id = Convert.ToInt32(dt.Rows[0]["inv_id"].ToString());
                inv_date = dt.Rows[0][1].ToString();
                inv_time = dt.Rows[0][2].ToString();
                inv_total = Convert.ToInt32(dt.Rows[0][3].ToString());
                inv_stat = dt.Rows[0][4].ToString();
                inv_note = dt.Rows[0][5].ToString();
                pro_id = Convert.ToInt32(dt.Rows[0][6].ToString());
            }
            return dt;
        }
    }
}
