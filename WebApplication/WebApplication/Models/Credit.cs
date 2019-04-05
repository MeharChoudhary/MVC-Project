using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Credit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditId { get; set; }
        public string CreditName { get; set; }
        public int IsSummer { get; set; }
        public int IsSpring { get; set; }
        public int IsFall { get; set; }
        public bool Done { get; set; }
    }
}