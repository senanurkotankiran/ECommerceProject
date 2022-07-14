using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GenderManager : IGenderService
    {
        IGenderDal _genderDal;

        public GenderManager(IGenderDal genderDal)
        {
            _genderDal = genderDal;
        }

        public void Add(Gender gender)
        {
            _genderDal.Add(gender);
            Console.WriteLine("Cinsiyet eklendi! " + gender.GenderName);
        }

        public void Delete(Gender gender)
        {
            _genderDal.Delete(gender);
            Console.WriteLine("Cinsiyet silindi! " + gender.GenderName);
        }

        public List<Gender> GetAll()
        {
            return _genderDal.GetAll();

        }

        public void Update(Gender gender)
        {
            _genderDal.Update(gender);
            Console.WriteLine("Cinsiyet güncellendi! " + gender.GenderName);
        }
    }
}
