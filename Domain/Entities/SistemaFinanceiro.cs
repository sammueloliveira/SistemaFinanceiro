﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SistemaFinanceiro 
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string? Nome { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int DiaFechamento { get; set; }
        public bool GerarCopiaDespesa { get; set; }
        public int MesCopia { get; set; }
        public int AnoCopia { get; set; }
    }
}
