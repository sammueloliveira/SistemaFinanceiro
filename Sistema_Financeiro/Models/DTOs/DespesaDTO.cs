﻿using Domain.Enums;

namespace APIs.Models.DTOs
{
    public class DespesaDTO
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public EnumTipoDespesa TipoDespesa { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        public DateTime DataPagamento { get; set; }

        public DateTime DataVencimento { get; set; }

        public bool Pago { get; set; }

        public bool DespesaAntrasada { get; set; }
        public int IdCategoria { get; set; }
       
    }
}
