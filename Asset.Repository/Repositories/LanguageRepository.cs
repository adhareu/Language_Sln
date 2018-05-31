using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asset.Infrastructure;
using Asset.Model;


namespace Asset.Repository
{
    public interface ILanguageRepository : IRepository<Language>
    {
    }
    public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
    {
        public LanguageRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
        
    }
}
