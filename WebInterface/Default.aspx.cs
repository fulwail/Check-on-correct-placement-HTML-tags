using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataService;
using DataService.Model;
using WebInterface.Models;

namespace WebInterface
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var data = new DataServiceContext();
            ListViewResult.DataSource = data.GetChekingResult().Select(x => new ResultOfCheckingViewModel
            {
                Id = x.Id,
                DateTime = x.DateTime.ToShortDateString(),
                Result = x.Result,
                CountToken = x.CountToken
            });
            ListViewResult.DataBind();
        }

       
    }
}