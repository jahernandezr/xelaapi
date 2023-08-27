using System;
using System.Collections.Generic;

namespace Xela_api_pariss.Models.DbCafesalud
{
    public partial class Catalogo
    {
        /// <summary>
        /// Identificador único del catálogo
        /// </summary>
        public decimal IdCat { get; set; }
        /// <summary>
        /// Identificador único de la factura
        /// </summary>
        public decimal IdRad { get; set; }
        /// <summary>
        /// Ruta SAN del catálogo
        /// </summary>
        public string RutaSan { get; set; }
        /// <summary>
        /// ID del tipo de catálogo
        /// </summary>
        public byte IdTip { get; set; }
        /// <summary>
        /// Descripción del tipo de catálogo
        /// </summary>
        public string DescTip { get; set; }
        /// <summary>
        /// ruta SAN principal del catálogo
        /// </summary>
        public string San { get; set; }
    }
}
