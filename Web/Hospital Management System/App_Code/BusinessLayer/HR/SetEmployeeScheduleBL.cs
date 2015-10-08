using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SetEmployeeScheduleBL
/// </summary>
public class SetEmployeeScheduleBL
{
	public void SetEmployeeSchedule(int empId, string monSess1From, string monSess1To,
        string monSess2From, string monSess2To, string monSess3From, string monSess3To,
        string tueSess1From, string tueSess1To, string tueSess2From, string tueSess2To,
        string tueSess3From, string tueSess3To, string wedSess1From, string wedSess1To,
        string wedSess2From, string wedSess2To, string wedSess3From, string wedSess3To,
        string thuSess1From, string thuSess1To, string thuSess2From, string thuSess2To,
        string thuSess3From, string thuSess3To, string friSess1From, string friSess1To,
        string friSess2From, string friSess2To, string friSess3From, string friSess3To,
        string satSess1From, string satSess1To, string satSess2From, string satSess2To,
        string satSess3From, string satSess3To, string sunSess1From, string sunSess1To,
        string sunSess2From, string sunSess2To, string sunSess3From, string sunSess3To)
	{
        SetEmployeeScheduleBO objSetEmployeeScheduleBO=new SetEmployeeScheduleBO();
        objSetEmployeeScheduleBO.empId = empId;
        objSetEmployeeScheduleBO.monSess1From = monSess1From;
        objSetEmployeeScheduleBO.monSess1To = monSess1To;
        objSetEmployeeScheduleBO.monSess2From = monSess2From;
        objSetEmployeeScheduleBO.monSess2To = monSess2To;
        objSetEmployeeScheduleBO.monSess3From = monSess3From;
        objSetEmployeeScheduleBO.monSess3To = monSess3To;
        objSetEmployeeScheduleBO.tueSess1From = tueSess1From;
        objSetEmployeeScheduleBO.tueSess1To = tueSess1To;
        objSetEmployeeScheduleBO.tueSess2From = tueSess2From;
        objSetEmployeeScheduleBO.tueSess2To = tueSess2To;
        objSetEmployeeScheduleBO.tueSess3From = tueSess3From;
        objSetEmployeeScheduleBO.tueSess3To = tueSess3To;
        objSetEmployeeScheduleBO.wedSess1From = wedSess1From;
        objSetEmployeeScheduleBO.wedSess1To = wedSess1To;
        objSetEmployeeScheduleBO.wedSess2From = wedSess2From;
        objSetEmployeeScheduleBO.wedSess2To = wedSess2To;
        objSetEmployeeScheduleBO.wedSess3From = wedSess3From;
        objSetEmployeeScheduleBO.wedSess3To = wedSess3To;
        objSetEmployeeScheduleBO.thuSess1From = thuSess1From;
        objSetEmployeeScheduleBO.thuSess1To = thuSess1To;
        objSetEmployeeScheduleBO.thuSess2From = thuSess2From;
        objSetEmployeeScheduleBO.thuSess2To = thuSess2To;
        objSetEmployeeScheduleBO.thuSess3From = thuSess3From;
        objSetEmployeeScheduleBO.thuSess3To = thuSess3To;
        objSetEmployeeScheduleBO.friSess1From = friSess1From;
        objSetEmployeeScheduleBO.friSess1To = friSess1To;
        objSetEmployeeScheduleBO.friSess2From = friSess2From;
        objSetEmployeeScheduleBO.friSess2To = friSess2To;
        objSetEmployeeScheduleBO.friSess3From = friSess3From;
        objSetEmployeeScheduleBO.friSess3To = friSess3To;
        objSetEmployeeScheduleBO.satSess1From = satSess1From;
        objSetEmployeeScheduleBO.satSess1To = satSess1To;
        objSetEmployeeScheduleBO.satSess2From = satSess2From;
        objSetEmployeeScheduleBO.satSess2To = satSess2To;
        objSetEmployeeScheduleBO.satSess3From = satSess3From;
        objSetEmployeeScheduleBO.satSess3To = satSess3To;
        objSetEmployeeScheduleBO.sunSess1From = sunSess1From;
        objSetEmployeeScheduleBO.sunSess1To = sunSess1To;
        objSetEmployeeScheduleBO.sunSess2From = sunSess2From;
        objSetEmployeeScheduleBO.sunSess2To = sunSess2To;
        objSetEmployeeScheduleBO.sunSess3From = sunSess3From;
        objSetEmployeeScheduleBO.sunSess3To = sunSess3To;
	}
}