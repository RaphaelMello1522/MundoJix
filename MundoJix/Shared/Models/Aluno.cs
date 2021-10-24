using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MundoJix.Shared.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RA { get; set; }
        public string Curso { get; set; }
        public string Anexo { get; set; }
        public string Status { get; set; }

        public ICollection<HorasComplementares> horasComplementares { get; set; }

        public Task<string> Anexos(MultipartFormDataContent content)
        {
            throw new NotImplementedException();
        }
    }
}
