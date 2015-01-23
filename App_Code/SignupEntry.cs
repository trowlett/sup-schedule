﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SignupEntry
/// </summary>
public class SignupEntry
{
    public string ClubID { get; set; }
	public int SeqNo { get; set; }
	public DateTime STDate { get; set; }
	public string SeventId { get; set; }
	public string Splayer { get; set; }
	public string Ssex { get; set; }
	public string Shcp { get; set; }
	public string Saction { get; set; }
	public string Scarpool { get; set; }
	public int Smarked { get; set; }
	public string SspecialRule { get; set; }
	public int SGuest { get; set; }
	public string SGuestName { get; set; }
	public string SgHcp { get; set; }
	public string SgSex { get; set; }

	public SignupEntry()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}