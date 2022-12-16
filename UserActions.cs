using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FileIO14
{
    internal class UserActions
    {
        public enum Options
        {
            Create = 1,
            ViewInfo = 2,
            DeleteInfo = 3,
            Exit = 4
        };
        public Fresher fr;
        
        public UserActions() { }

        public void Menu()
        {
            FresherInformation fi = FresherInformation.Instance();
            Options option;
            fi.Loading();

            do
            {
                WriteLine(DisplayConstant.MENU_START);
                WriteLine(DisplayConstant.MENU_CREATE_FRESHER);
                WriteLine(DisplayConstant.MENU_VIEW_INFO);
                WriteLine(DisplayConstant.MENU_DELETE_INFO);
                WriteLine(DisplayConstant.MENU_EXIT);

                Enum.TryParse(ReadLine(), out option);

                switch (option)
                {
                    case Options.Create:
                        {
                            fr = fr ?? new Fresher();
                            fr.InputFresherInfo();
                            if(fi.Add(fr.StudentName, fr.BirthDate.ToString(), fr.StudentClass, fr.StudentSkill, fr.StudentSchool))
                            {
                                fi.Save();
                            }
                            break;
                        }
                        case Options.ViewInfo:
                        {
                            fi.Print();
                            break;
                        }
                    case Options.DeleteInfo:
                        {
                            fi.Remove(ReadLine());
                            fi.Save();
                            break;
                        }
                    case Options.Exit:
                        {
                            WriteLine(DisplayConstant.MENU_GOODBYE);
                            break;
                        }
                    default:
                        {
                            WriteLine(DisplayConstant.MENU_NOT_SUPPORT);
                            break;
                        }
                }
            }
            while (option != Options.Exit);
        }
    }
}
