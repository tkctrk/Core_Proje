using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public Experience GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Experience entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Experience entity)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetList()
        {
           return _experienceDal.GetList();
        }

        public void TUpdate(Experience entity)
        {
            throw new NotImplementedException();
        }
    }
}
