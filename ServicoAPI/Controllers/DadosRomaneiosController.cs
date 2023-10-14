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
using ServicoAPI.Models;

namespace ServicoAPI.Controllers
{
    public class DadosRomaneiosController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/DadosRomaneios
        public IEnumerable<DadosRomaneio> GetDadosRomaneio()
        {
            return db.DadosRomaneio.ToList();
        }

        // GET: api/DadosRomaneios/5
        [ResponseType(typeof(DadosRomaneio))]
        public IHttpActionResult GetDadosRomaneio(int id)
        {
            DadosRomaneio dadosRomaneio = db.DadosRomaneio.Find(id);
            if (dadosRomaneio == null)
            {
                return NotFound();
            }

            return Ok(dadosRomaneio);
        }

        // PUT: api/DadosRomaneios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDadosRomaneio(int id, DadosRomaneio dadosRomaneio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dadosRomaneio.Id)
            {
                return BadRequest();
            }

            db.Entry(dadosRomaneio).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DadosRomaneioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/DadosRomaneios
        [ResponseType(typeof(DadosRomaneio))]
        public IHttpActionResult PostDadosRomaneio(DadosRomaneio dadosRomaneio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DadosRomaneio.Add(dadosRomaneio);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dadosRomaneio.Id }, dadosRomaneio);
        }

        // DELETE: api/DadosRomaneios/5
        [ResponseType(typeof(DadosRomaneio))]
        public IHttpActionResult DeleteDadosRomaneio(int id)
        {
            DadosRomaneio dadosRomaneio = db.DadosRomaneio.Find(id);
            if (dadosRomaneio == null)
            {
                return NotFound();
            }

            db.DadosRomaneio.Remove(dadosRomaneio);
            db.SaveChanges();

            return Ok(dadosRomaneio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DadosRomaneioExists(int id)
        {
            return db.DadosRomaneio.Count(e => e.Id == id) > 0;
        }
    }
}