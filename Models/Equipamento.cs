using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValeAtivos324133124.Models
{
    public class Equipamento
    {
     public int Id {get; set;}
     public required string Nome {get; set;}
     public required string Tipo {get; set;}
     public required string Localizacao {get; set;}
     public required double CapacidadeProcessamento {get; set;}
     public required DateTime DataUltimaManutencao {get; set;}
     public required bool EmOperacao {get; set;}

    }
}