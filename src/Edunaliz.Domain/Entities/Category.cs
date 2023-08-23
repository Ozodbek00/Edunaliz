﻿namespace Edunaliz.Domain.Entities
{
    public class Category : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? ParentId { get; set; }
    }
}
