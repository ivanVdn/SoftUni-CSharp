using System;

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var lessonList = Console.ReadLine()?
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                //.Select(int.Parse)
                .ToList();

            string? command;
            while ((command = Console.ReadLine()) != "course start")
            {
                var cmd = command?
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (lessonList != null)
                {

                    switch (cmd?[0])
                    {
                        case "Add":
                            var name = cmd[1];
                            if (!lessonList.Contains(name))
                            {
                                lessonList.Add(name);
                            }
                            break;
                        case "Insert":
                            name = cmd[1];
                            var index = int.Parse(cmd[2]);
                            if (!lessonList.Contains(name))
                            {
                                lessonList.Insert(index, name);
                            }

                            break;
                        case "Remove":
                            name = cmd[1];
                            if (lessonList.Contains(name))
                            {
                                lessonList.Remove(name);
                            }

                            if (lessonList.Contains(name + "-Exercise"))
                            {
                                lessonList.Remove(name + "-Exercise");
                            }

                            break;
                        case "Swap":
                            var name1 = cmd[1];
                            var name2 = cmd[1] + "-Exercise";
                            var name3 = cmd[2];
                            var name4 = cmd[2] + "-Exercise";
                            if (lessonList.Contains(name1) && lessonList.Contains(name3))
                            {
                                if (lessonList.Contains(name2) && lessonList.Contains(name4))
                                {
                                    var index1 = lessonList.IndexOf(name1);//
                                    var index2 = lessonList.IndexOf(name2);
                                    var index3 = lessonList.IndexOf(name3);//
                                    var index4 = lessonList.IndexOf(name4);

                                    lessonList[index1] = lessonList[index3];
                                    lessonList[index2] = lessonList[index4];
                                    lessonList[index3] = name1;
                                    lessonList[index4] = name2;
                                }
                                else if (lessonList.Contains(name2))
                                {
                                    var index1 = lessonList.IndexOf(name1);//
                                    var index2 = lessonList.IndexOf(name2);
                                    var index3 = lessonList.IndexOf(name3);//

                                    lessonList[index1] = lessonList[index3];
                                    lessonList[index3] = name1;
                                    lessonList.Insert(index3 + 1, name2);
                                    lessonList.RemoveAt(index2);
                                }
                                else if (lessonList.Contains(name4))
                                {
                                    var index1 = lessonList.IndexOf(name1);//

                                    var index3 = lessonList.IndexOf(name3);//
                                    var index4 = lessonList.IndexOf(name4);

                                    lessonList[index1] = lessonList[index3];
                                    lessonList[index3] = name1;
                                    lessonList.Insert(index1 + 1, name4);
                                    lessonList.RemoveAt(index4 + 1);

                                }
                                else
                                {
                                    var index1 = lessonList.IndexOf(name1);//
                                    var index3 = lessonList.IndexOf(name3);//

                                    lessonList[index1] = lessonList[index3];
                                    lessonList[index3] = name1;
                                }
                            }
                            break;
                        case "Exercise":
                            name = cmd[1];
                            if (lessonList.Contains(name))
                            {
                                if (!lessonList.Contains(name+ "-Exercise"))
                                {
                                    index = lessonList.IndexOf(name);
                                    lessonList.Insert(index + 1, name + "-Exercise");
                                }
                            }
                            else
                            {
                                lessonList.Add(name);
                                lessonList.Add(name + "-Exercise");
                            }
                            break;
                    }
                }
            }
            if (lessonList == null) return;
            for (var i = 0; i < lessonList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessonList[i]}");
            }
        }
    }
}


/*
Arrays, Lists, Methods
Remove:Lists
Insert:Lists:1
Swap:Arrays:Methods
Exercise:Databases
Swap:Lists:Databases
Insert:Arrays:0
course start
   
*/