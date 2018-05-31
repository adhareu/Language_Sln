using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asset.Model;

namespace Asset.Service
{
   public interface ILanguageService
    {
        List<Language> GetAll();
        Language GetById(int id);
        List<Language> FindByName(string name);
        bool Add(Language aLanguage);
        bool Update(Language aLanguage);
        bool Delete(Language aLanguage);
    }
}
