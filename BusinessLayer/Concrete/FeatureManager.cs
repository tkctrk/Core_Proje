﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IContactService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public Feature GetById(int id)
        {
           return _featureDal.GetByID(id);
        }

        public void TAdd(Feature entity)
        {
            _featureDal.Insert(entity);
            
        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public List<Feature> TGetList()
        {
          return  _featureDal.GetList();
        }

        public void TUpdate(Feature entity)
        {
             _featureDal.Update(entity);
        }
    }
}
