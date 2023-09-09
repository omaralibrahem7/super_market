using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.DataSet1TableAdapters;

namespace supermarket.CLASESS
{
    class cls_sa_list
    {
        public static int sal_list_id;
        public static int cust_id;
        public static int pro_id;
        public static string sal_list_note;

        public static sal_listTableAdapter sal_list_data = new sal_listTableAdapter();
        public DataTable datalist()
        {
            DataTable dt = new DataTable();
            dt = sal_list_data.select_cust_pro();
            return dt;
        }
    }
}
