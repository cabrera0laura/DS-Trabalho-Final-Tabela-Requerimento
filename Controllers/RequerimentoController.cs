using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LockAi.Data;
using LockAi.Models;
using Microsoft.AspNetCore.Mvc;
using LockAi.Models;
using Microsoft.EntityFrameworkCore;


namespace LockAi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RequerimentoController : ControllerBase
    {
        //programação d etoda a classe será aqui
        private readonly DataContext _context;

        private static List<Requerimento> requerimentos = new List<Requerimento>()
        {
            //Modo de criação e inclusão de objeto de uma só vez na lista
             new Requerimento() {Id= 1, Momento = "Na locação de um objeto", TipoRequerimento = "Requerimento sem custo", IdLocacao = "001", Observacao = "Preciso da chave para meu armario.", Situacao = "Em analise", DataAtualizacao = "01/06/2025", IdUsuarioAtualizacao = "007"},
             new Requerimento() {Id= 2, Momento = " Utilizando um objeto", TipoRequerimento = "Requerimento com custo", IdLocacao = "002", Observacao = "Perdi as chaves do meu armario", Situacao = "Concluido", DataAtualizacao = "02/06/2025", IdUsuarioAtualizacao = "006"},
             new Requerimento() {Id= 3, Momento = " Utilizando um objeto", TipoRequerimento = "Requerimento sem custo", IdLocacao = "003", Observacao = "o armario tem um objeto do antigo usuario", Situacao = "Concluido", DataAtualizacao = "03/06/2025", IdUsuarioAtualizacao = "005"},
             new Requerimento() {Id= 4, Momento = " Utilizando um objeto", TipoRequerimento = "Requerimento com custo", IdLocacao = "004", Observacao = "quero canselar o plano e receber o restante do meu dinheiro", Situacao = "Negado", DataAtualizacao = "04/06/2025", IdUsuarioAtualizacao = "004"},
             new Requerimento() {Id= 5, Momento = " Utilizando um objeto", TipoRequerimento = "Requerimento com custo", IdLocacao = "005", Observacao = "Perdi as chaves do meu armario ", Situacao = "Respondido", DataAtualizacao = "05/06/2025", IdUsuarioAtualizacao = "003"}
        };

        /*[HttpGet("Get")]
        public IActionResult GetFirst()
        {
            Requerimento r = requerimentos[0];
            return Ok(r);
        }

        public IActionResult Get()
        {
            return Ok(requerimentos);
        }*/

        public RequerimentoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")] //buscar pelo id  TESTADO no SSMS!!!
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Requerimento r = await _context.TB_REQUERIMENTOS
                    .FirstOrDefaultAsync(rBusca => rBusca.Id == id);

                return Ok(r);
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]  // Lista todos os requisitos (Será usado no FrontEnd).  testado no SSMS
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Requerimento> lista = await _context.TB_REQUERIMENTOS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]  //Testado SSMS
        public async Task<IActionResult> Add(Requerimento novoRequerimento)
        {
            try
            {
                if(novoRequerimento.TipoRequerimento == null)
                {
                    throw new Exception("Tipo Requerimento não pode estar vazio!");
                }
                await _context.TB_REQUERIMENTOS.AddAsync(novoRequerimento);
                await _context.SaveChangesAsync();

                return Ok(novoRequerimento.Id);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]  //  Testado SSMS

        public async Task<IActionResult> Update(Requerimento novoRequerimento)
        {
            try
            {
                _context.TB_REQUERIMENTOS.Update(novoRequerimento);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Requerimento rRemover = await _context.TB_REQUERIMENTOS.FirstOrDefaultAsync(r => r.Id == id);

                _context.TB_REQUERIMENTOS.Remove(rRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        



    }// fim da classe do tipo controller
}