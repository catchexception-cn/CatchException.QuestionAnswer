using Volo.Abp.Reflection;

namespace CatchException.QuestionAnswer.Permissions;

public class QuestionAnswerPermissions
{
    public const string GroupName = "QuestionAnswer";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(QuestionAnswerPermissions));
    }
}
