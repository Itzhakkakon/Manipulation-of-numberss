using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectMini
{
    class Program
    {
        static void Main(string[] args)//������� ����� �����
        {

        }
        static void input();//������ ����� 

        static bool Chahk(List<string> numstr);//������ ���� ����� �����

        static void PrintOInt(int num);//����� ���� 

        static void PrintOList(List<int> mylist);//����� ����
        static void MainOMenu();//����� ����� ������

        static int Maximom(List<int> mylist)//����� �������
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
        static int Minimom(List<int> mylist)//����� �������
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
        static int Sum(List<int> mylist);//����� ������� �����      
        static int AmountOfOrgans(List<int> mylist);//���� ������ �����
        static int Average(int numerator, int denominator);//����� ����� �����
        static void PrintOreverseOList(List<int> mylist);//����� ������ ����� ���� �� �� ���� �������
        static void SortOfromOlowOtoOhigh(List<int> mylist);//���� ������ �����

        static void MangInput();

        static void Menu();//����� ���� �� ������ �� ��� ����� ����� ���������
        static void Menger();//���� ���������

        static void ScreenCleaning();//������� ������ ��� ������� �� ����� ������ ������ ����� �����
        static void BackToMenu();//������� ���� �� ����� ��� ����� ������ �����
        static void Exit();//����� 
    }
}
