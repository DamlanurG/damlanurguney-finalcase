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
    public class AidatApi : ControllerBase
    {
        private GenericUnitOfWork unitOfWork = null;

        public AidatApi(TContext context)
        {
            unitOfWork = new GenericUnitOfWork(context);
        }

        // GET: api/<AidatApi>
        [HttpGet]
        public IEnumerable<Aidat> Get()
        {
            var list = unitOfWork.Repository<Aidat>().GetList().ToList();
            return list.ToArray();
        }

        // GET api/<AidatApi>/5
        [HttpGet("{id}")]
        public Aidat Get(int id)
        {
            var _aidat = unitOfWork.Repository<Aidat>().GetList(x => x.DaireID == id).FirstOrDefault();
            return _aidat;
        }

        // POST api/<AidatApi>
        [HttpPost]
        public void Post([FromBody] Aidat value)
        {
            if (value.ID > 0)
            {
                unitOfWork.Repository<Aidat>().Update(value);
                unitOfWork.SaveChanges();
            }
            else
            {
                unitOfWork.Repository<Aidat>().Insert(value);
                unitOfWork.SaveChanges();
            }
        }

        //// PUT api/<AidatApi>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Aidat value)
        //{
        //    value.ID = id;
        //    unitOfWork.Repository<Aidat>().Update(value);
        //    unitOfWork.SaveChanges();
        //}
    }
}
