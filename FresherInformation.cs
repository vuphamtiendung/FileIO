using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using static System.Console;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO14
{
    internal class FresherInformation
    {
        public Dictionary<String, Fresher> fresherDictionary; // Data Structure
        public readonly BinaryFormatter binaryFormatter; // exchange a byte and write on the Stream
        public const string DATA_FILENAME = "E:\\fresherInfor.dat"; // string connect file
        public static FresherInformation fresherInformation; 
        public Fresher fr = new Fresher();
        
        /// <summary>
        /// Constructor
        /// </summary>
        public FresherInformation()
        {
            fresherDictionary = new Dictionary<string, Fresher>();
            binaryFormatter = new BinaryFormatter();
        }

        /// <summary>
        /// Declare object FresherInformation
        /// </summary>
        /// <returns></returns>
        public static FresherInformation Instance()
        {
            if(fresherInformation == null)
            {
                fresherInformation = new FresherInformation();
            }
            return fresherInformation;
        }

        public bool Loading()
        {
            if (File.Exists(DATA_FILENAME))
            {
                try
                {
                    using (FileStream readFileStream = new FileStream(DATA_FILENAME, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader reader = new BinaryReader(readFileStream))
                        {
                            fr.StudentName = reader.ReadString();
                            fr.StudentClass = reader.ReadString();
                            fr.StudentSkill = reader.ReadString();
                            fr.StudentSchool = reader.ReadString();
                            fr.StudentYearOld = reader.ReadInt32();
                        }
                    }

                    /*FileStream readFileStream = new FileStream(DATA_FILENAME, FileMode.Open, FileAccess.Read);
                    fresherDictionary = new Dictionary<String, Fresher>();
                    binaryFormatter.Deserialize(readFileStream);
                    readFileStream.Close(); */
                    return true;
                }
                catch(Exception ex)
                {
                    WriteLine(DisplayConstant.EXCEPTION_INFO);
                    WriteLine(ex.Message);
                    return false;
                }
            }
            else
            {
                WriteLine(DisplayConstant.ERROR_CAN_NOT_FIND);
                return false;
            }
        }

        public bool Add(string studentName, string birthDate, string studentClass, string studentSkill, string studentSchool)
        {
            if(fresherDictionary.ContainsKey(studentName))
            {
                WriteLine(String.Format(DisplayConstant.ERROR_ALREADY_SAVE));
                return false;
            }
            else
            {
                this.fresherDictionary.Add(studentName, new Fresher(studentName, birthDate, studentClass, studentSkill, studentSchool));
                WriteLine(String.Format(DisplayConstant.SUCCESSFULL_ADD, studentName));
                return true;
            }
        }

        public bool Remove(string studentName)
        {
            if (!fresherDictionary.ContainsKey(studentName))
            {
                WriteLine(String.Format(DisplayConstant.ERROR_CAN_NOT_FIND, studentName));
                return false;
            }
            else
            {
                this.fresherDictionary.Remove(studentName);
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                using (FileStream writerFileStream = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write))
                {
                    using (BinaryWriter writer = new BinaryWriter(writerFileStream))
                    {
                        writer.Write(fr.StudentName);
                        writer.Write(fr.BirthDate.ToString());
                        writer.Write(fr.StudentClass);
                        writer.Write(fr.StudentSkill);
                        writer.Write(fr.StudentSchool);
                        writer.Write(fr.StudentYearOld);
                    }
                }

                /*FileStream writerFileStream = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                binaryFormatter.Serialize(writerFileStream, this.fresherDictionary);
                writerFileStream.Close();*/
                return true;
            }
            catch(Exception ex)
            {
                WriteLine(DisplayConstant.ERROR_CAN_NOT_SAVE);
                WriteLine(ex.Message);
                return false;
            }
        }

        public void Print()
        {
            if(this.fresherDictionary.Count > 0)
            {
                WriteLine(DisplayConstant.TABLE_HEADER_FRESHER_INFO);
                foreach(Fresher fr in fresherDictionary.Values)
                {
                    WriteLine($"{fr.StudentName}, {fr.BirthDate}, {fr.StudentClass}, {fr.StudentSkill}. {fr.StudentSchool}. {fr.StudentYearOld}");
                }
                WriteLine(DisplayConstant.END_OF_PAGE_MESSAGE);
            }
            else
            {
                WriteLine(DisplayConstant.ERROR_NOT_SAVE_ANY_INFO);
                WriteLine(DisplayConstant.END_OF_PAGE_MESSAGE);
            }
        }
    }
}
