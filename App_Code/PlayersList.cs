using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

/// <summary>
/// Summary description for PlayersList
/// </summary>
[Table(Name = "PLayersList")]
public class PlayersList
{
    [Column(IsPrimaryKey = true)]
    public string ClubID;
    [Column(IsPrimaryKey = true)]
    public String EventID;
    [Column(IsPrimaryKey=true)]
    public int PlayerID;
    [Column]
    public DateTime TransDate;
    [Column]
    public string Action;
    [Column]
    public string Carpool;
    [Column]
    public int Marked;
    [Column]
    public string SpecialRule;
    [Column]
    public int GuestID;
}