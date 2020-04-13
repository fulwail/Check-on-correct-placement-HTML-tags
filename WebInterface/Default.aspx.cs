using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBCheckedTestCase;

namespace WebInterface
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DaraService data = new DaraService();
            data.ReadDatabase(); ;
            ListWiewResult.DataSource = data.results;
            ListWiewResult.DataBind();
        }
    }
}