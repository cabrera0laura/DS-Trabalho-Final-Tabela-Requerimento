using LockAi.Models;
using Microsoft.EntityFrameworkCore;

namespace LockAi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Requerimento> TB_REQUERIMENTOS {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Requerimento>().ToTable("TB_REQUERIMENTOS");


            modelBuilder.Entity<Requerimento>().HasData
            (
                // Inserir as linhas "new "Personagem() {Id = 2,..." da lista de prsonagens"
                //Não é obrigatorio ,caso contrario adicionar Using

                new Requerimento() {Id= 1, Momento = "Na locação de um objeto", TipoRequerimento = "Requerimento sem custo", IdLocacao = "001", Observacao = "Preciso da chave para meu armario.", Situacao = "Em analise", DataAtualizacao = "01/06/2025", IdUsuarioAtualizacao = "007"},
                new Requerimento() {Id= 2, Momento = " Utilizando um objeto", TipoRequerimento = "Requerimento com custo", IdLocacao = "002", Observacao = "Perdi as chaves do meu armario", Situacao = "Concluido", DataAtualizacao = "02/06/2025", IdUsuarioAtualizacao = "006"},
                new Requerimento() {Id= 3, Momento = " Utilizando um objeto", TipoRequerimento = "Requerimento sem custo", IdLocacao = "003", Observacao = "o armario tem um objeto do antigo usuario", Situacao = "Concluido", DataAtualizacao = "03/06/2025", IdUsuarioAtualizacao = "005"},
                new Requerimento() {Id= 4, Momento = " Utilizando um objeto", TipoRequerimento = "Requerimento com custo", IdLocacao = "004", Observacao = "quero canselar o plano e receber o restante do meu dinheiro", Situacao = "Negado", DataAtualizacao = "04/06/2025", IdUsuarioAtualizacao = "004"},
                new Requerimento() {Id= 5, Momento = " Utilizando um objeto", TipoRequerimento = "Requerimento com custo", IdLocacao = "005", Observacao = "Perdi as chaves do meu armario ", Situacao = "Respondido", DataAtualizacao = "05/06/2025", IdUsuarioAtualizacao = "003"}
            );

            //Área para futuros inserts noi banco
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").
            HaveMaxLength(200);
        }
    }

 

}