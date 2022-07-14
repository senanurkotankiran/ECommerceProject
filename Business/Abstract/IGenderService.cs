using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGenderService
    {
        List<Gender> GetAll();
        void Add(Gender gender);
        void Update(Gender gender);
        void Delete(Gender gender);
    }
}
