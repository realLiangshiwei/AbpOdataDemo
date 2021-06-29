using Qc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qc.Permissions
{
    public class QcPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(QcPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(QcPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<QcResource>(name);
        }
    }
}
