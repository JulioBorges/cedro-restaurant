﻿using Restaurante.Core.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Data.Domain
{
    [Table("Prato")]
    public class Prato : DefaultEntity
    {
        [Column("NomePrato")]
        [Required]
        public string Nome { get; set; }

        [Column("PrecoPrato")]
        [Required]
        public decimal Preco { get; set; }

        [ForeignKey("Restaurante")]
        public int IdRestaurante { get; set; }

        public Restaurante Restaurante { get; set; }
    }
}
