using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Models
{
    public class Estado
    {
        [Required]
        public string UF { get; set; }

        [Required(ErrorMessage = "Digite o nome do estado para prosseguir.")]
        public string Nome { get; set; }

        public bool VerificarMelhorEstadoDoBrasil()
        {
            if (UF == "MG")
                return true;
            else
                return false;
        }
    }
}
