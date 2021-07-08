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
            Console.WriteLine("PatientName\tHeight\tweight\tBmiValue\tResult");
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                for(int i=1;i<columns.Length;i++)
                {
                    string name = columns[0];
                    int height = int.Parse(columns[i]);
                    int weight = int.Parse(columns[i + 1]);                   
                    i++;
                   int bmiValue= BmiValueCalculationLib.BmiValueCalculationType.Calculator(height, weight);
                   string result= BmiValueValidatorLib.BmiValueValidatorType.CheckCondition(bmiValue);                   
                    Console.WriteLine(name+"\t\t"+height + "\t" + weight + "\t" + bmiValue + "\t\t" + result);
                }
                
                
                
            }

        }
    }
}
