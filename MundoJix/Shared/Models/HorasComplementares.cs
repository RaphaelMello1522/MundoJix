using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoJix.Shared.Models
{
    public class HorasComplementares
    {
        [Key]
        public int Id { get; set; }
        public string TipoAtividade { get; set; }
        public int QntHoras { get; set; }
        public string Status { get; set; }
        public int AlunoID { get; set; }

        public Aluno Alunos;
    }
}
