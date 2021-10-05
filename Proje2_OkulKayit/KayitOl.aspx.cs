using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje2_OkulKayit
{
    public partial class KayitOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRENCITableAdapter dt = new DataSet1TableAdapters.TBLOGRENCITableAdapter();
            dt.OgrenciEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
        }
    }
}