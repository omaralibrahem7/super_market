using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.DataSet1TableAdapters;

namespace supermarket.CLASESS
{
    class cls_project
    {
        public static int pro_id;
        public static string pro_name;
        public static string pro_price;
        public static string pro_quantity;
        public static string pro_company;
        public static int cat_id;

        public static project_tblTableAdapter pro_data = new project_tblTableAdapter();

        public DataTable data_list()
        {
            DataTable dt = new DataTable();
            dt = pro_data.getdata_2();
            return dt;
        }
        public DataTable select_data(string s_project_name) 
        {
            DataTable dt = new DataTable();
            dt = pro_data.select_data_by_name(s_project_name);
            if (dt.Rows.Count>0)
            {
                pro_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                pro_name = dt.Rows[0][1].ToString();
                pro_price = dt.Rows[0][2].ToString();
                pro_quantity = dt.Rows[0][3].ToString();
                pro_company = dt.Rows[0][4].ToString();
                cat_id = Convert.ToInt32(dt.Rows[0][5].ToString());
            }
          
            return dt;

        }
        public DataTable select_sales()
        {
            DataTable dt = new DataTable();
            dt = pro_data.selectpro_by_sales();
            if (dt.Rows.Count > 0)
            {
                pro_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                pro_name = dt.Rows[0][1].ToString();
                pro_price = dt.Rows[0][2].ToString();
                pro_quantity = dt.Rows[0][3].ToString();
                cat_id = Convert.ToInt32(dt.Rows[0][5].ToString());
            }

            return dt;

        }
    }
}
