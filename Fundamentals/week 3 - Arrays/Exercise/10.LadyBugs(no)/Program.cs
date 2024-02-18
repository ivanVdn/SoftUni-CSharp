// Въвеждане на размера на полето
int fieldSize = int.Parse(Console.ReadLine());

// Въвеждане на началните позиции на калинките
int[] ladybugIndexes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

// Инициализация на полето
int[] field = new int[fieldSize];

// Разполагане на калинките на началните позиции
for (int i = 0; i < ladybugIndexes.Length; i++)
{
    int ladybugIndex = ladybugIndexes[i];

    // Проверка дали подадената позиция не е извън масива
    if (ladybugIndex >= 0 && ladybugIndex < fieldSize)
    {
        field[ladybugIndex] = 1; // Поставяне на калинка на подадената позиция
    }
}

// въвеждане на команди за движение на нови калинки до получаване на команда "end"
string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] commandsArr = command.Split().ToArray(); // Създаване на масив с команди

    // Разделяне на командата на отделни части
    int ladybugIndex = int.Parse(commandsArr[0]);   // начална позиция
    string direction = commandsArr[1];              // посока на движение
    int flyLength = int.Parse(commandsArr[2]);      // дължина на полета

    // Проверка дали позицията подадена на калинката е в масива и дали на позицията има калинка
    if (ladybugIndex >= 0 && ladybugIndex < fieldSize && field[ladybugIndex] == 1)
    {
        // Премахване на калинката от текущата позиция
        field[ladybugIndex] = 0;

        int newPosition = ladybugIndex;

        while (true)
        {
            // Пресмятане на новата позиция според посоката и дължината на полета
            if (direction == "right")
            {
                newPosition += flyLength;
            }
            else if (direction == "left")
            {
                newPosition -= flyLength;
            }

            // ако новата позиция не е в масива
            if (newPosition < 0 || newPosition >= field.Length)
            {
                // калинката излетя извън полето
                break;
            }

            // Проверка дали новата позиция е свободна
            if (field[newPosition] == 0)
            {
                // Поставяне на калинката на новата позиция
                field[newPosition] = 1;
                break;
            }
        }
    }
}

// Извеждане на полето със новите позиции на калинките
Console.WriteLine(string.Join(" ", field));
