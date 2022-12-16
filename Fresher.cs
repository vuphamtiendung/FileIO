using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FileIO14
{
    public class Fresher
    {
        private string _studentName;
        private DateTime _birthDate;
        private string _studentClass;
        private string _studentSkill;
        private string _studentSchool;
        private int _studentYearOld;

        public string StudentName { get => _studentName; set => _studentName = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public string StudentClass { get => _studentClass; set => _studentClass = value; }
        public string StudentSkill { get => _studentSkill; set => _studentSkill = value; }
        public string StudentSchool { get => _studentSchool; set => _studentSchool = value; }
        public int StudentYearOld { get => _studentYearOld; set => _studentYearOld = value; }

        public Fresher()
        {
            _studentName = string.Empty;
            _studentClass = string.Empty;
            _birthDate = DateTime.Now;
            _studentSkill = string.Empty;
            _studentSchool = string.Empty;
            _studentYearOld = 0;
        }

        public Fresher(string studentName, string birthDate, string studentClass, string studentSkill, string studentSchool)
        {
            _studentName = studentName;
            DateTime.TryParse(birthDate, out _birthDate);
            _studentClass = studentClass;
            _studentSkill = studentSkill;
            _studentSchool = studentSchool;
            _studentYearOld = DateTime.Now.Year - this._birthDate.Year;
        }

        public string InputField(string message)
        {
            WriteLine(message);
            return ReadLine();
        }

        public int CalYearOld() => DateTime.Now.Year - this._birthDate.Year;

        public void InputFresherInfo()
        {
            Clear();
            WriteLine(DisplayConstant.INPUT_MESSAGE);
            _studentName = InputField(DisplayConstant.INPUT_NAME_MESSAGE);
            DateTime.TryParse(InputField(DisplayConstant.INPUT_BIRTHDATE_MESSAGE), out _birthDate);
            _studentClass = InputField(DisplayConstant.INPUT_CLASS_MESSAGE);
            _studentSchool = InputField(DisplayConstant.INPUT_SCHOOL_MESSAGE);
            _studentSkill = InputField(DisplayConstant.INPUT_SKILL_MESSAGE);
            WriteLine(DisplayConstant.END_OF_PAGE_MESSAGE);
        }
    }
}
