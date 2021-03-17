using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace midTerm.Models.Models.Answers
{
    class AnswersUpdateModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string UsereId { get; set; }
        public string OptionId { get; set; }
    }
}
