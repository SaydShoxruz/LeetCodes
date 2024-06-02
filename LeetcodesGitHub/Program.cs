namespace LeetcodesGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static Dictionary<char, int> romanDigits = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        static int RomanToInt(string s)
        {
            var result = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (romanDigits[s[i]] < romanDigits[s[i + 1]])
                    result -= romanDigits[s[i]];
                else
                    result += romanDigits[s[i]];
            }

            return result + romanDigits[s[s.Length - 1]];
        }
        static bool IsAnagram(string s, string t)
        {
            bool returner = false;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < t.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        returner = true;
                    }
                }
                if (!returner) return false;
            }
            return true;
        }
        static int NumberOfPairs(int[] nums1, int[] nums2, int k)
        {
            int output = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] % (nums2[j] * k) == 0) output++;
                }
            }
            return output;
        }
    }
}
