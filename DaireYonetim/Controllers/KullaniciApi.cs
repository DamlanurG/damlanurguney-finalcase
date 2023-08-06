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
    public class KullaniciApi : ControllerBase
    {
        private GenericUnitOfWork unitOfWork = null;

        public KullaniciApi(TContext context)
        {
            unitOfWork = new GenericUnitOfWork(context);
        }

        // GET: api/<KullaniciApi>
        [HttpGet]
        public IEnumerable<Kullanici> Get()
        {
            var list = unitOfWork.Repository<Kullanici>().GetList().ToList();
            return list.ToArray();
        }

        // GET api/<KullaniciApi>/5
        [HttpGet("{id}")]
        public Kullanici Get(int id)
        {
            var _kullanici = unitOfWork.Repository<Kullanici>().GetList(x => x.ID == id).FirstOrDefault();
            return _kullanici;
        }

        // POST api/<KullaniciApi>
        [HttpPost]
        public void Post([FromBody] Kullanici value)
        {
            if (value.ID > 0)
            {
                unitOfWork.Repository<Kullanici>().Update(value);
                unitOfWork.SaveChanges();
            }
            else
            {
                unitOfWork.Repository<Kullanici>().Insert(value);
                unitOfWork.SaveChanges();
            }
        }

        //// PUT api/<KullaniciApi>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Kullanici value)
        //{
        //    value.ID = id;
        //    unitOfWork.Repository<Kullanici>().Update(value);
        //    unitOfWork.SaveChanges();
        //}

        // DELETE api/<KullaniciApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            unitOfWork.Repository<Kullanici>().Delete(id);
            unitOfWork.SaveChanges();
        }


        [Route("giris")]
        [HttpGet()]
        public Kullanici Get([FromBody] Kullanici value)
        {
            var _kullanici = unitOfWork.Repository<Kullanici>().GetList(x => x.Email == value.Email && x.Sifre == value.Sifre).FirstOrDefault();
            return _kullanici;
        }

        [Route("daireAidat")]
        [HttpGet()]
        public Aidat DaireAidat([FromBody] int id)
        {
            var _aidat = unitOfWork.Repository<Aidat>().GetList(x => x.DaireID == id).FirstOrDefault();
            return _aidat;
        }

        [Route("daireAidatOdeme")]
        [HttpPost]
        public void DaireAidatOdeme([FromBody] Aidat value)
        {
            var _aidat = unitOfWork.Repository<Aidat>().GetList(x => x.DaireID == value.DaireID && x.Ay == value.Ay).FirstOrDefault();
            _aidat.Odendimi = true;
            unitOfWork.Repository<Aidat>().Update(_aidat);
            unitOfWork.SaveChanges();
        }

        [Route("daireFatura")]
        [HttpGet()]
        public Fatura DaireFatura([FromBody] int id)
        {
            var _aidat = unitOfWork.Repository<Fatura>().GetList(x => x.DaireID == id).FirstOrDefault();
            return _aidat;
        }

        [Route("daireFaturaOdeme")]
        [HttpPost]
        public void DaireFaturaOdeme([FromBody] Fatura value)
        {
            var _fatura = unitOfWork.Repository<Fatura>().GetList(x => x.DaireID == value.DaireID && x.Ay == value.Ay).FirstOrDefault();
            _fatura.Odendimi = true;
            unitOfWork.Repository<Fatura>().Update(_fatura);
            unitOfWork.SaveChanges();
        }
    }
}
