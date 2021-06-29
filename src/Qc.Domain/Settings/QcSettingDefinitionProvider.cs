using Volo.Abp.Settings;

namespace Qc.Settings
{
    public class QcSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(QcSettings.MySetting1));
        }
    }
}
