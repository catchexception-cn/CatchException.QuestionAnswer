using CatchException.Tagging.Tagging;

using Volo.Abp.Domain.Entities;

namespace CatchException.QuestionAnswer.Questions;

public class QuestionTag : AggregateRoot<Guid>, ITag, IUpdateTagData
{
    public string Name { get; protected set; } = default!;
    public string Description { get; protected set; } = default!;

    protected QuestionTag() { }

    public QuestionTag(ITagData tag)
        : base(tag.Id)
    {
        Name = tag.Name;
        Description = tag.Description;
    }

    public virtual bool Update(ITagData tag)
    {
        if (Id != tag.Id)
        {
            throw new ArgumentException($"Given Tag's Id '{tag.Id}' does not match to this Tag's Id '{Id}'");
        }

        if (Equals(tag))
        {
            return false;
        }

        Name = tag.Name;
        Description = tag.Description;

        return true;
    }

    protected virtual bool Equals(ITagData tag)
    {
        return Id == tag.Id &&
               Name == tag.Name &&
               Description == tag.Description;
    }
}