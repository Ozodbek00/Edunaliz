using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edunaliz.Domain.Entities
{
    public class Attachment : Auditable
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
    }
}
