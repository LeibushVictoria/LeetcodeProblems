namespace Problems
{
    public class PalindromeNumber 
    {
        public bool IsPalindrome(int x) {
            string str1 = x.ToString();
            char[] arr = str1.ToCharArray(0, str1.Length);

            string str2 = "";

            bool result = false;

            for (int i = str1.Length - 1; i >= 0; i--)
                str2 = str2 + arr[i];

            if (str1 == str2)
                result = true;

            return result;
        }
    }
}
