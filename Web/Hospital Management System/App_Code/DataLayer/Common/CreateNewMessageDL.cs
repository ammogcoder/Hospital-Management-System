using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for CreateNewMessageDL
/// </summary>
public class CreateNewMessageDL
{
    public void CreateNewMessage(CreateNewMessageBO objCreateMessageBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spCreateNewMessage", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@senderId", objCreateMessageBO.senderId);
        cmd.Parameters.Add("@receiverId", objCreateMessageBO.receiverId);
        cmd.Parameters.Add("@messageSubject", objCreateMessageBO.messageSubject);
        cmd.Parameters.Add("@messageContent", objCreateMessageBO.messageContent);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}