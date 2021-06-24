using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Stores.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Stores.Models
{
    public class AppDbContext: IdentityDbContext<UsuarioApliacion, ApplicationRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Store> Store { get; set; }
         
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);  
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Store>().HasData(new Store
        //    {
        //        Id = 1,
        //        Nombre = "DefaultStore",
        //        Direccion = "San Miguel",
        //        Lat = 1.222222,
        //        Long = 2.3333,
        //        Telefono = "24578984"
        //    });
        //}
    }
}
