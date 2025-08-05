namespace Assignment_5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPalindrome("RaDAr")); // true
            Console.WriteLine(isPalindrome("RAdDar")); // true
            Console.WriteLine(isPalindrome("sonar")); // false
        }
        static bool isPalindrome(string s) 
        {
            s = s.ToLower();

            if (s.Length < 2) 
            { 
                return true;
            }

            if (s[0] != s[s.Length - 1]) 
            {
                return false;
            }

            string subString = s.Substring(1, s.Length-2);

            if (isPalindrome(subString)) 
            { 
                return true; 
            }
            return false;

        }
    }
}
