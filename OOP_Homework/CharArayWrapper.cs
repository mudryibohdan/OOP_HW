using System;
namespace OOP_Homework
{
    public class CharArrayWrapper
    {
        private char[] array;
        private int vowelCount;

        public CharArrayWrapper(char[] inputArray)
        {
            array = new char[inputArray.Length];
            vowelCount = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                array[i] = inputArray[i];
                if (IsVowel(inputArray[i]))
                {
                    vowelCount++;
                }
            }
        }
        public char this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                    throw new IndexOutOfRangeException($"Індекс за межами масиву");
                return Char.ToUpper(array[index]);
            }
            set
            {
                if (index < 0 || index >= array.Length)
                    throw new IndexOutOfRangeException($"Індекс за межами масиву");
                if (IsVowel(array[index])) vowelCount--;
                array[index] = value;
                if (IsVowel(value)) vowelCount++;
            }
        }
        public int VowelCount
        {
            get { return vowelCount; }
        }
        private bool IsVowel(char c)
        {
            char lower = Char.ToLower(c);
            return "aeiouаеєиіїоуюя".Contains(lower);
        }
    }
}