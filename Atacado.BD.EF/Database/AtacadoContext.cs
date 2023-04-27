using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Atacado.BD.EF.Database;

public partial class AtacadoContext : DbContext
{
    public AtacadoContext()
    {
    }

    public AtacadoContext(DbContextOptions<AtacadoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; } = null!;

    public virtual DbSet<Produto> Produtos { get; set; } = null!;

    public virtual DbSet<Subcategoria> Subcategorias { get; set; } = null!;

    public virtual DbSet<Regiao> Regioes { get; set; } = null!;

    public virtual DbSet<Estado> Estados { get; set; } = null!;

    public virtual DbSet<Cidade> Cidades { get; set; } = null!;

    public virtual DbSet<Banco> Bancos { get; set; } = null!;

    public virtual DbSet<AreaConhecimento> AreaConhecimentos { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=cgr_lab15_maq13\\sqlexpress;Initial Catalog=bdAtacado; User=usrAtacado; Password=senha123; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Subcategoria>(entity =>
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Regiao>();

        modelBuilder.Entity<Estado>();

        modelBuilder.Entity<Cidade>();

        modelBuilder.Entity<Banco>(entity => 
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<AreaConhecimento>(entity => 
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
        });

        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
