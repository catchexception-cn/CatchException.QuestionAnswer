using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace CatchException.QuestionAnswer.Questions
{
    public class UpdateQuestionDto : IValidatableObject
    {

        [Required]
        [MaxLength(QuestionConsts.MaxTitleLength)]
        public string Title { get; set; } = default!;

        [Required]
        [MaxLength(QuestionConsts.MaxDescriptionLength)]
        public string Description { get; set; } = default!;

        [Required]
        public List<Guid> Tags { get; set; } = new List<Guid>();


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Tags.Count() > QuestionConsts.MaxTagsCount)
            {
                yield return new ValidationResult($"标签数量不能超过{QuestionConsts.MaxTagsCount}个");
            }
        }
    }
}
