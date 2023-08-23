using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edunaliz.Domain.Entities
{
    public class Answer : Auditable
    {
        public string Text { get; set; }
        public bool IsTrue { get; set; }
        public long? AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
        public long QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
