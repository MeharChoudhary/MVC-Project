using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Term
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId{ get; set; }
        public int StudentId { get; set; }
        public int TermId { get; set; }
        public string TermAbbr { get; set; }
        public string TermName { get; set; }
       
    }
}