using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gender :IEntity
    {
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public string GenderDescription { get; set; }
    }
}
