namespace D02
{
    internal class Program
    {
        static void Swap(int num1, int num2)
        {
            (num2, num1) = (num1, num2);
        }
        static void Main(string[] args)
        {
            bool choice;
            List<int> myList = [];
            int countOfMyList;
            char yourChoice;
            string startOutbut = "╔════ Outbut ═══════════════════╗";
            string EndOutbut = "╚═══════════════════════════════╝";
            double average;
            int sum = 0;
            int found = -1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("╔══ Main Menu ═══════════════════════╗");
                Console.WriteLine("║ P - Print numbers                  ║");
                Console.WriteLine("║ A - Add a number                   ║");
                Console.WriteLine("║ M - Display mean of the number     ║");
                Console.WriteLine("║ S - Display teh Smallest number    ║");
                Console.WriteLine("║ L - Display teh Largest number     ║");
                Console.WriteLine("║ F - Find a number                  ║");
                Console.WriteLine("║ C - Clear the whole list           ║");
                Console.WriteLine("║ R - Clear the whole list           ║");
                Console.WriteLine("║ Q - Quit                           ║");
                Console.WriteLine("╚════════════════════════════════════╝");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n==> : ");
                choice = char.TryParse(Console.ReadLine(), out yourChoice);
                countOfMyList = myList.Count;
                if (choice)
                {
                    yourChoice = char.ToUpper(yourChoice);

                    Console.ForegroundColor = ConsoleColor.Green;
                    if (yourChoice == 'P')
                    {
                        if (countOfMyList > 0)
                        {

                            Console.WriteLine(startOutbut);
                            for (int i = 0; i < countOfMyList; i++)
                            {
                                Console.Write($"    {myList[i]}");
                            }
                            Console.WriteLine($"\n{EndOutbut}");
                        }
                        else
                        {
                            Console.WriteLine(startOutbut);
                            Console.WriteLine("         Your list is Empity");
                            Console.WriteLine(EndOutbut);
                        }
                    }

                    else if (yourChoice == 'A')
                    {
                        Console.Write("Enter the number to add ==>  ");
                        if (int.TryParse(Console.ReadLine(), out int addNewNumber))
                        {
                            int numberFound = -1;
                            for (int i = 0; i < countOfMyList; i++)
                            {
                                if (addNewNumber == myList[i])
                                {
                                    numberFound = addNewNumber;
                                    break;
                                }
                            }
                            if (numberFound != addNewNumber)
                            {
                                myList.Add(addNewNumber);
                                Console.WriteLine(startOutbut);
                                Console.WriteLine($"         {addNewNumber} added");
                                Console.WriteLine(EndOutbut);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                myList.Add(addNewNumber);
                                Console.WriteLine(startOutbut);
                                Console.WriteLine($"Sorry this number found in your list!!");
                                Console.WriteLine(EndOutbut);
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(startOutbut);
                            Console.WriteLine("         Your Enter is wrong");
                            Console.WriteLine(EndOutbut);
                        }
                    }

                    else if (yourChoice == 'M')
                    {
                        if (countOfMyList == 0)
                        {
                            Console.WriteLine(startOutbut);
                            Console.WriteLine("Unable to calculate the mean - no data");
                            Console.WriteLine(EndOutbut);
                        }

                        else
                        {
                            for (int i = 0; i < countOfMyList; i++)
                                sum += myList[i];
                            average = sum / countOfMyList;
                            Console.WriteLine(startOutbut);
                            Console.WriteLine($"        mean: {average}");
                            Console.WriteLine(EndOutbut);
                        }
                    }

                    else if (yourChoice == 'S')
                    {
                        if (myList.Count == 0)
                        {
                            Console.WriteLine(startOutbut);
                            Console.WriteLine($"Unable to determine the smallest number - list is empty");
                            Console.WriteLine(EndOutbut);
                        }
                        else
                        {
                            int smallest = myList[0];
                            for (int i = 0; i < countOfMyList; i++)
                            {
                                if (myList[i] <= smallest)
                                    smallest = myList[i];

                            }
                            Console.WriteLine(startOutbut);
                            Console.WriteLine($" The smallest number is {smallest}");
                            Console.WriteLine(EndOutbut);
                        }
                    }

                    else if (yourChoice == 'L')
                    {
                        if (myList.Count == 0)
                        {
                            Console.WriteLine(startOutbut);
                            Console.WriteLine($"Unable to determine the smallest number - list is empty");
                            Console.WriteLine(EndOutbut);
                        }
                        else
                        {
                            int largest = myList[0];
                            for (int i = 0; i < countOfMyList; i++)
                            {
                                if (myList[i] >= largest)
                                    largest = myList[i];

                            }
                            Console.WriteLine(startOutbut);
                            Console.WriteLine($" The smallest number is {largest}");
                            Console.WriteLine(EndOutbut);
                        }
                    }

                    else if (yourChoice == 'Q')
                    {
                        Console.WriteLine("GoodBye");
                    }

                    else if (yourChoice == 'F')
                    {
                        Console.WriteLine("Enter the number to search: ==> ");
                        if (int.TryParse(Console.ReadLine(), out int searchNumber))
                        {
                            for (int i = 0; i < countOfMyList; i++)
                            {
                                if (myList[i] == searchNumber)
                                {
                                    found = searchNumber;
                                    Console.WriteLine(startOutbut);
                                    Console.WriteLine($"Needed number in index {i}");
                                    Console.WriteLine(EndOutbut);
                                }
                            }
                            if (found != searchNumber)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(startOutbut);
                                Console.WriteLine("Your number is not found!!");
                                Console.WriteLine(EndOutbut);
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(startOutbut);
                            Console.WriteLine("Your inbut not a number!!");
                            Console.WriteLine(EndOutbut);
                        }
                    }

                    //Clear List
                    else if (yourChoice == 'C')
                    {
                        myList.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(startOutbut);
                        Console.WriteLine("  Your List is Empity now!! ");
                        Console.WriteLine(EndOutbut);
                    }

                    // Sort List
                    else if (yourChoice == 'R')
                    {
                        for (int i = 0; i < countOfMyList; i++)
                        {
                            for (int j = 0; j < countOfMyList - 1; j++)
                            {
                                if (myList[i] < myList[j] + 1)
                                {
                                    (myList[j], myList[i]) = (myList[i], myList[j]);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(startOutbut);
                    Console.WriteLine("  Unknown selection, please try again  ");
                    Console.WriteLine(EndOutbut);
                }
            } while (yourChoice != 'q' && yourChoice != 'Q');




        }
    }
}
