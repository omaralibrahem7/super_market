using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace supermarket
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        CLASESS.cls_user ncls_user = new CLASESS.cls_user();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = CLASESS.cls_user.user_tabel.GetData();
            comboBox1.ValueMember = "USER_NAME";
           
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            ncls_user.login(comboBox1.Text, txt_userpass.Text);

            if (CLASESS.cls_user.user_id == 0)
            {
                MessageBox.Show("خطأ");

            }
            else
            {
                frm_main.frm_main main = new frm_main.frm_main();
                main.Show();
            }
        }
    

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
