using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class DegreePlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanId { get; set; }
        public int StudentId { get; set; }
        public string DegreePlanAbbrev{ get; set; }
        public string DegreePlanName { get; set; }
        public int DegreeRequirementId{ get; set; }


    }
}