using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageJsonWPF.Data
{
    public class PassportInfoClass
    {
        /// <summary>
        /// Судя по всему задание нифига не на типы данных - смысла запариваться нет
        /// Где кавычки ставьте везде string - ну кроме дат разве что... Данные так просто идут
        /// </summary>
        public string SeriesNumber { get; set; } = default!;
        public string IssuingDepartment { get; set; } = default!;
        public DateTime Date { get; set; } = default!;
        public string DepartmentCode { get; set; } = default!;
        public RegistrationAdressClass RegistrationAdress { get; set; } = default!;
    }
}
