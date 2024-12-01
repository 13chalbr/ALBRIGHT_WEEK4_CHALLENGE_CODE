namespace ALBRIGHT_WEEK4_CHALLENGE_CODE
{
    internal class Program
    {
        //MSSA CCAD16 - CHRIS ALBRIGHT
        //26NOV2024
        //WEEK 4 CHALLENGE CODE

        static void Main(string[] args)

            //C4.1: Bypassing the problem due to instructor direction. 
        {
            //C4.2: Write a program in C# Sharp to count the frequency of each element of an array.

            Console.WriteLine("C4.2: Welcome to CharacterCounter!");
            char hold1;
            do
            {
                Console.WriteLine("\nEnter your String for character count:");
                string input = Console.ReadLine();
                Dictionary<char, int> CharCount = new Dictionary<char, int>();
                foreach (char c in input)
                {
                    if (CharCount.ContainsKey(c))
                    {
                        CharCount[c]++;
                    }
                    else
                    {
                        CharCount[c] = 1;
                    }
                }
                foreach (var item in CharCount)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                Console.WriteLine($"\nWant to go again? type y/n");
                hold1 = Convert.ToChar(Console.ReadLine());
            }
            while (hold1 == 'y');

            Console.WriteLine("\n\n///////////////////////////////////////////////////////////////////////////////////////////");

            //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
            //An input string is valid if:

            //Open brackets must be closed by the same type of brackets.
            //Open brackets must be closed in the correct order.
            //Every close bracket has a corresponding open bracket of the same type.

            Console.WriteLine("\nC4.3: Welcome to Bracket QA!");
            char hold2;
            do
            {
                Console.WriteLine("\nEnter your String for bracket analysis:");
                string inputString = Console.ReadLine();
                char[] charArray = inputString.ToCharArray();
                if (BracketsClosedChecker(charArray)==true)
                {
                    Console.WriteLine("\nValid Brackets!");
                }
                else
                {
                    Console.WriteLine("\nInvalid Brackets..have a care will ya?");
                }
                Console.WriteLine($"\nWant to go again? type y/n");
                hold2 = Convert.ToChar(Console.ReadLine());
            }
            while (hold2 == 'y');
            Console.WriteLine("\n\nGood Bye!");
        }

        //C4.3 Sub-Method checks
        static public bool BracketPairChecker(char open, char close)
        {
            return (open == '(' && close == ')') || (open == '[' && close == ']') || (open == '{' && close == '}');
        }

        //C4.3 Main Method checks 
        static public bool BracketsClosedChecker(char[] input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char topOfTheStackBracket = stack.Pop();
                    if (!BracketPairChecker(topOfTheStackBracket, c))
                    {
                        return false;
                    }
                }
                else
                {
                    // Let unwanted characters slip through the catch. Dont even need the else statement. 
                }
            }
            return true && stack.Count == 0;
        }
    }
}
