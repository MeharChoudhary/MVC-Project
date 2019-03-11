using System;

namespace WebApplication.Models
{
    public class Term
    {
        public int StudentTermID{ get; set; }
        public int StudentID { get; set; }
        public int TermID { get; set; }
        public string TermAbbr { get; set; }
        public string TermName { get; set; }
       
    }
}