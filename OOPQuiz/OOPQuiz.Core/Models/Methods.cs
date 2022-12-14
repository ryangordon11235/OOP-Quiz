using System;
using System.Collections.Generic;

namespace OOPQuiz.Core.Models
{
    /// <summary>
    /// Project unique methods.
    /// </summary>
    /// <remarks>
    /// Accessible to the entire project.
    /// </remarks>
    public static class Methods
    {
        private static Random rng = new Random();

        /// <summary>
        /// Makes the first character of a string upper case.
        /// </summary>
        /// <param name="str">The string to be capitalised.</param>
        /// <returns>
        /// The string with the first character converted to upper case.
        /// </returns>
        /// <remarks>
        /// String should be trimmed before passed into this method.
        /// </remarks>
        public static string Capitalise(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            else if (str.Length == 1)
            {
                return str.ToUpper();
            }

            return char.ToUpper(str[0]).ToString() + string.Join("", new ArraySegment<char>(str.ToCharArray(), 1, str.Length - 1));
        }

        /// <summary>
        /// Shuffles a list in place.
        /// </summary>
        /// <typeparam name="T">The generic type.</typeparam>
        /// <param name="list">The sequence of objects to shuffle.</param>
        /// <remarks>
        /// Based on the Fisher-Yates Shuffle, retrieved from https://stackoverflow.com/questions/273313/randomize-a-listt.
        /// </remarks>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;

            while (n > 1)
            {
                n--;

                int k = rng.Next(n + 1);

                (list[n], list[k]) = (list[k], list[n]);
            }
        }

        /// <summary>
        /// Converts a <see cref="TimeSpan"/> to a formatted string.
        /// </summary>
        /// <param name="timeSpan">The <see cref="TimeSpan"/> to convert into a string.</param>
        /// <returns>A string in the format hh:mm:ss.</returns>
        /// <remarks>
        /// Hours are only returned if they are present.
        /// </remarks>
        public static string ConvertTimeSpanToString(TimeSpan timeSpan)
        {
            return $"{(timeSpan.Hours == 0 ? string.Empty : $"{timeSpan.Hours}:")}" +
                $"{(timeSpan.Minutes.ToString().Length == 2 ? timeSpan.Minutes : $"0{timeSpan.Minutes}")}:" +
                $"{(timeSpan.Seconds.ToString().Length == 2 ? timeSpan.Seconds : $"0{timeSpan.Seconds}")}";
        }
    }
}
