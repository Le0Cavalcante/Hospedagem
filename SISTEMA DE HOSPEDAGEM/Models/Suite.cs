using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMA_DE_HOSPEDAGEM.Models
{
    public class Suite
    {
        public Suite() {}
        public Suite(string tipoSuite, int capacidadeHospedes, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            CapacidadeHospedes = capacidadeHospedes;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; }
        public int CapacidadeHospedes { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}

