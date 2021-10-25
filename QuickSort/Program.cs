using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 9, 12, 9, 2, 17, 1, 6 }; //объявление массива

            int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1); //объявление отсортированного массива

            Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}"); //вывод отсортированного массива

            Console.ReadLine();
        }

        private static int[] QuickSort(int[] array, int minIndex, int maxIndex) //метод сортировки
        {
            if (minIndex >= maxIndex) //выход из рекурсии
            {
                return array;
            }
            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex); //вызов метода GetPivotIndex

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex) //метод получения индекса элемента
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++) //цикл просмотра диапазона
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]); //меняем местами элементы массива
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }
        private static void Swap(ref int leftItem, ref int rightItem) //метод перестановки
        {
            int temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }
    }
}
