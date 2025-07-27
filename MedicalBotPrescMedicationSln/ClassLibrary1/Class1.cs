using System;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;


namespace ClassLibrary1
{
    public class MedicalBot
    {
        public const string botName = "BoB";

        public static string GetBotName()
        {
            return botName;
        }

        public string PrescribeMedication(Patient patient)
        {
            string mediName;
            if (patient.GetSymptoms()=="Headache")
            { mediName = "Ibuprofen"; }
            else if (patient.GetSymptoms() == "Skin rashes")
            { mediName = "Diphenhydramine"; }
            else if (patient.GetSymptoms() =="Dizziness")
            { 
                if (patient.GetMedHis() =="Diabietes")
                {
                    mediName = "Metformin";
                }
                else { mediName = "Dimenhydrinate";}
            }
                
            else { mediName = "Unknown"; }

            string result = " "+GetDosage(mediName, patient) +" "+ mediName+" ";
            patient.SetPrescription(result);
            return patient.GetPrescription();
         

            

        }
        string GetDosage(string medicineName,Patient patient)
        {
           
            
            string dosage;
            if (medicineName == "Ibuprofen")
            {
                if (patient.GetAge() < 18)
                { dosage = "400mg"; }
                else
                { dosage = "800mg"; }
            }
            else if (medicineName == "Diphenhydramine")
            {
                if (patient.GetAge() < 18)
                { dosage = "50mg"; }
                else
                { dosage = "300mg"; }

            }
            else if (medicineName == "Dimenhydrinate")
            {
                if (patient.GetAge() < 18)
                { dosage = "50mg"; }
                else
                { dosage = "400mg"; }
            }
            else
            { dosage = "500mg"; }

          return dosage;
        }
    }

    public class Patient
    {
        /* GetName(): Returns the name of the patient.

SetName(string name, out string errorMessage): Sets the name of the patient and validates it. Returns a bool indicating whether the name is valid or not, and an error message if it's invalid. The name should not be null or empty. Patient name should contain at least two or more characters.*/
        private string _name;
        
          public string GetName()
            { return _name; }
          public bool SetName(string name, out string errorMessage)
         {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 2 || !name.All(char.IsLetter))
            {
                errorMessage = "Name must contain only letters and at least 2 characters long.";
                return false;
            }
            else
            {
                _name = name;
                errorMessage = "";
                return true;

            }
                
          }

        /*GetAge(): Returns the age of the patient.

SetAge(int age, out string errorMessage): Sets the age of the patient and validates it. Returns a bool indicating whether the age is valid or not, and an error message if it's invalid. Patient age can't be negative. Patient age can't be greater than 100.

*/
        private int _age;
        public int GetAge()
        { return _age; }
        public bool SetAge(int age,out string errorMessage)
        {
            if(age <0||age >115)
            {
                errorMessage = "Age can't be negative or more than 115.";
                return false;
            }

            _age = age;
            errorMessage = "";
            return true;

        }


        /*GetGender(): Returns the gender of the patient.

 SetGender(string gender, out string errorMessage): Sets the gender of the patient and validates it. Returns a bool indicating whether the gender is valid or not, and an error message if it's invalid. Patient gender should be either Male, Female or Other
 */
        private string _gender;
        public string GetGender()
        {
            return _gender;
        }
        public bool SetGender(string gender, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(gender))
            {
                errorMessage = "Gender cannot be empty.";
                return false;
            }

            gender = gender.Trim();

            if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase) ||
                gender.Equals("Male", StringComparison.OrdinalIgnoreCase) ||
                gender.Equals("Other", StringComparison.OrdinalIgnoreCase))
            {
                _gender = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(gender.ToLower()); // Capitalize
                errorMessage = "";
                
                return true;
            }

            errorMessage = "Invalid gender. Please enter 'Male', 'Female', or 'Other'.";
            return false;
        }









        //SetMedicalHistory(string medicalHistory): Sets the medical history of the patient. No specific validations need to be checked for this value.
        private string _medicalHistory;
        
        public void SetMedHis(string medicalHistory)
        {
           _medicalHistory = medicalHistory;

        }
        public string GetMedHis()
        { return _medicalHistory; }
        /*SetSymptomCode(string symptomCode, out string errorMessage) : Sets the symptom code of the patient.Symptom Code should either be S1, S2, or S3.

GetSymptoms(): Returns the symptom description based on the current value of 'symptomCode' field.

S1 / s1: Headache

S2 / s2: Skin rashes

S3 / s3: Dizziness

Any other value: Unknown*/
        private string _symptomCode;
        public bool SetSymptomCode(string symptomCode, out string errorMessage)
        {
            if (symptomCode == "S1" || symptomCode == "s1")
            {
                _symptomCode=symptomCode;
                errorMessage = "";
                return true;

            }
            else if(symptomCode == "S2" || symptomCode == "s2")
            {

                _symptomCode = symptomCode;
                errorMessage = "";
                return true;
            }

            else if (symptomCode == "S3" || symptomCode == "s3")
            {

                _symptomCode = symptomCode;
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "The code of the symptom is incorrect.";
                return false;
            }
            


        }

        public string GetSymptoms()
        {
            string symptom;
            if (_symptomCode =="S1" || _symptomCode == "s1")
            {
                symptom = "Headache";
                return symptom;
            }
            else if (_symptomCode == "S2" || _symptomCode == "s2")
            {
                symptom = "Skin rashes";
                return symptom;
            }
            else if (_symptomCode == "S3" || _symptomCode == "s3")
            {
                symptom = "Dizziness";
                return symptom;
            }
            else 
            {
                symptom = "Unknown";
                return symptom;
            }
                
            

        }

        private string _prescription;

        

        public void SetPrescription(string prescription)
        {
            _prescription=prescription;
        }
        public string GetPrescription()
        {

            return _prescription;
        }
        /*GetPrescription() : Returns the medication prescribed to the patient.

SetPrescription(string prescription): Sets the medication prescribed to the patient.No specific validations need to be checked for this value.*/
    }
}
