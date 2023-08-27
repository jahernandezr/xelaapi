using DocumentFormat.OpenXml.Office2010.Excel;

namespace Xela_api_pariss.Models
{
    public class ImagenesBits
    {
        public int Id { get; set; }
        //public byte[] Image { get; set; }
        public Guid CTCDigitalizationId { get; set; }
        //public Guid MedicamentId { get; set; }
        //public Guid AffiliateId { get; set; }
        //public Guid IdentificationTypeId { get; set; }
        public string IdentificationNumber { get; set; }
        public string FatherLastName  { get; set; }
        public string MotherLastName { get; set; }
     // public string NameValidator   { get; set; }
        public string Description { get; set; }
        public DateTime? RequestDate { get; set; }
     //   public DateTime? ApprovalDate { get; set; }  

    }
}
