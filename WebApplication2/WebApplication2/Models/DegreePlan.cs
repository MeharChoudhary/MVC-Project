using System;

namespace WebApplication2.Models
{
    public class DegreePlan
    {
        public int DegreePlanID { get; set; }
        public int StudentID { get; set; }
        public string DegreePlanAbbrev{ get; set; }
        public string DegreePlanName { get; set; }
        public int DegreeRequirementID{ get; set; }


    }
}