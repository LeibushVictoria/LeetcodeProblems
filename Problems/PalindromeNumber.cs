namespace Problems
{
    public class PalindromeNumber 
    {
        public bool IsPalindrome(int x) {
            string str1 = x.ToString();
            string str2 = "";

            for (int i = str1.Length - 1; i >= 0; i--)
                str2 = str2 + str1[i];

            if (str1 == str2)
                return true;

            return false;
        }
    }
}
