namespace Problem2_ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> shoppingList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                var cmd = command.Split(" ").ToArray();
/*
Milk!Pepper!Salt!Water!Banana!Tomatoes!Potatoes!Bread
Unnecessary Banana
Urgent Tomatoes
Correct Pepper Onion
Correct Tomatoes Potatoes
Rearrange Grapes
Rearrange Potatoes

                */

                switch (cmd[0])
                {
                    case "Urgent": // Urgent {item} - add the item at the start of the list.  If the item already exists, skip this command.
                        if (!shoppingList.Contains(cmd[1]))
                        {
                            shoppingList.Insert(0, cmd[1]);
                        }

                        break;
                    case "Unnecessary": // Unnecessary {item} - remove the item with the given name, only if it exists in the list. Otherwise, skip this command.
                        if (shoppingList.Contains(cmd[1]))
                        {
                            shoppingList.Remove(cmd[1]);
                        }
                        break;
                    case "Correct": // Correct {oldItem} {newItem} - if the item with the given old name exists, change its name with the new one. Otherwise, skip this command.
                        if (shoppingList.Contains(cmd[1]))
                        {
                            var index = shoppingList.IndexOf(cmd[1]);
                            shoppingList.Remove(cmd[1]);
                            shoppingList.Insert(index, cmd[2]);
                        }
                        break;
                    case "Rearrange": // Rearrange {item} - if the grocery exists in the list, remove it from its current position and add it at the end of the list. Otherwise, skip this command.
                        if (shoppingList.Contains(cmd[1]))
                        {
                            shoppingList.Remove(cmd[1]);
                            shoppingList.Add(cmd[1]);
                        }
                        break;
                }

            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
