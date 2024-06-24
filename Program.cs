namespace Assignment_7._1._2_Merge_Two_Strings_Alternating
{
    internal class Program
    {

        static string MergeStrings (string string1, string string2)
        {
            string result = "";

            // for every index in the strings
            for (int i = 0;  i < string1.Length || i < string2.Length; i++) 
            {
                // choose the ith character of the first string (if it exists)
                if (i < string1.Length)
                    result += string1[i];

                // choose the ith character of the second string (if it exists)
                if (i < string2.Length)
                    result += string2[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            string string1 = "Ian";
            string string2 = "Noah";
            // var to store final string
            //string result = "";
            //MergeStrings(string1 , string2, result);
            Console.WriteLine(MergeStrings(string1, string2));
        }
    }
}
