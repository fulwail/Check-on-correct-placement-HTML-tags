using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransferObject;
using DataTransferObject.Model;



namespace WebInterface
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var data = new DataService();
            ListWiewResult.DataSource = data.GetChekingResult().Select(x => new ResultOfCheckingDto
            {
                Id = x.Id,
                DateTime = x.DateTime,
                Result = x.Result,
                CountToken = x.CountToken
            });
            ListWiewResult.DataBind();
        }

       
    }
}