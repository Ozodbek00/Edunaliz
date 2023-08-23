using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edunaliz.Domain.Entities
{
    public class Result : Auditable
    {
        public long QuestionId { get; set; }
        public Question Question { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
