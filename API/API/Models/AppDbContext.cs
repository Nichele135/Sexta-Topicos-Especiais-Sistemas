using Microsoft.EntityFrameworkCore;

namespace API.Models;

//classe que representa o enitity framework dentro do projeto
public class AppDbContext : DbContext
{
    //classe qeu vao representar as tabelas no banco de dados
    public DbSet<Produto> Produtos {get; set;}

    //configurando qual banco de dados vai ser utilizado
    //configurando a string de conexao
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=db");
        
    }
}