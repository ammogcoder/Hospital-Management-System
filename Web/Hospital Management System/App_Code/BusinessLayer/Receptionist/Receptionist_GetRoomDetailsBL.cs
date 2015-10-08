using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetRoomDetailsBL
/// </summary>
public class GetRoomDetailsBL
{
	public DataSet GetRoomDetails(int wardId, int wardNumber)
	{
        GetRoomDetailsBO objGetRoomDetailsBO = new GetRoomDetailsBO();
        objGetRoomDetailsBO.wardId = wardId;
        objGetRoomDetailsBO.wardNumber = wardNumber;

        GetRoomDetailsDL objGetRoomDetailsDL = new GetRoomDetailsDL();
        return objGetRoomDetailsDL.GetRoomDetails(objGetRoomDetailsBO);
	}
}