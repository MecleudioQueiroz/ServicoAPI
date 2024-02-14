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
    [Route("api/produto")]
    public class ProdutoController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/Produto
        public IQueryable<produto> Getproduto()
        {
            try
            {
                return db.produto;
            }
            catch (Exception erro)
            {

                throw;
            }
        }

        // GET: api/Produto/5
        [ResponseType(typeof(produto))]
        public IHttpActionResult GetProdutos(int id)
        {
            produto produtos = db.produto.Find(id);
            if (produtos == null)
            {
                return NotFound();
            }

            return Ok(produtos);
        }

        // PUT: api/Produto/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProdutos(int id, produto produtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != produtos.ProdutoId)
            {
                return BadRequest();
            }

            db.Entry(produtos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutosExists(id))
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

        // POST: api/Produto
        [ResponseType(typeof(produto))]
        public IHttpActionResult PostProdutos(produto produtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.produto.Add(produtos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = produtos.ProdutoId }, produtos);
        }

        // DELETE: api/Produto/5
        [ResponseType(typeof(produto))]
        public IHttpActionResult DeleteProdutos(int id)
        {
            produto produtos = db.produto.Find(id);
            if (produtos == null)
            {
                return NotFound();
            }

            db.produto.Remove(produtos);
            db.SaveChanges();

            return Ok(produtos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProdutosExists(int id)
        {
            return db.produto.Count(e => e.ProdutoId == id) > 0;
        }
    }
}