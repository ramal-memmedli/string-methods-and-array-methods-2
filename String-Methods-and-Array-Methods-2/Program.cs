using System;
using System.Text;

namespace String_Methods_and_Array_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        #region Concat
        /// <summary>
        /// Concatenates one or more instances of String.
        /// </summary>
        /// <param name="inputStringArray">Input string</param>
        /// <returns>A String</returns>
        public static string Concat(params string[] inputStringArray)
        {
            StringBuilder outputString = new StringBuilder();
            for (int i = 0; i < inputStringArray.Length; i++) outputString.Append(inputStringArray[i]);
            return outputString.ToString();
        }
        #endregion

        #region Join
        /// <summary>
        /// Joins string to another string with separator element
        /// </summary>
        /// <param name="separator">Separator element</param>
        /// <param name="inputStringArray">Input string</param>
        /// <returns>A String</returns>
        public static string Join(string separator, params string[] inputStringArray)
        {
            return Join(separator, 0, inputStringArray.Length, inputStringArray);
        }
        /// <summary>
        /// Joins string to another string with separator element
        /// </summary>
        /// <param name="separator">Separator element</param>
        /// <param name="startIndex">Start index</param>
        /// <param name="count">Count</param>
        /// <param name="inputStringArray">Input string</param>
        /// <returns>A String</returns>
        public static string Join(string separator, int startIndex, int count, params string[] inputStringArray)
        {
            StringBuilder outputString = new StringBuilder();
            for (int i = startIndex; i <= count - 1; i++)
            {
                if(i == count - 1)
                {
                    outputString.Append(inputStringArray[i]);
                }
                else
                {
                    outputString.Append(inputStringArray[i]).Append(separator);
                }
            }
            return outputString.ToString();
        }
        #endregion

        #region NullOrEmpty
        /// <summary>
        /// Checks if input string is null or empty.
        /// </summary>
        /// <param name="inputString">Input string</param>
        /// <returns>A bool type result</returns>
        public static bool IsNullOrEmpty(string inputString)
        {
            bool isNullOrEmpty;
            if (inputString == null || inputString == "")
            {
                isNullOrEmpty = true;
            }
            else
            {
                isNullOrEmpty = false;
            }
            return isNullOrEmpty;
        }
        #endregion
    }
}
