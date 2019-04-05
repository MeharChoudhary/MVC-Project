using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeId { get; set; }
        public string DegreeAbbr { get; set; }
        public int NumberOfTerms { get; set; }
        public bool Done { get; set; }


    }
}
