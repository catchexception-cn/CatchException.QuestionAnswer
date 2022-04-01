using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace CatchException.QuestionAnswer.Answerers;

public class Answerer : FullAuditedAggregateRoot<Guid>, IUser, IUpdateUserData
{
    public string Name { get; private set; } = default!;

    public string Title { get; private set; } = default!;

    public string Introduction { get; private set; } = default!;

    public string Avatar { get; private set; } = default!;

    public string AvatarUrl { get; private set; } = default!;

    public string DonationImageUrl { get; private set; } = default!;

    public Answerer(
        Guid id,
        string name) : base(id)
    {
        SetName(name);
        SetTitle(string.Empty);
        SetIntroduction(string.Empty);
        SetAvatar(string.Empty, string.Empty);
    }

    public Answerer SetName(string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name), AnswererConsts.MaxNameLength);

        return this;
    }

    public Answerer SetTitle(string title)
    {
        Title = Check.NotNull(title, nameof(title), AnswererConsts.MaxTitleLength);

        return this;
    }

    public Answerer SetIntroduction(string introduction)
    {
        Introduction = Check.NotNull(introduction, nameof(introduction),
            AnswererConsts.MaxIntroductionLength);

        return this;
    }

    public Answerer SetAvatar(string avatar, string avatarUrl)
    {
        Avatar = Check.NotNull(avatar, nameof(avatar), AnswererConsts.MaxAvatarNameLength);
        AvatarUrl = Check.NotNull(avatarUrl, nameof(avatarUrl), AnswererConsts.MaxAvatarUrlLength);

        return this;
    }

    public Answerer SetDonationImageUrl(string url)
    {
        DonationImageUrl = Check.NotNullOrWhiteSpace(url, nameof(url), AnswererConsts.MaxDonationImageUrlLength);

        return this;
    }
}