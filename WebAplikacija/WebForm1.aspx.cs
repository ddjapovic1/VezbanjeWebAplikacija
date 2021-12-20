using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAplikacija
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AutoBusiness ab = new AutoBusiness();
            List<Automobil> al = ab.GetAutomobilis();
            foreach (Automobil a in al)
            {
                ListBox1.Items.Add(a.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AutoBusiness ab = new AutoBusiness();
            Automobil a = new Automobil(1, TextBox1.Text, Convert.ToInt32(TextBox2.Text), Convert.ToDecimal(TextBox3.Text), Convert.ToInt32(TextBox4.Text));
            bool result = ab.insertAuto(a);
            ListBox1.Items.Clear();
            Page_Load(null, null);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            AutoBusiness ab = new AutoBusiness();
            List<Automobil> al = ab.jeftinijeOd(Convert.ToInt32(TextBox5.Text));
            foreach (Automobil a in al)
            {
                ListBox2.Items.Add(a.ToString());
            }



        }
    }
}