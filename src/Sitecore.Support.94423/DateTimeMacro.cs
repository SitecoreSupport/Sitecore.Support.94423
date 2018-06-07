namespace Sitecore.Rules.RuleMacros
{
  using Sitecore;
  using Sitecore.Diagnostics;
  using Sitecore.Text;
  using Sitecore.Web.UI.Sheer;
  using System.Xml.Linq;

  public class DateTimeMacro : IRuleMacro
  {
    public void Execute(XElement element, string name, UrlString parameters, string value)
    {
      Assert.ArgumentNotNull(element, "element");
      Assert.ArgumentNotNull(name, "name");
      Assert.ArgumentNotNull(parameters, "parameters");
      Assert.ArgumentNotNull(value, "value");
      SheerResponse.ShowModalDialog(new UrlString(UIUtil.GetUri("control:Sitecore.Shell.Applications.Dialogs.DateTimeSelector")).ToString(), "580px", "475px", string.Empty, true);
    }
  }
}
