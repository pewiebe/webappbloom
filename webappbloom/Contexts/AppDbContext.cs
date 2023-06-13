namespace WebAppBloom.Contexts;
using WebAppBloom.Models;
using Microsoft.EntityFrameworkCore;


//Contexto = Banco
//DbContexto --> Banco
// DBSet --> Tabela
// Banco ":" Herança

public class AppDbContext:DbContext{
//Tabela
public DbSet<Competencia> Competencias => Set<Competencia>();


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAB-F08-09;Database=WebAppBloom;User Id=sa;Password=senai@123;TrustServerCertificate=True;");
    }

}