using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Asset.Model;

using Asset.Service;
using System.Web.Http.Cors;

namespace Asset.WebAPI.Controllers
{
   
    public class LanguageController : ApiController
    {
        private readonly ILanguageService _LanguageService;
        public LanguageController(ILanguageService LanguageService)
        {
            _LanguageService = LanguageService;
        }
        // GET: api/Language
       
        [HttpGet]
        public List<Language> GetAllLanguage()
        {
            return _LanguageService.GetAll();
        }

        // GET: api/Language/5
      
        [HttpGet]
        [ResponseType(typeof(Language))]
        public Language GetLanguage(int id)
        {
            Language s_Language = _LanguageService.GetById(id);
            

            return s_Language;
        }

        // PUT: api/Language/5
     
        [HttpPost]
        [ResponseType(typeof(void))]
        public IHttpActionResult AddLanguage( Language s_Language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            

           

                _LanguageService.Add(s_Language);
           

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Language
       
        [HttpPut]
        [ResponseType(typeof(Language))]
        public IHttpActionResult UpdateLanguage(Language s_Language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _LanguageService.Update(s_Language);

            return CreatedAtRoute("DefaultApi", new { id = s_Language.LanguageID }, s_Language);
        }

        // DELETE: api/Language/5
     
        [HttpDelete]
        [ResponseType(typeof(Language))]
        public IHttpActionResult DeleteLanguage(int id)
        {
            Language s_Language = _LanguageService.GetById(id);
            if (s_Language == null)
            {
                return NotFound();
            }

            _LanguageService.Delete(s_Language);

            return Ok(s_Language);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
       
        [HttpGet]
        public bool IsLanguageExists( string Name)
        {
            return _LanguageService.FindByName(Name).Count() > 0;
        }
        [HttpGet]
        public bool IsLanguageExistsWithID(int id,string Name)
        {
            return _LanguageService.FindByName(Name).Where(x=>x.LanguageID!=id).Count() > 0;
        }
    }
}