using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistAllWardDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            DropDownList1.Items.Add(new ListItem("--Select--", "0"));
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int wardId = Convert.ToInt32(DropDownList1.SelectedValue);
        GetWardNumberBL objGetWardNumberBL = new GetWardNumberBL();
        DataSet ds = new DataSet();
        ds = objGetWardNumberBL.GetWardNumber(wardId);
        switch (wardId)
        {
            case 1:
                ds = objGetWardNumberBL.GetWardNumber(wardId);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int emptyWardNumber = Convert.ToInt32(ds.Tables[0].Rows[i]["WARD_NUMBER"].ToString());
                    int rows = (emptyWardNumber - 100) / 6;
                    int x = ((emptyWardNumber - 1) % 100);
                    Table1.Rows[rows].Cells[x%5].BackColor = System.Drawing.Color.LightGreen;
                }
                MultiView1.ActiveViewIndex = 0;
                break;

            case 3:
                ds = objGetWardNumberBL.GetWardNumber(3);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int emptyWardNumber = Convert.ToInt32(ds.Tables[0].Rows[i]["WARD_NUMBER"].ToString());
                    int rows = (emptyWardNumber - 200) / 6;
                    int x = ((emptyWardNumber - 1) % 200);
                    Table2.Rows[rows].Cells[x%5].BackColor = System.Drawing.Color.LightGreen;
                }
                MultiView1.ActiveViewIndex = 1;
                break;

            case 4:
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int emptyWardNumber = Convert.ToInt32(ds.Tables[0].Rows[i]["WARD_NUMBER"].ToString());
                    int rows = (emptyWardNumber - 300)/6;
                    int x = ((emptyWardNumber - 1) % 300);
                    Table3.Rows[rows].Cells[x % 5].BackColor = System.Drawing.Color.LightGreen;
                }
                MultiView1.ActiveViewIndex = 2;
                break;

            case 5:
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int emptyWardNumber = Convert.ToInt32(ds.Tables[0].Rows[i]["WARD_NUMBER"].ToString());
                    int rows = (emptyWardNumber - 400) / 6;
                    int x = ((emptyWardNumber - 1) % 400);
                    Table4.Rows[rows].Cells[x % 5].BackColor = System.Drawing.Color.LightGreen;
                }
                MultiView1.ActiveViewIndex = 3;
                break;

            case 6:
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int emptyWardNumber = Convert.ToInt32(ds.Tables[0].Rows[i]["WARD_NUMBER"].ToString());
                    int rows = ((emptyWardNumber - 1) % 500) /5;
                    int x = ((emptyWardNumber - 1) % 500);
                    Table5.Rows[rows].Cells[x % 5].BackColor = System.Drawing.Color.LightGreen;
                }
                MultiView1.ActiveViewIndex = 4;
                break;
        }
    }
}