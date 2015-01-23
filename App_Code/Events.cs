using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

/// <summary>
/// Summary description for Schedule
/// </summary>

[Table(Name="Events")]
public class Events
{
    [Column(IsPrimaryKey = true)]
    public string ClubID;
    [Column(IsPrimaryKey = true)]
    public string EventID;
    [Column]
    public DateTime Date;
    [Column]
    public string HostID;
    [Column]
    public string Type;
    [Column]
    public string Title;
    [Column]
    public string Cost;
    [Column]
    public int PlayerLimit;
    [Column]
    public DateTime Deadline;
    [Column]
    public DateTime PostDate;
    [Column]
    public string HostPhone;
    [Column]
    public string SpecialRule;
    [Column]
    public string Guest;
    [Column]
    public DateTime CreationDate;
}