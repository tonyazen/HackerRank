using System.Collections.Generic;

namespace Braces
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = "{}[]()";
            var string2 = "{[}]}";
            var string3 = "[{()}]";
            var string4 = "}[{}()]";
            var string5 = "{[()[]]}";
            var string6 = "{[}]";
            var string7 = "[{)]";
            var values = new string[] { string1, string2, string3, string4, string5, string6, string7 };
            braces(values);
        }

        static string[] braces(string[] values)
        {
            var answer = new List<string>();

            const char openA = '{';
            const char closeA = '}';
            const char openB = '[';
            const char closeB = ']';
            const char openC = '(';
            const char closeC = ')';

            foreach (var value in values)
            {
                char[] array = value.ToCharArray();
                var isOpenBrace = false;
                var isOpenA = false;
                var isOpenB = false;
                var isOpenC = false;
                var isCloseBrace = false;
                var isCloseA = false;
                var isCloseB = false;
                var isCloseC = false;
                var isBalanced = true;
                if (array[0] == closeA || array[0] == closeB || array[0] == closeC)
                {
                    isBalanced = false;
                }
                if (array.Length % 2 > 0)
                {
                    isBalanced = false;
                }
                if (isBalanced)
                {
                    for (var i = 0; i < array.Length; i++)
                    {
                        isOpenA = array[i] == openA;
                        isOpenB = array[i] == openB;
                        isOpenC = array[i] == openC;
                        isOpenBrace = isOpenA || isOpenB || isOpenC;
                        isCloseA = array[i] == closeA;
                        isCloseB = array[i] == closeB;
                        isCloseC = array[i] == closeC;
                        isCloseBrace = isCloseA || isCloseB || isCloseC;

                        if (isOpenBrace)
                        {
                            if (isOpenA)
                            {
                                if (array[i + 1] == closeA)
                                {
                                    isBalanced = true;
                                }
                                else
                                {
                                    var closingBracePosition = array.Length - (i + 1);
                                    if (closingBracePosition > array.Length)
                                    {
                                        isBalanced = false;
                                        break;
                                    }
                                    if (array[closingBracePosition] == closeA)
                                    {
                                        isBalanced = true;
                                    }
                                    else
                                    {
                                        isBalanced = false;
                                        break;
                                    }
                                }
                            }
                            if (isOpenB)
                            {
                                if (array[i + 1] == closeB)
                                {
                                    isBalanced = true;
                                }
                                else
                                {
                                    var closingBracePosition = array.Length - (i + 1);
                                    if (closingBracePosition > array.Length)
                                    {
                                        isBalanced = false;
                                        break;
                                    }
                                    if (array[closingBracePosition] == closeB)
                                    {
                                        isBalanced = true;
                                    }
                                    else
                                    {
                                        isBalanced = false;
                                        break;
                                    }
                                }
                            }
                            if (isOpenC)
                            {
                                if (array[i + 1] == closeC)
                                {
                                    isBalanced = true;
                                }
                                else
                                {
                                    var closingBracePosition = array.Length - (i + 1);
                                    if (closingBracePosition > array.Length)
                                    {
                                        isBalanced = false;
                                        break;
                                    }
                                    if (array[closingBracePosition] == closeC)
                                    {
                                        isBalanced = true;
                                    }
                                    else
                                    {
                                        isBalanced = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (isBalanced)
                    answer.Add("YES");
                else
                    answer.Add("NO");
            }

            return answer.ToArray();
        }
    }
}
