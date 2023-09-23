using Microsoft.EntityFrameworkCore;
using SagitarioRH.Models;
using SagitarioRHDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SagitarioRHDesktop.Data
{
    internal class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        }

        public DbSet<FuncionarioModel> funcionarios { get; set; }
        public DbSet<AdministradorModel>  administradores { get; set; }
        public DbSet<EmpresaModel> empresas { get; set; }
        public DbSet<EventosModel> eventosPgto { get; set; }
        public DbSet<FolhaPgtoModel> folhaPgto { get; set; }
        public DbSet<ImpostoRendaModel> cadImpRenda { get; set; }
        public DbSet<ImpostoINSSModel> cadINSS { get; set; }

    }
}
