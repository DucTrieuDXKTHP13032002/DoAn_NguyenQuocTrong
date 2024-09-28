using Acme.QLSV.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.QLSV.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class QLSVController : AbpControllerBase
{
    protected QLSVController()
    {
        LocalizationResource = typeof(QLSVResource);
    }
}
