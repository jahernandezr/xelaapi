using System;
using System.Collections.Generic;

namespace Xela_api_pariss.Models.DbCafesalud
{
    public partial class Factura
    {
        /// <summary>
        /// Identificador único de la factura
        /// </summary>
        public decimal IdRad { get; set; }
        /// <summary>
        /// Identificador único de la factura cliente
        /// </summary>
        public string NumeRad { get; set; }
        /// <summary>
        /// Fecha de registro de la factura
        /// </summary>
        public DateTime FechReg { get; set; }
        /// <summary>
        /// Origen de la factura
        /// </summary>
        public string Origen { get; set; }
        /// <summary>
        /// Código de regional
        /// </summary>
        public int? CodiReg { get; set; }
        /// <summary>
        /// Nombre de regional
        /// </summary>
        public string NombReg { get; set; }
        /// <summary>
        /// Identificador de la EPS
        /// </summary>
        public byte IdEps { get; set; }
        /// <summary>
        /// NIT de la EPS
        /// </summary>
        public string NitEps { get; set; }
        /// <summary>
        /// Nombre de la EPS
        /// </summary>
        public string NombEps { get; set; }
        /// <summary>
        /// Número de documento de la IPS
        /// </summary>
        public string NumDocIps { get; set; }
        /// <summary>
        /// Nombre de la IPS
        /// </summary>
        public string NombIps { get; set; }
        /// <summary>
        /// Prefijo de la factura
        /// </summary>
        public string PrefFact { get; set; }
        /// <summary>
        /// Número de la factura
        /// </summary>
        public string NumFact { get; set; }
        /// <summary>
        /// Fecha de la factura
        /// </summary>
        public DateTime? FechFact { get; set; }
        /// <summary>
        /// Valor bruto de la factura
        /// </summary>
        public decimal ValBruto { get; set; }
        /// <summary>
        /// Valor copago de la factura
        /// </summary>
        public decimal ValCop { get; set; }
        /// <summary>
        /// Valor moderadora de la factura
        /// </summary>
        public decimal ValMod { get; set; }
        /// <summary>
        /// Valor descuento de la factura
        /// </summary>
        public decimal ValDesc { get; set; }
        /// <summary>
        /// Valor neto de la factura
        /// </summary>
        public decimal ValNeto { get; set; }
        /// <summary>
        /// Código del estado de la factura
        /// </summary>
        public string CodiEst { get; set; }
        /// <summary>
        /// Descripción del estado de la factura
        /// </summary>
        public string DescEst { get; set; }
        /// <summary>
        /// Fecha del estado de la factura
        /// </summary>
        public DateTime? FechaEstado { get; set; }
        /// <summary>
        /// Cantidad de hojas de la factura
        /// </summary>
        public int? CantHoj { get; set; }
        /// <summary>
        /// Identificador de la factura de reingreso (Radicado Anterior)
        /// </summary>
        public decimal? RadReingreso { get; set; }
        /// <summary>
        /// ID del municipio
        /// </summary>
        public double? MunIdmunicipio { get; set; }
        /// <summary>
        /// Nombre del municipio
        /// </summary>
        public string MunNomMunicipio { get; set; }
        /// <summary>
        /// ID de la modalidad
        /// </summary>
        public byte IdModalidad { get; set; }
        /// <summary>
        /// Modalidad de la factura
        /// </summary>
        public string Modalidad { get; set; }
        /// <summary>
        /// Usuario que radica la factura
        /// </summary>
        public string UsuarioRadica { get; set; }
        /// <summary>
        /// Etiqueta CM de la factura
        /// </summary>
        public string StickerCm { get; set; }
        /// <summary>
        /// Descripción del trámite
        /// </summary>
        public string DescTramite { get; set; }
        /// <summary>
        /// Valor glosado de la factura
        /// </summary>
        public decimal ValorGlosado { get; set; }
        /// <summary>
        /// Valor de la glosa inicial de la factura
        /// </summary>
        public decimal VlrGlosaInicial { get; set; }
        /// <summary>
        /// Descripción del estado agrupador para la EPS
        /// </summary>
        public string DescEstEps { get; set; }
    }
}
