using System;
using System.Collections.Generic;

namespace Xela_api_pariss.Models.DbCafesalud
{
    public partial class VwImagCy
    {
        public int? Id { get; set; }
        public decimal IdCat { get; set; }
        public decimal IdRad { get; set; }
        public string RutaSan { get; set; }
        public string DescTip { get; set; }
        public string San { get; set; }
        public string TdocPac { get; set; }
        public string NdocPac { get; set; }
        public string Nomb1Pac { get; set; }
        public string Nomb2Pac { get; set; }
        public string Ape1Pac { get; set; }
        public string Ape2Pac { get; set; }
        public DateTime FechIng { get; set; }
        public DateTime? FechSal { get; set; }
        public string NumeRad { get; set; }
        public DateTime FechReg { get; set; }
        public string Origen { get; set; }
        public int? CodiReg { get; set; }
        public string NombReg { get; set; }
        public string NitEps { get; set; }
        public string NombEps { get; set; }
        public string NumDocIps { get; set; }
        public string NombIps { get; set; }
        public string PrefFact { get; set; }
        public string NumFact { get; set; }
        public DateTime? FechFact { get; set; }
        public decimal ValBruto { get; set; }
        public decimal ValCop { get; set; }
        public decimal ValMod { get; set; }
        public decimal ValDesc { get; set; }
        public decimal ValNeto { get; set; }
        public string CodiEst { get; set; }
        public string DescEst { get; set; }
        public DateTime? FechaEstado { get; set; }
        public int? CantHoj { get; set; }
        public decimal? RadReingreso { get; set; }
        public double? MunIdmunicipio { get; set; }
        public string MunNomMunicipio { get; set; }
        public string Modalidad { get; set; }
        public string UsuarioRadica { get; set; }
        public string StickerCm { get; set; }
        public string DescTramite { get; set; }
        public decimal ValorGlosado { get; set; }
        public decimal VlrGlosaInicial { get; set; }
        public string DescEstEps { get; set; }
    }
}
