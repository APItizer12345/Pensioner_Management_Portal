using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pension_Management_Portal.Models
{
    public class PensionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int serialNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string pan { get; set; }
        public PensionType1 pensionType { get; set; }
        public int pensionAmount { get; set; }


    }
    public enum PensionType1
    {
        Self = 1,
        Family = 2
    }
}
