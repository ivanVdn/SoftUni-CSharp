namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a program that keeps track of the guests that are going to a house party. On the first line, of input you are going to receive the number of commands that will follow.
               On the next lines, you are going to receive some of the following:  "{name} is going!"
               •	You have to add the person, if they are not on the guestlist already.
               •	If the person is on the list print the following to the console: "{name} is already in the list!"
               "{name} is not going!"
               •	You have to remove the person, if they are on the list. 
               •	If not, print out: "{name} is not in the list!"
               Finally, print all of the guests, each on a new line.
                          
             */

            var n = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (var i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commands[2] == "going!")
                {
                    var index = guestList.IndexOf(commands[0]);
                    if (index != -1)
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(commands[0]);
                    }
                }
                else if (commands[2] == "not")
                {
                    var index = guestList.IndexOf(commands[0]);
                    if (index != -1)
                    {
                        guestList.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }

            }

            foreach (var name in guestList)
            {
                Console.WriteLine(name);
            }

        }
    }
}
