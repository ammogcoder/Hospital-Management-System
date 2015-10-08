using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreateNewMessageBO
/// </summary>
public class CreateNewMessageBO
{
    public int senderId { get; set; }
    public string messageSubject { get; set; }
    public int receiverId { get; set; }
    public string messageContent { get; set; }
}