using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a struct and a class. Initialize variables of both types. 

//Create two methods to change the Values of formal arguments of struct type and class type respectively

//Verify the working of value type and reference type. 

namespace ProgrammingPractice_ValueTypesAndReferenceTypes
{
    struct Date

    {

        // data members / fields 

        int year;

        int day;

        int month;



        public int Year
        {

            get { return year; }

            set { year = value; }

        }



        public int Month

        {

            get { return month; }

            set { month = value; }

        }



        public int Day

        {

            get { return day; }

            set { day = value; }

        }

    }



    class Time

    {

        int hour;

        int minute;

        int second;



        public int Hour

        {

            get { return hour; }

            set { hour = value; }

        }



        public int Minute

        {

            get { return minute; }

            set { minute = value; }

        }



        public int Second

        {

            get { return second; }

            set { second = value; }

        }

    }



    internal class StructDemo

    {

        static void Main(string[] args)

        {

            Date date = new Date();



            date.Day = 1;

            date.Month = 2;

            date.Year = 2022;

            Console.WriteLine("Date.Day: ");
            Console.WriteLine(date.Day);
            changeDate(ref date);
            Console.WriteLine("After Changes: ");

            Console.WriteLine(date.Day); 



            Time time = new Time();
            time.Hour = 1;
            time.Minute = 2;
            time.Second = 3;

            Console.WriteLine("\nTime.Hour:");
            Console.WriteLine(time.Hour);
            changeTime(time);
            Console.WriteLine("After Changes: ");
            Console.WriteLine(time.Hour);

        }



        static void changeDate(ref Date d)

        {
            d.Day = 3;
        }

        static void changeTime(Time t)

        {
            t.Hour = 4;
        }

    }
}