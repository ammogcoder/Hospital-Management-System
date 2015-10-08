using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetRoomDetailsDL
/// </summary>
public class GetRoomDetailsDL
{
    public DataSet GetRoomDetails(GetRoomDetailsBO objGetRoomDetailsBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetRoomDetails", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@wardId", objGetRoomDetailsBO.wardId);
        cmd.Parameters.Add("@wardNumber", objGetRoomDetailsBO.wardNumber);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}