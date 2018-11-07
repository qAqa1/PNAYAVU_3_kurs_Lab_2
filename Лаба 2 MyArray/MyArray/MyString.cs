using System;

namespace MyArray
{
    class MyString
    {
        protected char[] arr;
        public int Length => arr.Length;

        static public void SwapChar(ref char a, ref char b)
        {
            char c = a;
            a = b;
            b = c;
        }

        public bool MoreThen(MyString inputStr)
        {
            int Min = Math.Min(arr.Length, inputStr.arr.Length);

            for (int i = 0; i < Min; i++)
            {
                if (arr[i] < inputStr.arr[i])
                {
                    return (true);
                }

                if (arr[i] > inputStr.arr[i])
                {
                    return (false);
                }
            }

            if (arr.Length < inputStr.arr.Length)
            {
                return (true);
            }
            return (false);
        }

        public bool Equals(MyString str)
        {
            if(arr.Length != str.Length)
            {
                return (false);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != str.arr[i])
                {
                    return (false);
                }             
            }
            return (true);
        }

        public MyString Substring(int start_index)
        {
            int end_index = arr.Length - 1;
            char[] new_arr = new char[end_index + 1 - start_index];
            int x = 0;
            for (int i = start_index; i <= end_index; i++)
            {
                new_arr[x] = arr[i];
                x++;
            }
            return (new MyString(new_arr));
        }

        public MyString Substring(int start_index, int end_index)
        {
            char[] new_arr = new char[end_index + 1 - start_index];
            int x = 0;
            for (int i = start_index; i <= end_index; i++)
            {
                new_arr[x] = arr[i];
                x++;
            }
            return (new MyString(new_arr));
        }

        public MyString Remove(int start_index)
        {
            int end_index = arr.Length - 1;
            char[] new_arr = new char[arr.Length - end_index + 1 + start_index];
            int x = 0;
            for (int i = 0; i < start_index; i++)
            {
                new_arr[x] = arr[i];
                x++;
            }

            for (int i = end_index + 1; i < arr.Length; i++)
            {
                new_arr[x] = arr[i];
                x++;
            }
            return (new MyString(new_arr));
        }

        public MyString Remove(int start_index, int end_index)
        {
            char[] new_arr = new char[arr.Length - end_index +1  + start_index];
            int x = 0;
            for (int i = 0; i < start_index; i++)
            {
                new_arr[x] = arr[i];
                x++;
            }

            for (int i = end_index + 1 ; i < arr.Length; i++)
            {
                new_arr[x] = arr[i];
                x++;
            }
            return (new MyString(new_arr));
        }

        public MyString Reverse()
        {
            int start_index = 0;
            int end_index = arr.Length - 1;

            char[] new_arr = new char[arr.Length];
            for (int i = 0; i < start_index; i++)
            {
                new_arr[i] = arr[i];
            }

            for (int i = end_index; i < arr.Length; i++)
            {
                new_arr[i] = arr[i];
            }

            int x = 1;
            for (int i = start_index; i < end_index + 1; i++)
            {
                new_arr[start_index - 1 + x] = arr[end_index + 1 - x];
                x++;
            }
            return (new MyString(new_arr));
        }

        public MyString Reverse(int start_index, int end_index)
        {
            char[] new_arr = new char[arr.Length];
            for (int i = 0; i < start_index; i++)
            {
                new_arr[i] = arr[i];
            }

            for (int i = end_index; i < arr.Length; i++)
            {
                new_arr[i] = arr[i];
            }

            int x = 1;
            for (int i = start_index; i < end_index + 1; i++)
            {
                new_arr[start_index - 1 + x] = arr[end_index +1 - x];
                x++;
            }
            return (new MyString(new_arr));
        }

        public MyString Replace(char replaceable_char, char new_char)
        {
            int start_index = 0;
            int end_index = arr.Length - 1;

            char[] new_arr = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                new_arr[i] = arr[i];
            }
            for (int i = start_index; i <= end_index; i++)
            {
                if (arr[i] == replaceable_char)
                {
                    new_arr[i] = new_char;
                }
                else
                {
                    new_arr[i] = arr[i];
                }
            }
            return (new MyString(new_arr));
        }

        public MyString Replace(char replaceable_char, char new_char, int start_index, int end_index)
        {
            char[] new_arr = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                new_arr[i] = arr[i];
            }
            for (int i = start_index; i <= end_index; i++)
            {
                if (arr[i] == replaceable_char)
                {
                    new_arr[i] = new_char;
                }
                else
                {
                    new_arr[i] = arr[i];
                }
            }
            return (new MyString(new_arr));
        }

        public char this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public static explicit operator MyString(char ch)
        {
            return new MyString(ch);
        }

        public static explicit operator int(MyString str1)
        {
            string str2 = new string(str1.arr);
            return (Int32.Parse(str2));
        }

        public static implicit operator MyString(int i)
        {
            return new MyString(i.ToString());
        }

        public static implicit operator string(MyString str1)
        {
            return (new string(str1.arr));
        }

        public static implicit operator MyString(string str)
        {
            return new MyString(str);
        }

        public static MyString operator +(MyString string1, MyString string2)
        {
            string str1 = new string(string1.arr);
            string str2 = new string(string2.arr);
            return new MyString(str1 + str2);
        }

        public static bool operator ==(MyString string1, MyString string2)
        {
            return (string1.Equals(string2));
        }

        public static bool operator !=(MyString string1, MyString string2)
        {
            return (!string1.Equals(string2));
        }

        public static bool operator >(MyString string1, MyString string2)
        {
            return (string1.MoreThen(string2));
        }

        public static bool operator <(MyString string1, MyString string2)
        {
            return (string2.MoreThen(string1));
        }

        public MyString(int arrayLen)
        {
            arr = new char[arrayLen];
        }

        public MyString(int arrayLen , char allData)
        {
            arr = new char[arrayLen];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = allData;
            }
        }

        public MyString(String inputStr)
        {
            arr = new char[inputStr.Length];
            for (int i = 0; i < inputStr.Length; i++)
            {
                arr[i] = inputStr[i];
            }
        }

        public MyString(char[] inputArr)
        {
            arr = new char[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                arr[i] = inputArr[i];
            }
        }

        public MyString(char inputChar)
        {
            arr = new char[1];
            arr[0] = inputChar;
        }
    }
}