using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater3.DataBind();
        }
    }
}