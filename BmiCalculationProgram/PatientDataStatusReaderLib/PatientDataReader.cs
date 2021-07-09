using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDataStatusReaderLib
{
   public class PatientDataReader
    {
        
            public List<ModelsLib.PatientDataInfo> GetAllPatientsDetails(string path)
            {
                List<string> lines = GetAllLines(path);
                List<ModelsLib.PatientDataInfo> patientList = new List<ModelsLib.PatientDataInfo>();
                for (int i = 0; i <lines.Count; i++)
                {
                    ModelsLib.PatientDataInfo patientDataInfo = MapLineItemPatientObject(lines[i]);
                    patientList.Add(patientDataInfo);

                }
                return patientList;
            }

            private List<string> GetAllLines(string path)
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(path);
                List<string> lines = new List<string>();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lines.Add(line);
                }
                reader.Close();
                return lines;
            }

            private ModelsLib.PatientDataInfo MapLineItemPatientObject(string lineItem)
            {
                string[] lineItems = lineItem.Split(',');
                ModelsLib.PatientDataInfo patientData = new ModelsLib.PatientDataInfo();
                patientData.Name = lineItems[0];
                patientData.Height = Int32.Parse(lineItems[1]);
                patientData.Weight = Int32.Parse(lineItems[2]);
                return patientData;
            }

        }
    }

