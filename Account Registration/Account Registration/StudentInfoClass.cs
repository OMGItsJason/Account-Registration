using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Account_Registration
{
    public class StudentInfoClass
    {
        public delegate string DelegateNumber(long number);
        public delegate string DelegateText(string text);

        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName(string firstName)
        {
            return FirstName;
        }

        public static string GetLastName(string lastName)
        {
            return LastName;
        }

        public static string GetMiddleName(string middleName)
        {
            return MiddleName;
        }

        public static string GetAddress(string address)
        {
           return Address;
        }

        public static string GetProgram(string program)
        {
            return Program;
        }

        public static long GetAge(long age)
        {
            return age;
        }

        public static long GetContactNo(long contactNo)
        {
            return contactNo;
        }

        public static long GetStudentNo(long studentNo)
        {
            return studentNo;
        }
    }
}