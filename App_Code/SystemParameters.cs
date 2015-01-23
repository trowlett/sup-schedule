﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for SystemParameters
/// </summary>
public class SystemParameters
{
    public const string ScheduleDate = "ScheduleDate";


	public SystemParameters()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static void Update(string club, string key, string value)
    {
        


        MrTimeZone etz = new MrTimeZone();
        string MRMISGADBConn = ConfigurationManager.ConnectionStrings["MRMISGADBConnect"].ToString();
        MRMISGADB db = new MRMISGADB(MRMISGADBConn);
        SysParams entry = db.SysParams.FirstOrDefault(p => ((p.ClubID == club) && (p.Key.Trim() == key)));
        if (entry != null)
        {
            entry.Value = value;
            entry.ChangeDate = etz.eastTimeNow();
        }
        else
        {
            SysParams sp = new SysParams
            {
                ClubID = club,
                Key = key,
                Value = value,
                ChangeDate = etz.eastTimeNow()
            };
            db.SysParams.InsertOnSubmit(sp);
        }
        db.SubmitChanges();
    }
    public static string Get(string club, string key)
    {
        string MRMISGADBConn = ConfigurationManager.ConnectionStrings["MRMISGADBConnect"].ToString();
        MRMISGADB db = new MRMISGADB(MRMISGADBConn);
        SysParams entry = db.SysParams.FirstOrDefault(p => ((p.ClubID == club) && (p.Key.Trim() == key)));
        if (entry == null)
        {
            return string.Format("No {0} entry", key);
        }
        else
        {
            return entry.Value;
        }
    }
}