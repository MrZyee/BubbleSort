using System;

namespace BubleSort
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Algorithm algorithm = new Algorithm();
            int[] tab1 = { 1, 2, 5, 3, 1, 7, 9, 1, 12, 83, 1, 5, 3, 2 };
            int[] tab2 = { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1 };
            int[] tab3 = { 2, 2, 2, 2 };
            int[] tab4 = { 1, 2 };
            int[] tab5 = { 2, 1 };

            algorithm.BubbleSort(tab1);
            algorithm.BubbleSort(tab2);
            algorithm.BubbleSort(tab3);
            algorithm.BubbleSort(tab4);
            algorithm.BubbleSort(tab5);
        }
    }
}