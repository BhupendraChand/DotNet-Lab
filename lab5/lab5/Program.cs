using System;
namespace lab5
{
    internal class Program
    { 
            public class q1
            {
                private string name;
                private float price;
                private string specialist;

                public void SetDetails(string doctorName, float doctorprice, string specialist)
                {
                    name = doctorName;
                    price = doctorprice;
                this.specialist = specialist;
                }

                public void DisplayDetails()
                {
                    Console.WriteLine($"Name = {name}");
                    Console.WriteLine($"Price = {price}");
                    Console.WriteLine($"Specialization: {specialist}");
                }

                public void ConsultPatient()
                {
                    Console.WriteLine($"The Doctor .{name} is consulting.");
                }
            }

            public class Doctor
            {
                public static void Main()
                {
                  q1 doctor = new q1();

                    doctor.SetDetails("Bhupendra Chand", 50000, "Brain");
                    doctor.DisplayDetails();
                    doctor.ConsultPatient();
                    Console.ReadKey();
                }
            }
        }
    }

