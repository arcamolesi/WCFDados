using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WCFDados
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string disciplina { get; set; }
        public float nota { get; set; }
    }
}