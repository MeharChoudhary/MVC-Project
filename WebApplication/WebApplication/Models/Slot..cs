using System;

namespace WebApplication.Models
{
    public class Slot
    {
        public int SlotID { get; set; }
        public int DegreePlanID{ get; set; }
        public int TermID { get; set; }
        public int CreditID { get; set; }
        public string Status { get; set; }
       
    }
}