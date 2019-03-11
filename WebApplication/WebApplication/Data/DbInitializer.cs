using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            //for Degree Requirement - MEHAR CHOUDHARY
            if (context.DegreeRequirements.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new DegreeRequirement[]
                {
                    new DegreeRequirement { DegreeId = 1, DegreeAbbr = "ACS+2", NumberOfTerms= 5 },
                    new DegreeRequirement { DegreeId = 2, DegreeAbbr = "ACS+DB", NumberOfTerms= 5 },
                    new DegreeRequirement { DegreeId = 3, DegreeAbbr = "ACS+NF", NumberOfTerms= 5},
                    new DegreeRequirement { DegreeId = 4, DegreeAbbr = "ACS", NumberOfTerms= 5 },
                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (DegreeRequirement d in degrees)
                {
                    context.DegreeRequirements.Add(d);
                }
                context.SaveChanges();
            }



            //for Credits - Aakash

            if (context.Credits.Any())
            {
                Console.WriteLine("Credits already exist.");
            }
            else
            {
                var credit = new Credit[]
                {
                    new Credit {CreditId=460, CreditName="Databases", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=356, CreditName="Network Fundamentals", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=542, CreditName="OOPS with Java", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=563, CreditName="Web Apps", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=560, CreditName="Advanced Databases", IsSummer=1, IsSpring=1, IsFall=1},
                    new Credit {CreditId=664, CreditName="User Experience", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=618, CreditName="Project Management", IsSummer=1, IsSpring=0, IsFall=0},
                    new Credit {CreditId=555, CreditName="Network Security", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=691, CreditName="GDP1", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=692, CreditName="GDP2", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=6, CreditName="643 or 644 Mobile", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=10, CreditName="Elective 1", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=20, CreditName="Elective 2", IsSummer=0, IsSpring=1, IsFall=1},
                };
                Console.WriteLine($"Inserted {credit.Length} new credits.");

                foreach (Credit d in credit)
                {
                    context.Credits.Add(d);
                }
                context.SaveChanges();
            }

            //for DegreeCredit - Mehar Choudhary

            if (context.DegreeCredits.Any())
            {
                Console.WriteLine("DegreeCredits already exist.");
            }
            else
            {
                var degreeCredits = new DegreeCredit[]
                {
                    new DegreeCredit {DegreeCreditId=1, DegreeId=1, CreditId=460},
                    new DegreeCredit {DegreeCreditId=2, DegreeId=1, CreditId=356},
                    new DegreeCredit {DegreeCreditId=3, DegreeId=1, CreditId=542},
                    new DegreeCredit {DegreeCreditId=4, DegreeId=1, CreditId=563},
                    new DegreeCredit {DegreeCreditId=5, DegreeId=1, CreditId=560},
                    new DegreeCredit {DegreeCreditId=6, DegreeId=1, CreditId=664},
                    new DegreeCredit {DegreeCreditId=7, DegreeId=1, CreditId=618},
                    new DegreeCredit {DegreeCreditId=8, DegreeId=1, CreditId=555},
                    new DegreeCredit {DegreeCreditId=9, DegreeId=1, CreditId=691},
                    new DegreeCredit {DegreeCreditId=10, DegreeId=1, CreditId=692},
                    new DegreeCredit {DegreeCreditId=11, DegreeId=1, CreditId=6},
                    new DegreeCredit {DegreeCreditId=12, DegreeId=1, CreditId=10},
                    new DegreeCredit {DegreeCreditId=13, DegreeId=1, CreditId=20},
                    new DegreeCredit {DegreeCreditId=14, DegreeId=2, CreditId=460},
                    new DegreeCredit {DegreeCreditId=15, DegreeId=2, CreditId=542},
                    new DegreeCredit {DegreeCreditId=16, DegreeId=2, CreditId=563},
                    new DegreeCredit {DegreeCreditId=17, DegreeId=2, CreditId=560},
                    new DegreeCredit {DegreeCreditId=18, DegreeId=2, CreditId=664},
                    new DegreeCredit {DegreeCreditId=19, DegreeId=2, CreditId=618},
                    new DegreeCredit {DegreeCreditId=20, DegreeId=2, CreditId=555},
                    new DegreeCredit {DegreeCreditId=21, DegreeId=2, CreditId=691},
                    new DegreeCredit {DegreeCreditId=22, DegreeId=2, CreditId=692},
                    new DegreeCredit {DegreeCreditId=23, DegreeId=2, CreditId=6},
                    new DegreeCredit {DegreeCreditId=24, DegreeId=2, CreditId=10},
                    new DegreeCredit {DegreeCreditId=25, DegreeId=2, CreditId=20},
                    new DegreeCredit {DegreeCreditId=26, DegreeId=3, CreditId=356},
                    new DegreeCredit {DegreeCreditId=27, DegreeId=3, CreditId=542},
                    new DegreeCredit {DegreeCreditId=28, DegreeId=3, CreditId=563},
                    new DegreeCredit {DegreeCreditId=29, DegreeId=3, CreditId=560},
                    new DegreeCredit {DegreeCreditId=30, DegreeId=3, CreditId=664},
                    new DegreeCredit {DegreeCreditId=31, DegreeId=3, CreditId=618},
                    new DegreeCredit {DegreeCreditId=32, DegreeId=3, CreditId=555},
                    new DegreeCredit {DegreeCreditId=33, DegreeId=3, CreditId=691},
                    new DegreeCredit {DegreeCreditId=34, DegreeId=3, CreditId=692},
                    new DegreeCredit {DegreeCreditId=35, DegreeId=3, CreditId=6},
                    new DegreeCredit {DegreeCreditId=36, DegreeId=3, CreditId=10},
                    new DegreeCredit {DegreeCreditId=37, DegreeId=3, CreditId=20},
                    new DegreeCredit {DegreeCreditId=38, DegreeId=4, CreditId=542},
                    new DegreeCredit {DegreeCreditId=39, DegreeId=4, CreditId=563},
                    new DegreeCredit {DegreeCreditId=40, DegreeId=4, CreditId=560},
                    new DegreeCredit {DegreeCreditId=41, DegreeId=4, CreditId=664},
                    new DegreeCredit {DegreeCreditId=42, DegreeId=4, CreditId=618},
                    new DegreeCredit {DegreeCreditId=43, DegreeId=4, CreditId=555},
                    new DegreeCredit {DegreeCreditId=44, DegreeId=4, CreditId=691},
                    new DegreeCredit {DegreeCreditId=45, DegreeId=4, CreditId=692},
                    new DegreeCredit {DegreeCreditId=46, DegreeId=4, CreditId=6},
                    new DegreeCredit {DegreeCreditId=47, DegreeId=4, CreditId=10},
                    new DegreeCredit {DegreeCreditId=48, DegreeId=4, CreditId=20},

                };
                Console.WriteLine($"Inserted {degreeCredits.Length} new degree credits.");

                foreach (DegreeCredit d in degreeCredits)
                {
                    context.DegreeCredits.Add(d);
                }
                context.SaveChanges();
            }


            //for DegreePlan - Aakash

            if (context.DegreePlans.Any())
            {
                Console.WriteLine("Degree Plans already exist.");
            }
            else
            {
                var degreePlans = new DegreePlan[]
                {
                    new DegreePlan {DegreePlanId=1234, StudentId=533904, DegreePlanAbbrev= "Slow and Easy", DegreePlanName= "Without Summer", DegreeRequirementId=4},
                    new DegreePlan {DegreePlanId=1235, StudentId=533904, DegreePlanAbbrev= "Super Fast", DegreePlanName= "With Summer", DegreeRequirementId=4},
                    new DegreePlan {DegreePlanId=1239, StudentId=533489, DegreePlanAbbrev= "Super Fast", DegreePlanName= "With Summer", DegreeRequirementId=4},
                    new DegreePlan {DegreePlanId=1237, StudentId=533489, DegreePlanAbbrev= "Slow and Easy", DegreePlanName= "Without Summer", DegreeRequirementId=4},
                    new DegreePlan {DegreePlanId=1238, StudentId=533976, DegreePlanAbbrev= "Slow and Easy", DegreePlanName= "Without Summer", DegreeRequirementId=4},
                    new DegreePlan {DegreePlanId=1236, StudentId=533976, DegreePlanAbbrev= "Super Fast", DegreePlanName= "With Summer", DegreeRequirementId=4},
                    new DegreePlan {DegreePlanId=1240, StudentId=533714, DegreePlanAbbrev= "Super Fast", DegreePlanName= "With Summer", DegreeRequirementId=4},
                    new DegreePlan {DegreePlanId=1241, StudentId=533714, DegreePlanAbbrev= "Slow and Easy", DegreePlanName= "Without Summer", DegreeRequirementId=4},




                };
                Console.WriteLine($"Inserted {degreePlans.Length} new Degree Plans.");

                foreach (DegreePlan d in degreePlans)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }

            //for Student Id- Dasari
            if (context.Students.Any())
            {
                Console.WriteLine("Students already exist.");
            }
            else
            {
                var students = new Student[]
                {
                    new Student {StudentId=533904, Family= "Peddi", Given= "Tarak", Snumber="S533904", N919 = 91957050},
                    new Student {StudentId=533976, Family= "Meenavilli", Given= "Mehar Choudhary", Snumber="S533976", N919 = 919571539},
                    new Student {StudentId=533489, Family= "Dasari", Given= "Venkat", Snumber="S533489", N919 = 919568241},
                    new Student {StudentId=533714, Family= "Valluru", Given= "Aakash", Snumber="S533714", N919 = 919568635},

                };
                Console.WriteLine($"Inserted {students.Length} new students.");

                foreach (Student d in students)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }

            //for Slot - Raviteja

            if (context.Slots.Any())
            {
                Console.WriteLine("Slots already exist.");
            }
            else
            {
                var slots = new Slot[]
                {
                    new Slot {SlotId=1, DegreePlanId=1235, TermId=1, CreditId=542, Status="C"},
                    new Slot {SlotId=2, DegreePlanId=1235, TermId=1, CreditId=563, Status="C"},
                    new Slot {SlotId=3, DegreePlanId=1235, TermId=1, CreditId=560, Status="C"},
                    new Slot {SlotId=4, DegreePlanId=1235, TermId=2, CreditId=664, Status="A"},
                    new Slot {SlotId=5, DegreePlanId=1235, TermId=2, CreditId=6, Status="A"},
                    new Slot {SlotId=6, DegreePlanId=1235, TermId=2, CreditId=10, Status="A"},
                    new Slot {SlotId=7, DegreePlanId=1235, TermId=3, CreditId=618, Status="P"},
                    new Slot {SlotId=8, DegreePlanId=1235, TermId=3, CreditId=691, Status="P"},
                    new Slot {SlotId=9, DegreePlanId=1235, TermId=4, CreditId=692, Status="P"},
                    new Slot {SlotId=10, DegreePlanId=1235, TermId=4, CreditId=20, Status="P"},
                    new Slot {SlotId=11, DegreePlanId=1235, TermId=4, CreditId=555, Status="P"},
                    new Slot {SlotId=12, DegreePlanId=1236, TermId=1, CreditId=542, Status="A"},
                    new Slot {SlotId=13, DegreePlanId=1236, TermId=1, CreditId=563, Status="A"},
                    new Slot {SlotId=14, DegreePlanId=1236, TermId=1, CreditId=560, Status="A"},
                    new Slot {SlotId=15, DegreePlanId=1236, TermId=2, CreditId=664, Status="P"},
                    new Slot {SlotId=16, DegreePlanId=1236, TermId=2, CreditId=6, Status="P"},
                    new Slot {SlotId=17, DegreePlanId=1236, TermId=2, CreditId=10, Status="P"},
                    new Slot {SlotId=18, DegreePlanId=1236, TermId=3, CreditId=20, Status="P"},
                    new Slot {SlotId=19, DegreePlanId=1236, TermId=3, CreditId=555, Status="P"},
                    new Slot {SlotId=20, DegreePlanId=1236, TermId=3, CreditId=691, Status="P"},
                    new Slot {SlotId=21, DegreePlanId=1236, TermId=4, CreditId=618, Status="P"},
                    new Slot {SlotId=22, DegreePlanId=1236, TermId=4, CreditId=692, Status="P"},                
                    new Slot {SlotId=23, DegreePlanId=1239, TermId=1, CreditId=542, Status="C"},
                    new Slot {SlotId=24, DegreePlanId=1239, TermId=1, CreditId=563, Status="C"},
                    new Slot {SlotId=25, DegreePlanId=1239, TermId=1, CreditId=560, Status="C"},
                    new Slot {SlotId=26, DegreePlanId=1239, TermId=2, CreditId=664, Status="A"},
                    new Slot {SlotId=27, DegreePlanId=1239, TermId=2, CreditId=6, Status="A"},
                    new Slot {SlotId=28, DegreePlanId=1239, TermId=2, CreditId=10, Status="A"},
                    new Slot {SlotId=29, DegreePlanId=1239, TermId=3, CreditId=618, Status="P"},
                    new Slot {SlotId=30, DegreePlanId=1239, TermId=4, CreditId=691, Status="P"},
                    new Slot {SlotId=31, DegreePlanId=1239, TermId=4, CreditId=20, Status="P"},
                    new Slot {SlotId=32, DegreePlanId=1239, TermId=5, CreditId=692, Status="P"},
                    new Slot {SlotId=33, DegreePlanId=1239, TermId=5, CreditId=555, Status="P"},
                    new Slot {SlotId=34, DegreePlanId=1240, TermId=1, CreditId=542, Status="A"},
                    new Slot {SlotId=35, DegreePlanId=1240, TermId=1, CreditId=563, Status="A"},
                    new Slot {SlotId=36, DegreePlanId=1240, TermId=1, CreditId=560, Status="A"},
                    new Slot {SlotId=37, DegreePlanId=1240, TermId=2, CreditId=664, Status="P"},
                    new Slot {SlotId=38, DegreePlanId=1240, TermId=2, CreditId=6, Status="P"},
                    new Slot {SlotId=39, DegreePlanId=1240, TermId=2, CreditId=10, Status="P"},
                    new Slot {SlotId=40, DegreePlanId=1240, TermId=3, CreditId=20, Status="P"},
                    new Slot {SlotId=41, DegreePlanId=1240, TermId=3, CreditId=555, Status="P"},
                    new Slot {SlotId=42, DegreePlanId=1240, TermId=3, CreditId=691, Status="P"},
                    new Slot {SlotId=43, DegreePlanId=1240, TermId=4, CreditId=618, Status="P"},
                    new Slot {SlotId=44, DegreePlanId=1240, TermId=4, CreditId=692, Status="P"},

                };
                Console.WriteLine($"Inserted {slots.Length} new slots.");

                foreach (Slot d in slots)
                {
                    context.Slots.Add(d);
                }
                context.SaveChanges();
            }

            //for StudentTerm - Raviteja
            if (context.Terms.Any())
            {
                Console.WriteLine("Student Terms already exist.");
            }
            else
            {
                var studentTerms = new Term[]
                {
                    new  Term {StudentTermId=1, StudentId=533568, TermId=1, TermAbbr="F18", TermName="Fall 2018"},
                    new Term {StudentTermId=2, StudentId=533568, TermId=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new Term {StudentTermId=3, StudentId=533568, TermId=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new Term {StudentTermId=4, StudentId=533568, TermId=4, TermAbbr="F19", TermName="Fall 2019"},
                    new Term {StudentTermId=5, StudentId=533708, TermId=1, TermAbbr="F18", TermName="Fall 2018"},
                    new Term {StudentTermId=6, StudentId=533708, TermId=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new Term {StudentTermId=7, StudentId=533708, TermId=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new Term {StudentTermId=8, StudentId=533708, TermId=4, TermAbbr="F19", TermName="Fall 2019"},
                    new Term {StudentTermId=9, StudentId=533708, TermId=5, TermAbbr="SP20", TermName="Spring 2020"},
                    new Term {StudentTermId=10, StudentId=533897, TermId=1, TermAbbr="SP20", TermName="Spring 2020"},
                    new Term {StudentTermId=11, StudentId=533897, TermId=2, TermAbbr="FA20", TermName="Fall 2020"},
                    new Term {StudentTermId=12, StudentId=533897, TermId=3, TermAbbr="SP21", TermName="Spring 2021"},
                    new Term {StudentTermId=13, StudentId=533897, TermId=4, TermAbbr="SU21", TermName="Summer 2021"},

                };
                Console.WriteLine($"Inserted {studentTerms.Length} new student terms.");

                foreach (Term d in studentTerms)
                {
                    context.Terms.Add(d);
                }
                context.SaveChanges();
            }


        }

    }
}