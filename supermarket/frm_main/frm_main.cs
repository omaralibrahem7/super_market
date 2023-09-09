using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace supermarket.frm_main
{
    public partial class frm_main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
           }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
          
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
           
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
          
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
           
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            main_item frm_sal = new main_item();
            frm_sal.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_sal);
            frm_sal.FormBorderStyle = FormBorderStyle.None;
            frm_sal.Dock = DockStyle.Fill;
            frm_sal.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_add.frm_project_add frm_pro = new frm_add.frm_project_add();
            frm_pro.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_pro);
            frm_pro.FormBorderStyle = FormBorderStyle.None;
            frm_pro.Dock = DockStyle.Fill;
            frm_pro.Show();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_add.category_add frm_cat = new frm_add.category_add();
            frm_cat.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_cat);
            frm_cat.FormBorderStyle = FormBorderStyle.None;
            frm_cat.Dock = DockStyle.Fill;
            frm_cat.Show();
        }

        private void accordionControlElement6_Click_1(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_add.frm_sales_add frm_sal = new frm_add.frm_sales_add();
            frm_sal.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_sal);
            frm_sal.FormBorderStyle = FormBorderStyle.None;
            frm_sal.Dock = DockStyle.Fill;
            frm_sal.Show();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_add.frm_inv frm_sal = new frm_add.frm_inv();
            frm_sal.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_sal);
            frm_sal.FormBorderStyle = FormBorderStyle.None;
            frm_sal.Dock = DockStyle.Fill;
            frm_sal.Show();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_add.frm_loan frm_sal = new frm_add.frm_loan();
            frm_sal.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_sal);
            frm_sal.FormBorderStyle = FormBorderStyle.None;
            frm_sal.Dock = DockStyle.Fill;
            frm_sal.Show();
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_add.we_me frm_req = new frm_add.we_me();
            frm_req.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_req);
            frm_req.FormBorderStyle = FormBorderStyle.None;
            frm_req.Dock = DockStyle.Fill;
            frm_req.Show();

        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            main_item frm_sal = new main_item();
            frm_sal.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_sal);
            frm_sal.FormBorderStyle = FormBorderStyle.None;
            frm_sal.Dock = DockStyle.Fill;
            frm_sal.Show();
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_add.frm_all_sales frm_sal = new frm_add.frm_all_sales();
            frm_sal.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm_sal);
            frm_sal.FormBorderStyle = FormBorderStyle.None;
            frm_sal.Dock = DockStyle.Fill;
            frm_sal.Show();
        }
    }
}
