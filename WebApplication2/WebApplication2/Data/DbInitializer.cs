using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //for Degree Requirement - MEHAR CHOUDHARY
            if (context.DegreeRequirements.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new DegreeRequirement[]
                {
                    new DegreeRequirement { DegreeID = 1, DegreeAbbr = "ACS+2", NumberOfTerms= 5 },
                    new DegreeRequirement { DegreeID = 2, DegreeAbbr = "ACS+DB", NumberOfTerms= 5 },
                    new DegreeRequirement { DegreeID = 3, DegreeAbbr = "ACS+NF", NumberOfTerms= 5},
                    new DegreeRequirement { DegreeID = 4, DegreeAbbr = "ACS", NumberOfTerms= 5 },
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
                var credit = new Credits[]
                {
                    new Credits {CreditID=460, CreditName="Databases", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=356, CreditName="Network Fundamentals", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=542, CreditName="OOPS with Java", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=563, CreditName="Web Apps", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=560, CreditName="Advanced Databases", IsSummer=1, IsSpring=1, IsFall=1},
                    new Credits {CreditID=664, CreditName="User Experience", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=618, CreditName="Project Management", IsSummer=1, IsSpring=0, IsFall=0},
                    new Credits {CreditID=555, CreditName="Network Security", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=691, CreditName="GDP1", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=692, CreditName="GDP2", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=6, CreditName="643 or 644 Mobile", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=10, CreditName="Elective 1", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credits {CreditID=20, CreditName="Elective 2", IsSummer=0, IsSpring=1, IsFall=1},
                };
                Console.WriteLine($"Inserted {credit.Length} new credits.");

                foreach (Credits d in credit)
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
                    new DegreeCredit {DegreeCreditID=1, DegreeID=1, CreditID=460},
                    new DegreeCredit {DegreeCreditID=2, DegreeID=1, CreditID=356},
                    new DegreeCredit {DegreeCreditID=3, DegreeID=1, CreditID=542},
                    new DegreeCredit {DegreeCreditID=4, DegreeID=1, CreditID=563},
                    new DegreeCredit {DegreeCreditID=5, DegreeID=1, CreditID=560},
                    new DegreeCredit {DegreeCreditID=6, DegreeID=1, CreditID=664},
                    new DegreeCredit {DegreeCreditID=7, DegreeID=1, CreditID=618},
                    new DegreeCredit {DegreeCreditID=8, DegreeID=1, CreditID=555},
                    new DegreeCredit {DegreeCreditID=9, DegreeID=1, CreditID=691},
                    new DegreeCredit {DegreeCreditID=10, DegreeID=1, CreditID=692},
                    new DegreeCredit {DegreeCreditID=11, DegreeID=1, CreditID=6},
                    new DegreeCredit {DegreeCreditID=12, DegreeID=1, CreditID=10},
                    new DegreeCredit {DegreeCreditID=13, DegreeID=1, CreditID=20},
                    new DegreeCredit {DegreeCreditID=14, DegreeID=2, CreditID=460},
                    new DegreeCredit {DegreeCreditID=15, DegreeID=2, CreditID=542},
                    new DegreeCredit {DegreeCreditID=16, DegreeID=2, CreditID=563},
                    new DegreeCredit {DegreeCreditID=17, DegreeID=2, CreditID=560},
                    new DegreeCredit {DegreeCreditID=18, DegreeID=2, CreditID=664},
                    new DegreeCredit {DegreeCreditID=19, DegreeID=2, CreditID=618},
                    new DegreeCredit {DegreeCreditID=20, DegreeID=2, CreditID=555},
                    new DegreeCredit {DegreeCreditID=21, DegreeID=2, CreditID=691},
                    new DegreeCredit {DegreeCreditID=22, DegreeID=2, CreditID=692},
                    new DegreeCredit {DegreeCreditID=23, DegreeID=2, CreditID=6},
                    new DegreeCredit {DegreeCreditID=24, DegreeID=2, CreditID=10},
                    new DegreeCredit {DegreeCreditID=25, DegreeID=2, CreditID=20},
                    new DegreeCredit {DegreeCreditID=26, DegreeID=3, CreditID=356},
                    new DegreeCredit {DegreeCreditID=27, DegreeID=3, CreditID=542},
                    new DegreeCredit {DegreeCreditID=28, DegreeID=3, CreditID=563},
                    new DegreeCredit {DegreeCreditID=29, DegreeID=3, CreditID=560},
                    new DegreeCredit {DegreeCreditID=30, DegreeID=3, CreditID=664},
                    new DegreeCredit {DegreeCreditID=31, DegreeID=3, CreditID=618},
                    new DegreeCredit {DegreeCreditID=32, DegreeID=3, CreditID=555},
                    new DegreeCredit {DegreeCreditID=33, DegreeID=3, CreditID=691},
                    new DegreeCredit {DegreeCreditID=34, DegreeID=3, CreditID=692},
                    new DegreeCredit {DegreeCreditID=35, DegreeID=3, CreditID=6},
                    new DegreeCredit {DegreeCreditID=36, DegreeID=3, CreditID=10},
                    new DegreeCredit {DegreeCreditID=37, DegreeID=3, CreditID=20},
                    new DegreeCredit {DegreeCreditID=38, DegreeID=4, CreditID=542},
                    new DegreeCredit {DegreeCreditID=39, DegreeID=4, CreditID=563},
                    new DegreeCredit {DegreeCreditID=40, DegreeID=4, CreditID=560},
                    new DegreeCredit {DegreeCreditID=41, DegreeID=4, CreditID=664},
                    new DegreeCredit {DegreeCreditID=42, DegreeID=4, CreditID=618},
                    new DegreeCredit {DegreeCreditID=43, DegreeID=4, CreditID=555},
                    new DegreeCredit {DegreeCreditID=44, DegreeID=4, CreditID=691},
                    new DegreeCredit {DegreeCreditID=45, DegreeID=4, CreditID=692},
                    new DegreeCredit {DegreeCreditID=46, DegreeID=4, CreditID=6},
                    new DegreeCredit {DegreeCreditID=47, DegreeID=4, CreditID=10},
                    new DegreeCredit {DegreeCreditID=48, DegreeID=4, CreditID=20},

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
                    new DegreePlan {DegreePlanID=1234, StudentID=533904, DegreePlanAbbrev= "Slow and Easy", DegreePlanName= "Without Summer", DegreeRequirementID=4},
                    new DegreePlan {DegreePlanID=1235, StudentID=533904, DegreePlanAbbrev= "Super Fast", DegreePlanName= "With Summer", DegreeRequirementID=4},
                    new DegreePlan {DegreePlanID=1239, StudentID=533489, DegreePlanAbbrev= "Super Fast", DegreePlanName= "With Summer", DegreeRequirementID=4},
                    new DegreePlan {DegreePlanID=1237, StudentID=533489, DegreePlanAbbrev= "Slow and Easy", DegreePlanName= "Without Summer", DegreeRequirementID=4},
                    new DegreePlan {DegreePlanID=1238, StudentID=533976, DegreePlanAbbrev= "Slow and Easy", DegreePlanName= "Without Summer", DegreeRequirementID=4},
                    new DegreePlan {DegreePlanID=1240, StudentID=533976, DegreePlanAbbrev= "Super Fast", DegreePlanName= "With Summer", DegreeRequirementID=4},
                    new DegreePlan {DegreePlanID=1240, StudentID=533714, DegreePlanAbbrev= "Super Fast", DegreePlanName= "With Summer", DegreeRequirementID=4},
                    new DegreePlan {DegreePlanID=1241, StudentID=533714, DegreePlanAbbrev= "Slow and Easy", DegreePlanName= "Without Summer", DegreeRequirementID=4},




                };
                Console.WriteLine($"Inserted {degreePlans.Length} new Degree Plans.");

                foreach (DegreePlan d in degreePlans)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }

            //for Student Id- Dasari
            if (context.StudentIds.Any())
            {
                Console.WriteLine("Students already exist.");
            }
            else
            {
                var students = new StudentId[]
                {
                    new StudentId {StudentID=533904, Family= "Peddi", Given= "Tarak", Snumber="S533904", N919 = 91957050},
                    new StudentId {StudentID=533976, Family= "Meenavilli", Given= "Mehar Choudhary", Snumber="S533976", N919 = 919571539},
                    new StudentId {StudentID=533489, Family= "Dasari", Given= "Venkat", Snumber="S533489", N919 = 919568241},
                    new StudentId {StudentID=533714, Family= "Valluru", Given= "Aakash", Snumber="S533714", N919 = 919568635},

                };
                Console.WriteLine($"Inserted {students.Length} new students.");

                foreach (StudentId d in students)
                {
                    context.StudentIds.Add(d);
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
                    new Slot {SlotID=1, DegreePlanID=1235, Term=1, CreditID=542, Status="C"},
                    new Slot {SlotID=2, DegreePlanID=1235, Term=1, CreditID=563, Status="C"},
                    new Slot {SlotID=3, DegreePlanID=1235, Term=1, CreditID=560, Status="C"},
                    new Slot {SlotID=4, DegreePlanID=1235, Term=2, CreditID=664, Status="A"},
                    new Slot {SlotID=5, DegreePlanID=1235, Term=2, CreditID=6, Status="A"},
                    new Slot {SlotID=6, DegreePlanID=1235, Term=2, CreditID=10, Status="A"},
                    new Slot {SlotID=7, DegreePlanID=1235, Term=3, CreditID=618, Status="P"},
                    new Slot {SlotID=8, DegreePlanID=1235, Term=3, CreditID=691, Status="P"},
                    new Slot {SlotID=9, DegreePlanID=1235, Term=4, CreditID=692, Status="P"},
                    new Slot {SlotID=10, DegreePlanID=1235, Term=4, CreditID=20, Status="P"},
                    new Slot {SlotID=11, DegreePlanID=1235, Term=4, CreditID=555, Status="P"},
                    new Slot {SlotID=12, DegreePlanID=1236, Term=1, CreditID=542, Status="A"},
                    new Slot {SlotID=13, DegreePlanID=1236, Term=1, CreditID=563, Status="A"},
                    new Slot {SlotID=14, DegreePlanID=1236, Term=1, CreditID=560, Status="A"},
                    new Slot {SlotID=15, DegreePlanID=1236, Term=2, CreditID=664, Status="P"},
                    new Slot {SlotID=16, DegreePlanID=1236, Term=2, CreditID=6, Status="P"},
                    new Slot {SlotID=17, DegreePlanID=1236, Term=2, CreditID=10, Status="P"},
                    new Slot {SlotID=18, DegreePlanID=1236, Term=3, CreditID=20, Status="P"},
                    new Slot {SlotID=19, DegreePlanID=1236, Term=3, CreditID=555, Status="P"},
                    new Slot {SlotID=20, DegreePlanID=1236, Term=3, CreditID=691, Status="P"},
                    new Slot {SlotID=21, DegreePlanID=1236, Term=4, CreditID=618, Status="P"},
                    new Slot {SlotID=22, DegreePlanID=1236, Term=4, CreditID=692, Status="P"},                
                    new Slot {SlotID=23, DegreePlanID=1239, Term=1, CreditID=542, Status="C"},
                    new Slot {SlotID=24, DegreePlanID=1239, Term=1, CreditID=563, Status="C"},
                    new Slot {SlotID=25, DegreePlanID=1239, Term=1, CreditID=560, Status="C"},
                    new Slot {SlotID=26, DegreePlanID=1239, Term=2, CreditID=664, Status="A"},
                    new Slot {SlotID=27, DegreePlanID=1239, Term=2, CreditID=6, Status="A"},
                    new Slot {SlotID=28, DegreePlanID=1239, Term=2, CreditID=10, Status="A"},
                    new Slot {SlotID=29, DegreePlanID=1239, Term=3, CreditID=618, Status="P"},
                    new Slot {SlotID=30, DegreePlanID=1239, Term=4, CreditID=691, Status="P"},
                    new Slot {SlotID=31, DegreePlanID=1239, Term=4, CreditID=20, Status="P"},
                    new Slot {SlotID=32, DegreePlanID=1239, Term=5, CreditID=692, Status="P"},
                    new Slot {SlotID=33, DegreePlanID=1239, Term=5, CreditID=555, Status="P"},
                    new Slot {SlotID=34, DegreePlanID=1240, Term=1, CreditID=542, Status="A"},
                    new Slot {SlotID=35, DegreePlanID=1240, Term=1, CreditID=563, Status="A"},
                    new Slot {SlotID=36, DegreePlanID=1240, Term=1, CreditID=560, Status="A"},
                    new Slot {SlotID=37, DegreePlanID=1240, Term=2, CreditID=664, Status="P"},
                    new Slot {SlotID=38, DegreePlanID=1240, Term=2, CreditID=6, Status="P"},
                    new Slot {SlotID=39, DegreePlanID=1240, Term=2, CreditID=10, Status="P"},
                    new Slot {SlotID=40, DegreePlanID=1240, Term=3, CreditID=20, Status="P"},
                    new Slot {SlotID=41, DegreePlanID=1240, Term=3, CreditID=555, Status="P"},
                    new Slot {SlotID=42, DegreePlanID=1240, Term=3, CreditID=691, Status="P"},
                    new Slot {SlotID=43, DegreePlanID=1240, Term=4, CreditID=618, Status="P"},
                    new Slot {SlotID=44, DegreePlanID=1240, Term=4, CreditID=692, Status="P"},

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
                    new  Term {StudentTermID=1, StudentID=533568, Term=1, TermAbbr="F18", TermName="Fall 2018"},
                    new Term {StudentTermID=2, StudentID=533568, Term=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new Term {StudentTermID=3, StudentID=533568, Term=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new Term {StudentTermID=4, StudentID=533568, Term=4, TermAbbr="F19", TermName="Fall 2019"},
                    new Term {StudentTermID=5, StudentID=533708, Term=1, TermAbbr="F18", TermName="Fall 2018"},
                    new Term {StudentTermID=6, StudentID=533708, Term=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new Term {StudentTermID=7, StudentID=533708, Term=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new Term {StudentTermID=8, StudentID=533708, Term=4, TermAbbr="F19", TermName="Fall 2019"},
                    new Term {StudentTermID=9, StudentID=533708, Term=5, TermAbbr="SP20", TermName="Spring 2020"},
                    new Term {StudentTermID=10, StudentID=533897, Term=1, TermAbbr="SP20", TermName="Spring 2020"},
                    new Term {StudentTermID=11, StudentID=533897, Term=2, TermAbbr="FA20", TermName="Fall 2020"},
                    new Term {StudentTermID=12, StudentID=533897, Term=3, TermAbbr="SP21", TermName="Spring 2021"},
                    new Term {StudentTermID=13, StudentID=533897, Term=4, TermAbbr="SU21", TermName="Summer 2021"},

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