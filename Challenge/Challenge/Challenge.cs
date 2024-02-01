using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Challenge
{
 public class calleng
    {
        public static double[] arrayRoot(double[] arr)
        {
            double[] result = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = Math.Sqrt(arr[i]);
            }

            return result;

        }
        public static string[] findPrefix(string[] words, string text)
        {
            List<string> matchingWords = new List<string>();

            foreach (string word in words)
            {
                if (word.StartsWith(text.ToLower(), StringComparison.OrdinalIgnoreCase))
                {
                    matchingWords.Add(word);
                }
            }

            if (matchingWords.Count == 0)
            {
                return new string[] { "No matches found" };
            }

            return matchingWords.ToArray();
        }
        public static void SortA(int[] array)
        {
           
            int n = array.Length;
          
            for (int i = 0; i < n - 1; i++)
            {
           
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public static int[] sortArray(int[] elementsArray)
        {
            for (int i = 0; i < elementsArray.Length; i++)
            {
                for (int j = i + 1; j < elementsArray.Length; j++)
                {
                    if (elementsArray[i] > elementsArray[j])
                    {
                        int temp = elementsArray[i];
                        elementsArray[i] = elementsArray[j];
                        elementsArray[j] = temp;

                    }
                }
            }
            return elementsArray;

        }
        public static string removeSpecialCharacters(string strParam)
        {
            string pattern = "[^a-zA-Z0-9- ._]";
            string result = Regex.Replace(strParam, pattern, "");

            return result;
        }
        public static int smallestNumber(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static int[] subArrays(int[] arr1, int[] arr2)
        {

            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("Error Array must have the same length ");
                return null;
            }
            int length = arr1.Length;
            int[] resultArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                resultArray[i] = arr1[i] - arr2[i];
            }

            return resultArray;
        }
        public static bool strLenComparison(string[] words)
        {
            if (words.Length <= 1)
            {
                return false;
            }
            int count = words[0].Length;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length != count)
                {
                    return false;
                }
            }
            return true;
        }

        public static string[] AddElement(string[] arr, string newElement)
        {

            string[] newArr = new string[arr.Length + 1];
            Array.Copy(arr, newArr, arr.Length);
            newArr[arr.Length] = newElement;
            return newArr;
        }
        public static string[] addFive(string[] arr)
        {
            if (arr.Length <= 0)
            {
                return arr;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += "5";
            }
            return arr;
        }

        public static int countWords(string txt)
        {
            string[] words = txt.Split(" ");
            int countWord = words.Length;
            return countWord;
        }
        public static string dateFormat(string date)
        {
            if (DateTime.TryParse(date, out DateTime parsedDate))
            {
                StringBuilder formattedDate = new StringBuilder();

                formattedDate.Append(parsedDate.ToString("M/d/yyyy") + " | ");
                formattedDate.Append(parsedDate.ToString("yyyy-M-d") + " | ");
                formattedDate.Append(parsedDate.ToString("yyyy/M/d"));
                return formattedDate.ToString();
            }
            else
            {
                return "Invalid date format";
            }
        }


        public static string reverseString(string input)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }
        public static int exponentCube(int number)
        {
            return (int)Math.Pow(number, 3);
        }
        public static int numberSum(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static string operation(int num1, int num2)
        {
            if (num2 != 0 && num1 / num2 == 24)
            {
                return "divided";
            }
            if (num1 * num2 == 24)
            {
                return "multiplied";
            }
            if (num1 + num2 == 24)
            {
                return "added";
            }
            if (num1 - num2 == 24 || num2 - num1 == 24)
            {
                return "subtracted";
            }
            else
            {
                return "None";
            }
        }
        public static string concatNames(string name1, string name2)
        {
            return name1 + ' ' + name2;
        }
        public static int LeftDigit(string strParam)
        {
            char[] arr = strParam.ToCharArray();

            foreach (var item in arr)
            {
                if (char.IsDigit(item))
                {

                    return Convert.ToInt32(item.ToString());
                }
            }
            return 0;
        }


        public static double squareRoot(double num)
        {
            if (num > 0)
            {
                return Math.Sqrt(num);
            }
            return 0;

        }


        public static int[] mergeAndOrder(int[] array1, int[] array2)
        {
            int Length = array2.Length + array1.Length;
            int[] mergedArray = new int[Length];

            for (int i = 0; i < array1.Length; i++)
            {
                mergedArray[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                mergedArray[array1.Length + i] = array2[i];
            }
            Array.Sort(mergedArray);
            return mergedArray;
        }
        public static int convertToSeconds(int hours)
        {
            if (hours > 0)
            {
                return hours * 3600;
            }
            else
            {
                return 0;
            }

        }
        public static int DecimalPlaces(string num)
        {
            string[] parts = num.Split(".");
            if (parts.Length == 2)
            {
                return parts[1].Length;
            }
            else
            {
                return 0;
            }
        }
        public static int repetitions(string s)
        {
            int maxValue = 0;
            int currentRepeat = 1;

            char[] arr = s.ToCharArray();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentRepeat += 1;
                }
                else
                {
                    maxValue = Math.Max(maxValue, currentRepeat);
                    currentRepeat = 1;
                }
            }
            return Math.Max(maxValue, currentRepeat);
        }
    }
}
