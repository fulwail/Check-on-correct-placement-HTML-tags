using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoMapper;
using DataService;
using DataService.Model;

namespace WebInterface
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var data = new DataServiceContext();
            var source = data.GetChekingResult().Select(x => Mapper.Map<ResultOfCheckingDto>(x));
            var result = Mapper.Map<IEnumerable<ResultOfCheckingDto>, IEnumerable<ResultOfCheckingViewModel>> (source);
            ListViewResult.DataSource = result;
            ListViewResult.DataBind();
        }
    }
}
