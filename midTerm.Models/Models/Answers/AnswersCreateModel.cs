using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace midTerm.Models.Models.Answers
{
    class AnswersCreateModel
    { 
        [Required]
        [MaxLength(500)]
        public string UserId { get; set; }
        public string OptionId { get; set; }
    }
}
