using System;

namespace StringManipulator
{
    public class StringManipulator
    {
        public string Revert(string S)
        {
            string result = "";
            for (int i = 0; i < S.Length; i++)
            {
                result += S[S.Length - 1 - i];
            }
            return result;
        }
        public string CapsFix(string S)
        {
            if (String.Equals(S, S.ToUpper())) 
            {
                return S;
            }
            else 
            {
                return S[0].ToString().ToUpper() + S.Substring(1).ToLower(); 
            }
        }
    }
}
