using Acme.QLSV.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.QLSV.Web.Pages;

public abstract class QLSVPageModel : AbpPageModel
{
    protected QLSVPageModel()
    {
        LocalizationResourceType = typeof(QLSVResource);
    }
}
