using System;
using System.Collections.Generic;
using System.Text;

namespace EPazar.Entity.BaseEntity
{
    public class BaseEntity
    {
        public bool Deleted { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }

        public BaseEntity()
        {
            Deleted = false;
            UpdateTime = DateTime.Now;
            CreateTime = DateTime.Now;
        }
    }
}
