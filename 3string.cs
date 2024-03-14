using System;

namespace MyNameSpace {
    class StringExample {
        public void Process(){
            Console.WriteLine("STRING EXAMPLE -------------------------");
            // Single quotes
            Console.WriteLine("'spam eggs'");    // 'spam eggs' single quotes
            Console.WriteLine("\"doesn't\"");   // "doesn't" escape single quotes

            // New line
            string a = "baris1\nbaris2";        // new line
            Console.WriteLine(a);
            // baris1
            // baris2

            Console.WriteLine(@"C:\\files\name"); // print row dan ga jadi new line

            // String beda indent
            Console.WriteLine(@"bebas
                sdgasjdf
                asdf
                    afsdf");

            // // Glued + repeat with * !behaviorjavascriptrepeat
            // Console.WriteLine(3 * "jaka" + "prima"); // jakajakajakaprima

            // Gabung tanpa operator !behaviorjavascript
            Console.WriteLine("jaka" + "prima");     // jakaprima

            // Output string array data !behaviorjavascript
            string str = "jako";
            Console.WriteLine(str[2]);                // k
            Console.WriteLine(str[str.Length - 1]);   // o
            Console.WriteLine(str.Substring(1, 2));   // ak string ambil dari index 1 dan ambil 3-1 = 2, ambil 2 data
            Console.WriteLine(str.Substring(0, 1) + str.Substring(3));  // jo

            // Length
            Console.WriteLine(str.Length);

            // Traverse
            string numbers = "123456789";
            Console.WriteLine(numbers.Substring(1, numbers.Length - 1).Where((c, index) => index % 2 == 0)); // '2468'
            Console.WriteLine(numbers.Substring(0, numbers.Length).Where((c, index) => index % 2 != 0));     // '13579'
            char[] charArray = numbers.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray)); // '987654321'
        }
    } 
}