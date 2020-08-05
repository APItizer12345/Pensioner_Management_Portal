using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pension_Management_Portal.Models
{
    public class PensionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Serial Number")]
        public int serialNumber { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime dateOfBirth { get; set; }
        [DisplayName("Pan Number")]
        public string pan { get; set; }
        [DisplayName("Aadhar Number")]
        public string aadharNumber { get; set; }
        [DisplayName("Pension Type")]
        public int pensionType { get; set; }
        [DisplayName("Pension Amount")]
        public int pensionAmount { get; set; }
        [DisplayName("Status Code")]
        public int status { get; set; }

      //  public HttpResponseMessage message { get; set; }

    }
    public enum PensionType1
    {
        Self = 1,
        Family = 2
    }
}
