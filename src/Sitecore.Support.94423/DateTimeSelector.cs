namespace Sitecore.Support.Shell.Applications.Dialogs.DateTimeSelectors
{
  using Sitecore;
  using Sitecore.Web;
  using Sitecore.Web.UI.HtmlControls;
  using Sitecore.Web.UI.Pages;
  using Sitecore.Web.UI.Sheer;
  using System;
  using System.Runtime.CompilerServices;

  internal class DateTimeSelector : DialogForm
  {
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if (!Context.ClientPage.IsEvent)
      {
        string rawUrl = Context.RawUrl;
        string queryString = WebUtil.GetQueryString("value");
        //The fix: use the selected date instead of the current one
        if (!string.IsNullOrEmpty(queryString))
        {
          this.Date.Value = DateUtil.IsoDateToServerTimeIsoDate(queryString);
        }
        else
        {
          this.Date.Value = DateUtil.IsoDateToServerTimeIsoDate(DateUtil.IsoNow);
        }
      }
    }

    protected override void OnOK(object sender, EventArgs args)
    {
      SheerResponse.SetDialogValue(this.Date.Value);
      base.OnOK(sender, args);
    }

    protected DateTimePicker Date { get; set; }
  }
}
