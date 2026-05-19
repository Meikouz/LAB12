using System;
using System.Text.RegularExpressions;

namespace LAB12
{
    public static class TextAnalyzer
    {
        public static int CountIntegers(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            string pattern = @"(?<![\p{L}\p{N}])(?<!\d[.,])[-+]?\d+(?![.,]\d)(?![\p{L}\p{N}])";

            return Regex.Matches(text, pattern).Count;
        }
    }
}

// Метод для перевірки, до написання коду
//{
 //  public static class TextAnalyzer
   // {
     //   public static int CountIntegers(string text)
       // {
         //   throw new NotImplementedException();
        //}
    //}
//}