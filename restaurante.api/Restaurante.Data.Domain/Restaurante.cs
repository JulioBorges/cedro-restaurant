﻿using Newtonsoft.Json;
using Restaurante.Core.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Data.Domain
{
    [Table("Restaurante")]
    public class Restaurante : DefaultEntity
    {
        public Restaurante()
        {
            Pratos = new List<Prato>();
        }

        [Column("NomeRestaurante")]
        [Required]
        public string Nome { get; set; }

        [JsonIgnore]
        public virtual List<Prato> Pratos { get; set; }
    }
}
