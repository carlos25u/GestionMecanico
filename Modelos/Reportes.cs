﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecanico.Modelos
{
    internal class Reportes
    {
        [Key]
        public int ReporteId { get; set; }
        public string Concepto { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int ClienteId { get; set; }
        public int MecanicoId { get; set; }

        [ForeignKey("ClienteId")]
        public Clientes clientes { get; set; }

        [ForeignKey("MecanicoId")]
        public Mecanicos mecanicos { get; set; }
    }
}
