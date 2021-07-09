using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculationApllication
{
   public static class PatientDetailsFromFile
    {
        public static void FileInput()
        {
            string path = @"C:\Users\hemanth.p\Desktop\bmicalculation.txt";
            ConsoleMessageDisplayLib.ConsoleMessageDisplayType.Display("PatientName\tHeight\tweight\tBmiValue\tResult");
            PatientDataStatusReaderLib.PatientDataReader pateint = new PatientDataStatusReaderLib.PatientDataReader();
           
            List<ModelsLib.PatientDataInfo> patients = pateint.GetAllPatientsDetails(path);
            for (int i = 0; i <patients.Count; i++)
            {
                ModelsLib.PatientDataInfo dataInfo = patients[i];
                

                int bmiValue = BmiValueCalculationLib.BmiValueCalculationType.Calculator(dataInfo.Height, dataInfo.Weight);
                string result = BmiValueValidatorLib.BmiValueValidatorType.CheckCondition(bmiValue);
                ConsoleMessageDisplayLib.ConsoleMessageDisplayType.Display(dataInfo.Name + "\t\t" + dataInfo.Height + "\t" + dataInfo.Weight + "\t" + bmiValue + "\t\t" + result);
            }

        }
                
            }

        }
    

