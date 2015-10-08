using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreateNewMessageBL
/// </summary>
public class Common_CreateNewMessageBL
{
	public void Common_CreateNewMessage(int senderId, string messageSubject, int receiverId, string messageContent)
	{
        CreateNewMessageBO objCreateNewMessageBO = new CreateNewMessageBO();
        objCreateNewMessageBO.senderId = senderId;
        objCreateNewMessageBO.receiverId = receiverId;
        objCreateNewMessageBO.messageContent = messageContent;
        objCreateNewMessageBO.messageSubject = messageSubject;

        CreateNewMessageDL objCreateNewMessageDL = new CreateNewMessageDL();
        objCreateNewMessageDL.CreateNewMessage(objCreateNewMessageBO);
	}
}