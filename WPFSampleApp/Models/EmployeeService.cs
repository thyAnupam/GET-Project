using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class PatientService
    {
        public static List<Patient> PatientList;

        public PatientService()
        {
            PatientList = new List<Patient>()
            {
                new Patient{Id=101, Name="Harry", Age=34 },
                new Patient{Id=102, Name="Carry", Age=22 }
            };
        }

        public List<Patient> GetPatients()
        {
            return PatientList;
        }

        public bool AddPatient(Patient p)
        {
            PatientList.Add(p);
            return true;
        }

        public bool UpdatePatient(int id, Patient p)
        {
            for(int i = 0; i < PatientList.Count; i++)
            {
                if (PatientList[i].Id == id)
                {
                    PatientList[i] = p;
                }
            }
            
            return true;
        }

        public bool DeletePatient(int id)
        {
            for (int i = 0; i < PatientList.Count; i++)
            {
                if (PatientList[i].Id == id)
                {
                    PatientList.RemoveAt(i);
                }
            }

            return true;
        }
    }
}
