using LojaCet49.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LojaCet49.Dados
{
    public class DataContext : DbContext                        /* o meu DataContext vai buscar o conteúdo ao DbContext da Entity Framework Core  */
    {
        /* Criar tabela: a propriedade DbSet vai criar uma tabela chamada Produtos usando o modelo Produto (Produto.cs)
         * O Produto é o Produto.cs (estrutura)
         * Produtos é a tabela (registos)
         * { get; set; } por permite colocar e buscar produtos
        */
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        /*
         * options é o nome que quiseremos da variavel
         * 
         * O meu DataContext vai usar as opções do DataContext dele que estão na base (DbContext) 
         * Este processo chama-se HERANÇA porque o objecto herda todas as funcionalidades do DbContext da Entity Framework Core
         */
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
