using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class DegreeRequirement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeId { get; set; }
        public string DegreeAbbr { get; set; }
        public int NumberOfTerms { get; set; }


}
}
