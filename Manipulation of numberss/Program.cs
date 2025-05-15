using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectMini
{
    class Program
    {
        static void Main(string[] args)//פונקצית הפעלת מערכת
        {

        }
        static void input();//אינפוט משתמש 

        static bool Chahk(List<string> numstr);//בדיקות השמה לליסט והמרה

        static void PrintOInt(int num)//הדפסת מספר 
        {
            Console.WriteLine(num);
        }
        static void PrintOList(List<int> mylist);//הדפסת ליסט
        static void MainOMenu();//הדפסת תפריט למשתמש

        static int Maximom(List<int> mylist)//מציאת מקסימום
        {
            int max = 0;
            foreach (int arg in mylist)
            {
                if (arg > max)
                {
                    max = arg;
                }
            }
            return max;
        }
        static int Minimom(List<int> mylist)//מציאת מינימום
        {
            int min = mylist[0];
            foreach (int arg in mylist)
            {
                if (arg < min)
                {
                    min = arg;
                }
            }
            return min;
        }
        static int Sum(List<int> mylist)//סכימת האיברים בסדרה
        {
            int sum = 0;
            foreach (int arg in mylist)
            {
                sum += arg;
            }
            return sum;
        }
        static int AmountOfOrgans(List<int> mylist)//כמות איברים בסדרה
        {
            int count = 0;
            foreach (int arg in mylist)
            {
                count++;
            }
            return count;
        }
        static int Average(int numerator, int denominator)//מציאת ממוצע הסדרה
        {
            int average = 0;
            average = numerator / denominator;
            return average;
        }
        static void PrintOreverseOList(List<int> mylist);//הדפסה ברוורס אפשרי לשים את זה בתוך הסוויטש
        static void SortOfromOlowOtoOhigh(List<int> mylist)//מיון מהנמוך לגבוה
        {
            List<int> sortedList = new List<int>(mylist);
            sortedList.Sort();
            PrintOList(sortedList);
        }
        static void MangInput();

        static void Menu();//מדפיס למסך את התפריט כל פעם ועובר למנהל הסוויטשים
        static void Menger();//מנהל הסוויטשים

        static void ScreenCleaning();//פונקציה לניקוי מסך הטרמינל כך שיוצג התוצאה שנבחרה בצורה נקייה
        static void BackToMenu();//פונקציה בסוף כל תוצאה כדי לחזור לתפריט הראשי
        static void Exit();//יציאה 
    }
}
