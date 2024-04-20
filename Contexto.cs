using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WCFDados
{
    public class Contexto: DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public Contexto(): base ("TAT12024") { }

    }
}