using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageJsonWPF.Data
{
    public class Student
    {
        public string LastName { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string Patronymic { get; set; } = default!;
        public PassportInfoClass PassportInfo { get; set; } = default!;
        public string INN { get; set; } = default!;
        public string SNILLS { get; set; } = default!;
        public string SpecialityCode { get; set; } = default!;
        public string SpecialityName { get; set; } = default!;
        public byte CourseNumber { get; set;}
        public string GroupCode { get; set; } = default!;
        public EducationalOrganisationClass EducationalOrganisation { get; set; } = default!;
    }
}
