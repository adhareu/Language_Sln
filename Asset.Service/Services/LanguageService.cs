using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asset.Infrastructure;
using Asset.Model;

using Asset.Repository;


namespace Asset.Service
{
    public class LanguageService:ILanguageService
    {
        private ILanguageRepository repository;
        private IUnitOfWork unitOfWork;
        public LanguageService()
        {
            var objDatabaseFactory = new DatabaseFactory();
            repository = new LanguageRepository(objDatabaseFactory);
            unitOfWork = new UnitOfWork(objDatabaseFactory);
        }
        //public LanguageService(string connString)
        //{
        //    var objDatabaseFactory = new DatabaseFactory();
        //    repository = new LanguageRepository(connString,objDatabaseFactory);
        //    unitOfWork = new UnitOfWork(objDatabaseFactory);
        //}

        public List<Language> GetAll()
        {
           
            var S_Language = repository.GetAll().ToList();
           
            return S_Language;
        }

        public Language GetById(int id)
        {
            return repository.Get(x=>x.LanguageID==id);
        }

        public List<Language> FindByName(string name)
        {
            return repository.GetMany(e => e.LanguageName.Equals(name)).ToList();
        }
        public bool Add(Language aS_Language)
        {
            try
            {
                
                
                repository.Add(aS_Language);
                unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Language aS_Language)
        {
            try
            {
               
                repository.Update(aS_Language);
                unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(Language aS_Language)
        {
            try
            {

                repository.Update(aS_Language);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
