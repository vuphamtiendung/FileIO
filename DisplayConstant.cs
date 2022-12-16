using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FileIO14
{
    internal class DisplayConstant
    {
        #region
        public const string MENU_START = "Please choice function";
        public const string MENU_CREATE_FRESHER = "1. Create of add a new Fresher to file";
        public const string MENU_VIEW_INFO = "2. View information of Fresher in file";
        public const string MENU_DELETE_INFO = "3. Delete information of Fresher in file";
        public const string MENU_EXIT = "4. Exit program";

        public const string MENU_NOT_SUPPORT = "Program not support this function";
        public const string MENU_GOODBYE = "Goodbye, see you later";
        #endregion

        #region 
        public const string FRESHER_INFO_MESSAGE = "====================== Fresher information ======================";
        public const string TABLE_HEADER_FRESHER_INFO = "Name, BirthDate, School, ClassName, SkillName, YearOld";

        public const string INPUT_MESSAGE = "Please input fresher information";
        public const string INPUT_NAME_MESSAGE = "Name of Fresher";
        public const string INPUT_BIRTHDATE_MESSAGE = "Birthdate of Fresher";
        public const string INPUT_SCHOOL_MESSAGE = "School of Fresher";
        public const string INPUT_CLASS_MESSAGE = "Class of Fresher";
        public const string INPUT_SKILL_MESSAGE = "Skill of Fresher";

        public const string INPUT_YEAROLD_MESSAGE = "Year old of Fresher";
        public const string INPUT_DELETE_NAME = "Please input name of Fresher want to delete";

        public const string END_OF_PAGE_MESSAGE = "===================== Press any case to continue ==================";
        #endregion

        #region Error and warning and info message
        public const string ERROR_NOT_SAVE_ANY_INFO = "There are no saved information about your friends";
        public const string ERROR_CAN_NOT_FIND = "Can not find fresherInformation.dat file";
        public const string ERROR_CAN_NOT_SAVE = "Can not save fresherInformation.dat file";
        public const string ERROR_ALREADY_SAVE = "You had already added {0} before";
        public const string ERROR_CAN_NOT_FILE_INFO = "{0} had not been added before";
        public const string ERROR_CAN_NOT_REMOVE = "Unable to remove {0}";

        public const string EXCEPTION_INFO = "OH - We has a error";
        public const string ECEPTION_INFO_ERROR_CAN_NOT_SAVE = "Unable to save our friends' information";

        public const string SUCCESSFULL_ADD = "Fresher added successfully";
        public const string SUCCESSFULL_REMOVE = "{0} Fresher remove successfully";
        #endregion
    }
}
