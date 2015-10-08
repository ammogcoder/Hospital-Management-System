using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class css_Receptionist_ReceptionistInbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Common_GetInboxBL objGetInboxBL = new Common_GetInboxBL();
        GridView1.DataSource = objGetInboxBL.Common_GetInbox(Convert.ToInt32(Session["receptionistId"].ToString()));
        GridView1.DataBind();
    }
}