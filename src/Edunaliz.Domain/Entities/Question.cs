using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edunaliz.Domain.Entities
{
    public class Question : Auditable
    {
        public string Text { get; set; }
        public long? AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
        public long AssignmentId { get; set; }  
        public Assignment Assignment { get; set; }
    }
}
