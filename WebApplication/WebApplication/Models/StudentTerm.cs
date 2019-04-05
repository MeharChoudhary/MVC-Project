using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class StudentTerm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId{ get; set; }
        public int StudentId { get; set; }
        public int Term { get; set; }
        public string TermAbbr { get; set; }
        public string TermName { get; set; }

        public Student Student { get; set; }
        public bool Done { get; set; }
    }
}