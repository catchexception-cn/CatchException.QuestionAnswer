using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace CatchException.QuestionAnswer.Pages;

public class IndexModel : QuestionAnswerPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
