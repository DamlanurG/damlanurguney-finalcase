using DaireYonetim.Context;
using DaireYonetim.Entity;
using DaireYonetim.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DaireYonetim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesajApi : ControllerBase
    {
        private GenericUnitOfWork unitOfWork = null;

        public MesajApi(TContext context)
        {
            unitOfWork = new GenericUnitOfWork(context);
        }

        // GET: api/<MesajApi>
        [HttpGet]
        public IEnumerable<Mesaj> Get()
        {
            var list = unitOfWork.Repository<Mesaj>().GetList().ToList();
            return list.ToArray();
        }

        // GET api/<MesajApi>/5
        [HttpGet("{id}")]
        public Mesaj Get(int id)
        {
            var _mesaj = unitOfWork.Repository<Mesaj>().GetList(x => x.ID == id).FirstOrDefault();
            _mesaj.Okundumu = true;
            unitOfWork.Repository<Mesaj>().Update(_mesaj);
            unitOfWork.SaveChanges();
            return _mesaj;
        }

        // POST api/<MesajApi>
        [HttpPost]
        public void Post([FromBody] Mesaj value)
        {
            value.Tarih = DateTime.Now;
            unitOfWork.Repository<Mesaj>().Insert(value);
            unitOfWork.SaveChanges();
        }

        [Route("okunmamisMesajlar")]
        [HttpGet()]
        public IEnumerable<Mesaj> OkunmamisMesajlar()
        {
            var list = unitOfWork.Repository<Mesaj>().GetList(x => x.Okundumu == false).ToList();
            return list.ToArray();
        }
    }
}
