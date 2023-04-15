using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreLib
{
    public class Utils
    {
        public string DateNameConverter(string name, DateTime dateTime)
        {
            if (String.IsNullOrWhiteSpace(name)) 
                return "Ошибка, имя не распознано";
            string[] splitedName = name.Split(' ');
            string convertedString = splitedName[0] + "_" + splitedName[1][0] + "."
                + splitedName[2][0] + "." + "_" + dateTime.ToString("MM.dd.yyyy_HH_mm");
            return convertedString;
        }

        public string DateNameConverter(string lastName, string firstName, string middleName, DateTime dateTime)
        {
            if (String.IsNullOrWhiteSpace(lastName))
                return "Ошибка, фамилия не распознана";

            if (String.IsNullOrWhiteSpace(firstName))
                return "Ошибка, имя не распознано";

            if (String.IsNullOrWhiteSpace(middleName))
                return "Ошибка, отчество не распознано";

            string convertedString = lastName + "_" + firstName[0] + "." + middleName[0] + "." + "_" + dateTime.ToString("MM.dd.yyyy_HH_mm");
            return convertedString;
        }
    }
}
