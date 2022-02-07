using ClientDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientDemo
{
    public partial class WebFormMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ClientValue> list = ClientDB.GetAllClients();
            gvClients.DataSource = list;
            gvClients.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}