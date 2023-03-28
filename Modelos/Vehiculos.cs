using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecanico.Modelos
{
    internal class Vehiculos
    {
        [Key]
        public int VehiculoId { get; set; }
        public string Marca { set; get; }
        public DateTime year { set; get; }
    }
}
