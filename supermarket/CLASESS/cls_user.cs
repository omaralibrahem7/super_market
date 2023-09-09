using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.DataSet1TableAdapters;

namespace supermarket.CLASESS
{
    class cls_user
    {
        public static int user_id;
        public static string user_name;
        public static string user_password;

        public static USER_TBLTableAdapter user_tabel = new USER_TBLTableAdapter();


        public DataTable login(string s_user_name ,string s_user_password)
        {
            DataTable dt = new DataTable();
            dt =user_tabel.user_log_in_by_user(s_user_name, s_user_password);

            if (dt.Rows.Count > 0)
            {
                CLASESS.cls_user.user_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                CLASESS.cls_user.user_name = dt.Rows[0][1].ToString();
                CLASESS.cls_user.user_password = dt.Rows[0][2].ToString();
               
            }
            return dt;
            
        }
    



    }
}
