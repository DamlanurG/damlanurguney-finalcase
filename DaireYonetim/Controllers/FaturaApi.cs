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
    public class FaturaApi : ControllerBase
    {
        private GenericUnitOfWork unitOfWork = null;

        public FaturaApi(TContext context)
        {
            unitOfWork = new GenericUnitOfWork(context);
        }

        // GET: api/<FaturaApi>
        [HttpGet]
        public IEnumerable<Fatura> Get()
        {
            var list = unitOfWork.Repository<Fatura>().GetList().ToList();
            return list.ToArray();
        }

        // GET api/<FaturaApi>/5
        [HttpGet("{id}")]
        public Fatura Get(int id)
        {
            var _fatura = unitOfWork.Repository<Fatura>().GetList(x => x.DaireID == id).FirstOrDefault();
            return _fatura;
        }

        // POST api/<FaturaApi>
        [HttpPost]
        public void Post([FromBody] Fatura value)
        {
            if (value.ID > 0)
            {
                unitOfWork.Repository<Fatura>().Update(value);
                unitOfWork.SaveChanges();
            }
            else
            {
                unitOfWork.Repository<Fatura>().Insert(value);
                unitOfWork.SaveChanges();
            }
        }

        //// PUT api/<FaturaApi>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Fatura value)
        //{
        //    value.ID = id;
        //    unitOfWork.Repository<Fatura>().Update(value);
        //    unitOfWork.SaveChanges();
        //}
    }
}
