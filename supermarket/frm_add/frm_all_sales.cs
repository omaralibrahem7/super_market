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
    public partial class frm_all_sales : DevExpress.XtraEditors.XtraForm
    {
        public frm_all_sales()
        {
            InitializeComponent();
        }
        CLASESS.cls_sa_list ncls = new CLASESS.cls_sa_list();
        private void frm_all_sales_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ncls.datalist();
        }
    }
}