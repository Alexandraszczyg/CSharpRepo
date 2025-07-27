/*Create a medical bot application that can prescribe medication based on the patient's symptoms and age.*/


/*Part 2: Patient class
The Patient class should have the following fields:








Part 3: Main() method
This application will be used by patient users. The Main() method (entry point) should read all inputs (patient name, age, gender, medical history, symptoms etc.) from the patient and call "PrescribeMedication()" method of MedicalBot class and display the result prescription that was returned by the PrescribeMedication() method.

 */

using ClassLibrary1;
using System;
using System.Reflection.Emit;
using System.Security.Policy;

namespace MedicalBotPrescMedication
{
    public class Program
    {
        static void Main()
        {

            Console.Write("Hi, I'm ");
            Console.Write(MedicalBot.GetBotName());
            Console.Write(".I'm here to help you in your medication.");
           
            
            
            int x = 0;
            do
            {
                Patient p = new Patient();
                Console.WriteLine("Please input patient details:");

                
                string errorName;

                while (true)
                {
                    Console.WriteLine("Enter Patient Name:");
                    string nameInput = Console.ReadLine();

                    if (p.SetName(nameInput, out errorName))
                    {
                        Console.WriteLine("Name accepted: " + p.GetName());
                        break; // exit loop if valid
                    }
                    else
                    {
                        Console.WriteLine("Invalid name: " + errorName);
                        // Loop continues, asking user again
                    }
                }


                int ageInput;
                string errorAge;

                while (true)
                {
                    Console.Write("Enter your age: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out ageInput))
                    {
                        if (p.SetAge(ageInput, out errorAge))
                        {
                            Console.WriteLine("Age accepted: " + p.GetAge());
                            break; // Exit loop on valid input
                        }
                        else
                        {
                            Console.WriteLine("Invalid age: " + errorAge);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                string errorGender;
          
                while (true)
                {
                
                    Console.WriteLine("Enter Patient's Gender:");
                    string genderInput = Console.ReadLine();
                    if (p.SetGender(genderInput, out errorGender))
                    {
                        Console.WriteLine("Gender accepted " + p.GetGender());
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid gender: " + errorGender);
                       
                    }

                }




                Console.WriteLine("Enter Medical History. Eg: Diabetes. If there is none press ENTER or write 'None':");
                string medhis = Console.ReadLine();
                p.SetMedHis(medhis);

           
                Console.WriteLine("Welcome " + p.GetName() + ", " + p.GetAge() + ".");


            symptomlabel:
                Console.WriteLine("Which of the following symptoms do you have:\nS1.Headache \nS2. Skin rashes \n S3. Dizziness. \n Enter the symptom code from above list(S1, S2 or S3)");

                string sym;
                sym = Console.ReadLine();
              
                string errorSymptom;
                while (true)
                {
                    

                    if (p.SetSymptomCode(sym, out errorSymptom))
                    {
                        Console.WriteLine("Symptom accepted.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid symptom: " + errorSymptom);
                        goto symptomlabel;
                    }
                }
                
             
            
                    Console.WriteLine("Your symptom was recognized as: " + p.GetSymptoms());

                

                MedicalBot bot = new MedicalBot();
                Console.WriteLine(bot.PrescribeMedication(p)+"was prescribed to a patient: "+p.GetName()+", "+p.GetAge());

                Console.WriteLine("Thank you for using "+ MedicalBot.GetBotName() +".");
               
                Console.WriteLine("Do you wish to continue to the next patient?\n 0 = yes \n1 = no");
               x = Convert.ToInt32(Console.ReadLine());
            }
            while (x == 0);

            Console.WriteLine("Press any key to leave the application.");

            Console.ReadKey();
        }
    }
}
