using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Slot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }
        public int DegreePlanId{ get; set; }
        public int TermId { get; set; }
        public int CreditId { get; set; }
        public string Status { get; set; }
       
    }
}