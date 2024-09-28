using Volo.Abp.Settings;

namespace Acme.QLSV.Settings;

public class QLSVSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(QLSVSettings.MySetting1));
    }
}
