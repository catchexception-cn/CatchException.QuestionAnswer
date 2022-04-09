using CatchException.QuestionAnswer.Answers;
using CatchException.QuestionAnswer.Comments;
using CatchException.QuestionAnswer.Questions;

using Microsoft.EntityFrameworkCore;

using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace CatchException.QuestionAnswer.EntityFrameworkCore;

public static class QuestionAnswerDbContextModelCreatingExtensions
{
    public static void ConfigureQuestionAnswer(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(QuestionAnswerDbProperties.DbTablePrefix + "Questions", QuestionAnswerDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Question>(b =>
        {
            b.ToTable(QuestionAnswerDbProperties.DbTablePrefix + "Questions", QuestionAnswerDbProperties.DbSchema);

            b.ConfigureByConvention();
            b.Property(p => p.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
            b.Property(p => p.Description).IsRequired().HasMaxLength(QuestionConsts.MaxDescriptionLength);

            b.OwnsMany(p => p.Votes, v =>
            {
                v.ToTable(QuestionAnswerDbProperties.DbTablePrefix + "QuestionVotes",
                    QuestionAnswerDbProperties.DbSchema);
                v.HasKey(qv => new { qv.QuestionId, qv.VoterId, qv.VoteType });
                v.WithOwner();
            });
            b.OwnsMany(p => p.Tags, t =>
            {
                t.ToTable(QuestionAnswerDbProperties.DbTablePrefix + "QuestionQuestionTags",
                    QuestionAnswerDbProperties.DbSchema);
                t.HasKey(tag => new { tag.QuestionId, tag.TagId });
                t.WithOwner();
            });

            b.Navigation(n => n.Tags).UsePropertyAccessMode(PropertyAccessMode.Field);
            b.Navigation(n => n.Votes).UsePropertyAccessMode(PropertyAccessMode.Field);
        });

        builder.Entity<Comment>(b =>
        {
            b.ToTable(QuestionAnswerDbProperties.DbTablePrefix + "Comments", QuestionAnswerDbProperties.DbSchema);

            b.ConfigureByConvention();

            b.Property(p => p.Text).IsRequired().HasMaxLength(CommentConsts.MaxTextLength);

            b.HasDiscriminator()
                       .HasValue<Comment>(nameof(Comment))
                       .HasValue<AnswerComment>(nameof(AnswerComment))
                       .HasValue<QuestionComment>(nameof(QuestionComment));
        });

      




        builder.Entity<Answer>(b =>
        {
            b.ToTable(QuestionAnswerDbProperties.DbTablePrefix + "Answers", QuestionAnswerDbProperties.DbSchema);

            b.ConfigureByConvention();

            b.Property(p => p.Text).IsRequired().HasMaxLength(AnswerConsts.MaxAnswerLength);

            b.OwnsMany(p => p.Votes, v =>
            {
                v.ToTable(QuestionAnswerDbProperties.DbTablePrefix + "AnswerVotes",
                    QuestionAnswerDbProperties.DbSchema);
                v.HasKey(vote => new { vote.AnswerId, vote.VoterId, vote.VoteType });
                v.HasIndex(vote => vote.AnswerId);
                v.WithOwner();
            });
            b.OwnsMany(p => p.Snapshots, s =>
            {
                s.ToTable(QuestionAnswerDbProperties.DbTablePrefix + "AnswerSnapshots",
                    QuestionAnswerDbProperties.DbSchema);
                s.HasKey(snapshot => new { snapshot.AnswerId, snapshot.LastModificationTime });
                s.HasIndex(snapshot => snapshot.AnswerId);
                s.WithOwner();
            });

            b.Navigation(p => p.Votes).UsePropertyAccessMode(PropertyAccessMode.Field);
            b.Navigation(p => p.Snapshots).UsePropertyAccessMode(PropertyAccessMode.Field);

            b.HasIndex(p => p.QuestionId);
        });
    }
}
