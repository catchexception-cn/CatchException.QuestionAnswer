using CatchException.QuestionAnswer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CatchException.QuestionAnswer.Permissions;

public class QuestionAnswerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(QuestionAnswerPermissions.GroupName, L("Permission:QuestionAnswer"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QuestionAnswerResource>(name);
    }
}
