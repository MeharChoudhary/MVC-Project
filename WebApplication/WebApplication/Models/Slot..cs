using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Slot
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }
        public int DegreePlanId { get; set; }
        public int Term { get; set; }
        public int CreditId { get; set; }
        public string Status { get; set; }

        public DegreePlan DegreePlan { get; set; }

        public Credit Credit { get; set; }
        public bool Done { get; set; }



    }
}