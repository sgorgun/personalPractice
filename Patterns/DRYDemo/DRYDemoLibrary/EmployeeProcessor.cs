using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYDemoLibrary
{
    public class EmployeeProcessor
    {
        public string GenerateEmployeeID(string firstName, string lastName)
        {
            string employeeId = $@"{ GetPartOfName(firstName, 4) }{ GetPartOfName(lastName, 4) }{ DateTime.Now.Millisecond }";
            return employeeId;
        }

        private string GetPartOfName(string name, int numberOfCharacters)
        {
            string output = name;

            if (name.Length > numberOfCharacters)
            {
                output = name.Substring(0, numberOfCharacters);
            }
            else
            {
                do
                {
                    output += "X";
                } while (output.Length < 4);
            }

            return output;
        }
    }
}
