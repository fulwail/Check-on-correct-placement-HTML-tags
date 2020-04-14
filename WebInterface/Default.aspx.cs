using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqlDatabase;
using CheckOnCorrectPlacement;

namespace WebInterface
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataService<ResultOfChecking> data = new DataService<ResultOfChecking>();
            var results = data.GetChekingResult().Select(x => new ResultOfChecking
            {
                Id = x.Id,
                DateTime = x.DateTime,
                Result = x.Result,
                CountToken = x.CountToken
            });
            ListWiewResult.DataSource = data.GetChekingResult();
            ListWiewResult.DataBind();
        }

       
    }
}