using Microsoft.EntityFrameworkCore;
using ProvaExAluno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaExAluno.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {

        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
