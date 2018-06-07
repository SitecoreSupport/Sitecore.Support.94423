namespace Sitecore.Support.Rules.RuleMacros
{
  using Sitecore;
  using Sitecore.Diagnostics;
  using Sitecore.Rules.RuleMacros;
  using Sitecore.Text;
  using Sitecore.Web.UI.Sheer;
  using System;
  using System.Xml.Linq;

  internal class DateTimeMacro : IRuleMacro
  {
    public void Execute(XElement element, string name, UrlString parameters, string value)
    {
      Assert.ArgumentNotNull(element, "element");
      Assert.ArgumentNotNull(name, "name");
      Assert.ArgumentNotNull(parameters, "parameters");
      Assert.ArgumentNotNull(value, "value");
      UrlString str = new UrlString(UIUtil.GetUri("control:Sitecore.Shell.Applications.Dialogs.DateTimeSelector"));
      str["value"] = value;
      SheerResponse.ShowModalDialog(str.ToString(), "580px", "475px", string.Empty, true);
    }
  }
}
