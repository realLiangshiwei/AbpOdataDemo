using Volo.Abp.Settings;

namespace AbpOdataDemo.Settings
{
    public class AbpOdataDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpOdataDemoSettings.MySetting1));
        }
    }
}
