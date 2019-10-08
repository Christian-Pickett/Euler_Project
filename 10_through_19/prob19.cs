/*Counting Sundays
https://projecteuler.net/problem=19

You are given the following information, but you may prefer to do some research for yourself
    1 Jan 1900 was a Monday.
    Thirty days has September,
    April, June and November.
    All the rest have thirty-one,
    Saving February alone,
    Which has twenty-eight, rain or shine.
    And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?*/

using System;

static class Program
{
    struct aMonth
    {
        public int MonthNumber;
        public int NumOfDays;
        public int CurrentDay;
    }

    public enum Weekday : int
    {
        MON = 0,
        TUE = 1,
        WED = 2,
        THU = 3,
        FRI = 4,
        SAT = 5,
        SUN = 6
    }

    public static void Main()
    {
        Weekday theWeekday = 0;
        aMonth theMonth;
        int SumOfFirstSundays = 0;
        int theYear = 1;
        theMonth.MonthNumber = 1;
        theMonth.CurrentDay = 1;

        for (int i = 0; i <= 36525; i++)
        {
            if (i % 7 == 0)
                theWeekday = 0;

            if (theMonth.MonthNumber == 1 | theMonth.MonthNumber == 3 | theMonth.MonthNumber == 5 | theMonth.MonthNumber == 7 | theMonth.MonthNumber == 8 | theMonth.MonthNumber == 10 | theMonth.MonthNumber == 12)
                theMonth.NumOfDays = 31;
            else if (theMonth.MonthNumber == 4 | theMonth.MonthNumber == 6 | theMonth.MonthNumber == 9 | theMonth.MonthNumber == 11)
                theMonth.NumOfDays = 30;
            else if (theYear % 4 == 0)
                theMonth.NumOfDays = 29;
            else
                theMonth.NumOfDays = 28;

            if (theMonth.CurrentDay == 1 & theWeekday == Program.Weekday.SUN)
                SumOfFirstSundays += 1;

            if (theMonth.CurrentDay == theMonth.NumOfDays)
            {
                theMonth.MonthNumber += 1;
                theMonth.CurrentDay = 1;

                if (theMonth.MonthNumber - 1 == 12)
                    theMonth.MonthNumber = 1;
            }
            else
                theMonth.CurrentDay += 1;

            theWeekday += 1;

            if (i % 365 == 0)
                theYear += 1;
        }
	Console.Write(SumOfFirstSundays.ToString() + "\n");
	//Answer: 171
    }
}

