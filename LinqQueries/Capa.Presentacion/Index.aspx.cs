using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa.Logica;
using Capa.Entidades.Northwind;

namespace Capa.Presentacion
{
    public partial class Index : System.Web.UI.Page
    {
        QueriesLogica queries = new QueriesLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query1();
            GridView.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query2();
            GridView.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query3();
            GridView.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query4();
            GridView.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query5();
            GridView.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query6();
            GridView.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query7();
            GridView.DataBind();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query8();
            GridView.DataBind();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query9();
            GridView.DataBind();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query10();
            GridView.DataBind();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query11();
            GridView.DataBind();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            List<Products> products = new System.Collections.Generic.List<Products>();
            products.Add(queries.Query12());
            GridView.DataSource = products;
            GridView.DataBind();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            List<Products> products = new System.Collections.Generic.List<Products>();
            products.Add(queries.Query13());
            GridView.DataSource = products;
            try
            {
                GridView.DataBind();
            }
            catch (Exception)
            {
                Button13.Text = "Error: no hay producto";
                Button13.Enabled = false;
            }
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            GridView.DataSource = queries.Query14();
            GridView.DataBind();
        }
    }
}