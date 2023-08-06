using DaireYonetim.Context;
using DaireYonetim.Entity;
using DaireYonetim.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DaireYonetim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaireApi : ControllerBase
    {
        private GenericUnitOfWork unitOfWork = null;

        public DaireApi(TContext context)
        {
            unitOfWork = new GenericUnitOfWork(context);
        }

        // GET: api/<DaireApi>
        [HttpGet]
        public IEnumerable<Daire> Get()
        {
            var list = unitOfWork.Repository<Daire>().GetList().ToList();
            return list.ToArray();
        }

        // GET api/<DaireApi>/5
        [HttpGet("{id}")]
        public Daire Get(int id)
        {
            var _daire = unitOfWork.Repository<Daire>().GetList(x => x.ID == id).FirstOrDefault();
            return _daire;
        }

        // POST api/<DaireApi>
        [HttpPost]
        public void Post([FromBody] Daire value)
        {
            if (value.ID > 0)
            {
                unitOfWork.Repository<Daire>().Update(value);
                unitOfWork.SaveChanges();
            }
            else
            {
                unitOfWork.Repository<Daire>().Insert(value);
                unitOfWork.SaveChanges();
            }
        }

        //// PUT api/<DaireApi>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Daire value)
        //{
        //    value.ID = id;
        //    unitOfWork.Repository<Daire>().Update(value);
        //    unitOfWork.SaveChanges();
        //}

        // DELETE api/<DaireApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            unitOfWork.Repository<Daire>().Delete(id);
            unitOfWork.SaveChanges();
        }

        [Route("aylikAidat")]
        [HttpGet()]
        public IEnumerable<Aidat> AylikAidat([FromBody] Aidat value)
        {
            var list = unitOfWork.Repository<Aidat>().GetList(x => x.Ay == value.Ay).ToList();
            return list.ToArray();
        }

        [Route("aylikOdenmemisAidat")]
        [HttpGet()]
        public IEnumerable<Aidat> AylikOdenmemisAidat([FromBody] Aidat value)
        {
            var list = unitOfWork.Repository<Aidat>().GetList(x => x.Ay == value.Ay && x.Odendimi == false).ToList();
            return list.ToArray();
        }

        [Route("aylikFatura")]
        [HttpGet()]
        public IEnumerable<Fatura> AylikFatura([FromBody] Fatura value)
        {
            var list = unitOfWork.Repository<Fatura>().GetList(x => x.Ay == value.Ay).ToList();
            return list.ToArray();
        }

        [Route("aylikOdenmemisFatura")]
        [HttpGet()]
        public IEnumerable<Fatura> AylikOdenmemisFatura([FromBody] Fatura value)
        {
            var list = unitOfWork.Repository<Fatura>().GetList(x => x.Ay == value.Ay && x.Odendimi == false).ToList();
            return list.ToArray();
        }
    }
}
