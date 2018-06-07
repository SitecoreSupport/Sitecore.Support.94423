namespace Sitecore.Shell.Applications.Dialogs.DateTimeSelectors
{
  using Sitecore;
  using Sitecore.Web.UI.HtmlControls;
  using Sitecore.Web.UI.Pages;
  using Sitecore.Web.UI.Sheer;
  using System;
  using System.Runtime.CompilerServices;

  public class DateTimeSelector : DialogForm
  {
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if (!Context.ClientPage.IsEvent)
      {
        this.Date.Value = DateUtil.IsoDateToServerTimeIsoDate(DateUtil.IsoNow);
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
