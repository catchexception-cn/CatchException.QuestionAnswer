using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace CatchException.QuestionAnswer.Web.Menus;

public class QuestionAnswerMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(QuestionAnswerMenus.Prefix, displayName: "QuestionAnswer", "~/QuestionAnswer", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
