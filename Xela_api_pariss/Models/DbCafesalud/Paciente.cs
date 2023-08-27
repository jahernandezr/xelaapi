using System;
using System.Collections.Generic;

namespace Xela_api_pariss.Models.DbCafesalud
{
    public partial class Paciente
    {
        /// <summary>
        /// Identificador único de la factura
        /// </summary>
        public decimal IdRad { get; set; }
        /// <summary>
        /// Tipo de documento del paciente
        /// </summary>
        public string TdocPac { get; set; }
        /// <summary>
        /// Número de documento del paciente
        /// </summary>
        public string NdocPac { get; set; }
        /// <summary>
        /// Primer nombre del paciente
        /// </summary>
        public string Nomb1Pac { get; set; }
        /// <summary>
        /// Segundo nombre del paciente
        /// </summary>
        public string Nomb2Pac { get; set; }
        /// <summary>
        /// Primer apellido del paciente
        /// </summary>
        public string Ape1Pac { get; set; }
        /// <summary>
        /// Segundo apellido del paciente
        /// </summary>
        public string Ape2Pac { get; set; }
        /// <summary>
        /// Fecha de ingreso del paciente
        /// </summary>
        public DateTime FechIng { get; set; }
        /// <summary>
        /// Fecha de salida del paciente
        /// </summary>
        public DateTime? FechSal { get; set; }
    }
}
