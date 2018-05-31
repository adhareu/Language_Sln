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
    public class DepartmentService:IDepartmentService
    {
        private IDepartmentRepository repository;
        private IUnitOfWork unitOfWork;
        public DepartmentService()
        {
            var objDatabaseFactory = new DatabaseFactory();
            repository = new DepartmentRepository(objDatabaseFactory);
            unitOfWork = new UnitOfWork(objDatabaseFactory);
        }
        //public DepartmentService(string connString)
        //{
        //    var objDatabaseFactory = new DatabaseFactory();
        //    repository = new DepartmentRepository(connString,objDatabaseFactory);
        //    unitOfWork = new UnitOfWork(objDatabaseFactory);
        //}

        public List<Department> GetAll(int languageId)
        {
           
            var S_Department = repository.GetMany(x=>x.LanguageID==languageId).ToList();
           
            return S_Department;
        }

        public Department GetById(int id)
        {
            return repository.Get(x=>x.DepartmentID==id);
        }

        public List<Department> FindByName(int languageId, string name)
        {
            return repository.GetMany(e =>e.LanguageID==languageId && e.DepartmentName.Equals(name)).ToList();
        }
        public bool Add(Department aS_Department)
        {
            try
            {
                
                
                repository.Add(aS_Department);
                unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Department aS_Department)
        {
            try
            {
               
                repository.Update(aS_Department);
                unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(Department aS_Department)
        {
            try
            {

                repository.Update(aS_Department);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
