using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeId { get; set; }
        [StringLength(20)]
        public string DegreeAbbr { get; set; }
        [Range(0, 30)]
        public int NumberOfTerms { get; set; }
        public bool Done { get; set; }
        public ICollection<DegreeCredit> DegreeCredits { get; set; }

    }
}
