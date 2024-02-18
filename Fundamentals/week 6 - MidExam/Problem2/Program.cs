var friendList = Console.ReadLine()?
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

var blacklisted = new List<string>();
string? command;
while ((command = Console.ReadLine()) != "Report")
{
    var cmd = command?
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    var index = 0;
    switch (cmd?[0])
    {
        case "Blacklist":
            var name = cmd[1];
            if (friendList != null && !friendList.Contains(name))
            {
                Console.WriteLine($"{name} was not found.");
            }
            else
            {
                if (friendList == null) { break; }
                index = friendList.IndexOf(name);
                friendList.RemoveAt(index);
                friendList.Insert(index, "Blacklisted");
                blacklisted.Add(name);
                Console.WriteLine($"{name} was blacklisted.");
            }
            break;
        case "Error":
            index = int.Parse(cmd[1]);
            if (friendList == null || index < 0 || index >= friendList.Count) { break; }
            if (friendList[index] == "Blacklisted" || friendList[index] == "Lost") { break; }
            name = friendList[index];
            friendList.RemoveAt(index);
            friendList.Insert(index, "Lost");
            Console.WriteLine($"{name} was lost due to an error.");
            break;
        case "Change":
            index = int.Parse(cmd[1]);
            name = cmd[2];
            if (friendList == null || index < 0 || index >= friendList?.Count) { break; }
            Console.WriteLine($"{friendList?[index]} changed his username to {name}.");
            friendList?.RemoveAt(index);
            friendList?.Insert(index, name);
            break;
    }
}

var lostNames = 0;
if (friendList == null) return;
{
    foreach (var name in friendList)
    {
        if (name is "Lost" or "lost")
        {
            lostNames++;
        }
    }

    Console.WriteLine($"Blacklisted names: {blacklisted.Count} ");
    Console.WriteLine($"Lost names: {lostNames}");
    Console.WriteLine(string.Join(" ", friendList));
}

