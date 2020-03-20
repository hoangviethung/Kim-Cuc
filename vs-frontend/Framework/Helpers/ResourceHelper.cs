using System.Web.Mvc;
using MainProject.Core.Enums;

namespace MainProject.Framework.Helpers
{
    public static class ResourceHelper
    {
        public static string GetResource(this HtmlHelper helper, ResourceKeyCollection resourceKey) => resourceKey.ToString();
    }
}
