using CatchException.QuestionAnswer.Answers;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace CatchException.QuestionAnswer.Questions;

public class QuestionManager : DomainService
{
    public IQuestionRepository QuestionRepository =>
        LazyServiceProvider.LazyGetRequiredService<IQuestionRepository>();

    protected IAnswerRepository AnswerRepository =>
        LazyServiceProvider.LazyGetRequiredService<IAnswerRepository>();

    public async Task<Question> SolvedAsync(Guid questionId, Guid acceptedAnswerId)
    {
        var question = await QuestionRepository.FindAsync(questionId);
        if (question == null)
        {
            throw new ArgumentException($"There is no question with id equal to {questionId}");
        }
        var answer = await AnswerRepository.FirstOrDefaultAsync(a =>
            a.Id == acceptedAnswerId &&
            a.QuestionId == questionId);
        if (answer == null)
        {
            throw new ArgumentException($"There is no answer with id equal to {acceptedAnswerId} or the answer does not belong to the question with id {questionId}");
        }

        return question.Solved(acceptedAnswerId);

    }
}
