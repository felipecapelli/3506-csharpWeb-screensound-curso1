using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ORM means Object-Relational Mapping

namespace ScreenSound.Banco
{
    internal class ScreenSoundContext : DbContext
    {

        public DbSet<Artista> Artistas { get; set; }
        //private string connectionString = "Data Source=\"192.168.1.39, 1433\";Initial Catalog=ScreenSound;User ID=sa;Password=@Teste123;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"; //The teacher asked to delete this part of the connection string: Connect Timeout=30;
        private string connectionString = "Data Source=\"localhost, 1433\";Initial Catalog=ScreenSound;User ID=sa;Password=@Teste123;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"; //The teacher asked to delete this part of the connection string: Connect Timeout=30;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
