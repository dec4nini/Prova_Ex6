using ProvaExAluno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaExAluno.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alunos.Any())
            {
                return;
            }

            var alunos = new Aluno[]
            {
                new Aluno{Nome = "Pedro", Idade=14, Endereco="Rua De Verdade 500", Sexo="M", Mensalidade=500},
                new Aluno{Nome = "Ivone", Idade=15, Endereco="Rua Perto Dali 13", Sexo="F", Mensalidade=500},
                new Aluno{Nome = "Joana", Idade=17, Endereco="Rua Longe de Casa 12", Sexo="F", Mensalidade=2500},
                new Aluno{Nome = "Maria", Idade=14, Endereco="Avenida Chorona 999", Sexo="F", Mensalidade=2500},
                new Aluno{Nome = "Ana", Idade=15, Endereco="Rua dos Olhos 00", Sexo="F", Mensalidade=2500},
                new Aluno{Nome = "Daniel", Idade=15, Endereco="Avenida Escura 14", Sexo="M", Mensalidade=2500},
                new Aluno{Nome = "Andre", Idade=17, Endereco="Avenida Escura 20", Sexo="M", Mensalidade=2500},
                new Aluno{Nome = "Julia", Idade=16, Endereco="Rua de Verdade 12", Sexo="F", Mensalidade=500},
                new Aluno{Nome = "Carla", Idade=18, Endereco="Rua Longe de Casa 16", Sexo="F", Mensalidade=500},
                new Aluno{Nome = "Mario", Idade=16, Endereco="Rua de Verdade 90", Sexo="M", Mensalidade=500},

            };


            foreach (Aluno a in alunos)
            {
                context.Alunos.Add(a);
            }

            context.SaveChanges();

        }
    }
}
