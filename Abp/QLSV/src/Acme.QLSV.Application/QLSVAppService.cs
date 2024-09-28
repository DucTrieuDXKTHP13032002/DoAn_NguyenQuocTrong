using Acme.QLSV.Localization;
using Volo.Abp.Application.Services;

namespace Acme.QLSV;

/* Inherit your application services from this class.
 */
public abstract class QLSVAppService : ApplicationService
{
    protected QLSVAppService()
    {
        LocalizationResource = typeof(QLSVResource);
    }
}
