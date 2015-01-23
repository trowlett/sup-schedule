using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

/// <summary>
/// Summary description for ClubSettings
/// </summary>
/// 
[Table(Name = "ClubSettings")]
public class ClubSettings
{
    [Column(IsPrimaryKey = true)]
    public string ClubID;
    [Column]
    public string Active;
    [Column]
    public string OrgName;
    [Column]
    public string OrgURL;
    [Column]
    public string WebSiteName;
    [Column]
    public string Website;
    [Column]
    public string WebMaster;
    [Column]
    public string WebMasterEmail;
    [Column]
    public string Signups;
    [Column]
    public string AccessControl;
    [Column]
    public string ControlCode;

	public ClubSettings()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}