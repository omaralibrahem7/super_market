using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.DataSet1TableAdapters;

namespace supermarket.CLASESS
{
    class cls_category
    {
        public static int cat_id;
        public static string cat_name;
        public static string cat_description;

        public static category_tblTableAdapter data_cat = new category_tblTableAdapter();

        public DataTable cat_list()
        {
            DataTable dt = new DataTable();
            dt = data_cat.GetData();
            return dt;
        }

        public DataTable select_data(string s_cat_name)
        {
            
            DataTable dt = new DataTable();
            dt = data_cat.getdata_by_name(s_cat_name);
            if (dt.Rows.Count>0)
            {
                cat_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                cat_name = dt.Rows[0][1].ToString();
                cat_description = dt.Rows[0][2].ToString();
            }
            
            return dt;
        }


    }
}
