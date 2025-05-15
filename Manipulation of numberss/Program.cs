using System;
using System.Collections;
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
            MangInput();
        }
        static void input()//ינפוט משתמש 
        {
            mylist.Clear();
            List<string> numstr;
            do
            {
                Console.WriteLine("Enter positive numbers! Note that there must be a space between each element and a minimum of 3 elements.");
                numstr = Console.ReadLine().Split(" ").ToList();
            }
            while (!Chahk(numstr));
        }
        static bool Chahk(List<string> numstr)//בדיקות השמה לליסט והמרה
        {
            if (numstr.Count < 3)
            {
                return false;
            }
            int x;
            foreach (string stree in numstr)
            {
                if (!int.TryParse(stree, out x) || x < 0)
                {
                    return false;
                }
                mylist.Add(x);
            }
            return true;
        }
        static void PrintOInt(int num)//הדפסת מספר 
        {
            Console.WriteLine(num);
        }
        static void PrintOList(List<int> mylist)//הדפסת ליסט
        {
            foreach (int arg in mylist)
            {
                Console.WriteLine(arg);
            }
        }
        static void MainOMenu()//הדפסת תפריט למשתמש
        {
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("1. Replace the number series");
            Console.WriteLine("2. Print in order");
            Console.WriteLine("3. Reverse printing");
            Console.WriteLine("4. Sort from low to high");
            Console.WriteLine("5. Find maximum");
            Console.WriteLine("6. Find minimum");
            Console.WriteLine("7. Average of the numbers");
            Console.WriteLine("8. Sum of elements");
            Console.WriteLine("9. Value of all elements");
            Console.WriteLine("10. Exit");

        }
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
        static void PrintOreverseOList(List<int> mylist)//הדפסה ברוורס אפשרי לשים את זה בתוך הסוויטש
        {
            for (int i = AmountOfOrgans(mylist) - 1; i >= 0; i--)
            {
                PrintOInt(mylist[i]);
            }
        }
        static void SortOfromOlowOtoOhigh(List<int> mylist)//מיון מהנמוך לגבוה
        {
            List<int> sortedList = new List<int>(mylist);
            sortedList.Sort();
            PrintOList(sortedList);
        }
        static void MangInput()//ה-main קורא לפונקציה הזאת בכל הפעלה של המערכת
        {
            ScreenCleaning();
            Console.WriteLine("Welcome to the program!");
            input();
            Menu();
        }
        static void Menu()//מדפיס למסך את התפריט כל פעם ועובר למנהל הסוויטשים
        {

            MainOMenu();
            Menger();

        }
        static void Menger()//מנהל הסוויטשים
        {
            string choice = Console.ReadLine();
            ScreenCleaning();
            switch (choice)
            {
                case "1":
                    MangInput();
                    break;
                case "2":
                    PrintOList(mylist);
                    break;
                case "3":
                    PrintOreverseOList(mylist);
                    break;
                case "4":
                    SortOfromOlowOtoOhigh(mylist);
                    break;
                case "5":
                    int max = Maximom(mylist);
                    PrintOInt(max);
                    break;
                case "6":
                    int min = Minimom(mylist);
                    PrintOInt(min);
                    break;
                case "7":
                    int average = Average(Sum(mylist), AmountOfOrgans(mylist));
                    PrintOInt(average);
                    break;
                case "8":
                    int Organs = AmountOfOrgans(mylist);
                    PrintOInt(Organs);
                    break;
                case "9":
                    int sum = Sum(mylist);
                    PrintOInt(sum);
                    break;
                case "10":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            BackToMenu();
        }
        static void ScreenCleaning()//פונקציה לניקוי מסך הטרמינל כך שיוצג התוצאה שנבחרה בצורה נקייה
        {
            Console.Clear();
        }
        static void BackToMenu()//פונקציה בסוף כל תוצאה כדי לחזור לתפריט הראשי
        {
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            Menu();
        }
        static void Exit()//יציאה 
        {
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
        }
    }
}
