using Library_Management_System.Models;
using System.Collections.Generic;

namespace Library_Management_System.ViewModel
{
    public class RegistrationFormViewModel
    {
        public Registration Registration { get; set; }
        public IEnumerable<Department> StudentDepartment { get; set; }

        public IEnumerable<IndianStatesAndUnionTerritories> StatesAndUT { get; set; }

    }
}