using System;

namespace WebApplication2.Models
{
    public class Slot
    {
        public int SlotID { get; set; }
        public int DegreePlanID{ get; set; }
        public int Term { get; set; }
        public int CreditID { get; set; }
        public string Status { get; set; }
       
    }
}