using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
//    protected string OrgURL { get { return ConfigurationManager.AppSettings["OrgURL"]; } }
//    protected string HdrImageUrl { get { return ConfigurationManager.AppSettings["HeaderImageURL"]; } }

    public Settings clubSettings { get; set; }


    protected void Page_Load(object sender, EventArgs e)
    {
        Settings clubSettings = new Settings();
        this.clubSettings = (Settings)Session["Settings"];
        string schedule = "~/schedule.aspx?CLUB=" + this.clubSettings.ClubID;
        Menu1.Items[1].NavigateUrl = schedule;
        Menu2.Items[1].NavigateUrl = schedule;
        string root = "http://misga-signup.org";
        root = "http://"+this.clubSettings.ClubInfo.WebSite;
//        root = "~/Default.aspx";
        Menu1.Items[0].NavigateUrl = root;
        Menu2.Items[0].NavigateUrl = root;
    }
}
