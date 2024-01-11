using System;

using MachineState = MultiplicationTableMachineState;

//클래스는 사용 불가능하다.
//네임스페이스 또는 형식 별칭 정의
// 형식 별칭 정의 EX :  using StringList = System.Collections.Generic.List<string>;
//using MultiplMachine= MultiplicationTableMachine;

public enum MultiplicationTableMachineState { All = 1, Row = 2, Single = 3, EXIT = 4 }

namespace MultiplicationTable
{
    public class MultiplicationTableSystem
    {
        public void MultiplicationTableAll()
        {
            Console.WriteLine("");
            Console.WriteLine("~~ ALL ~~");
            Console.WriteLine("");
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine($"{i} Row");
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
        public void MultiplicationTableRow(int number)
        {
            Console.WriteLine("");
            Console.WriteLine("~~ Row {0} ~~", number);
            Console.WriteLine("");
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
        public void MultiplicationTableSingle(int row, int columm)
        {
            Console.WriteLine("");
            Console.WriteLine("{0} X {1} = {2}", row, columm, row * columm);
            Console.WriteLine("");
        }
    }
    public class MultiplicationTableMachine
    {
        public void MultiplicationTableMachineRun()
        {
            MultiplicationTableSystem multiplicatiopnSystem = new MultiplicationTableSystem();
            while (true)
                try
                {
                    //MachineRun
                    Console.WriteLine("");
                    Console.WriteLine("1.ALL    2.Row    3.Single    4.EXIT");
                    Console.Write("choice Mode  :");
                    MachineState state = (MachineState)Convert.ToInt32(Console.ReadLine());

                    switch (state)
                    {
                        case MachineState.All:
                            multiplicatiopnSystem.MultiplicationTableAll();
                            break;
                        case MachineState.Row:
                            try
                            {
                                Console.WriteLine("");
                                Console.Write("Input Row  :");
                                multiplicatiopnSystem.MultiplicationTableRow(Convert.ToInt32(Console.ReadLine()));
                            }
                            catch (System.Exception e)
                            {
                                Console.WriteLine("An error occurred: " + e.Message);
                            }
                            break;
                        case MachineState.Single:
                            try
                            {
                                Console.WriteLine("");
                                Console.Write("Input Two Integer(need Split) :");   
                                string? input = Console.ReadLine();
                                if(input!= null)
                                {
                                    string[] numbers = input.Split(' ');    //Split is strtok?! wow
                                    multiplicatiopnSystem.MultiplicationTableSingle(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
                                }
                                else
                                {
                                    throw new Exception("input null");
                                }
                            }
                            catch (System.Exception e)
                            {
                                Console.WriteLine("An error occurred: " + e.Message);
                            }
                            break;
                        case MachineState.EXIT:
                            Console.WriteLine("EXIT");
                            return;

                        default:
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                            break;
                    }

                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
        }
    }
}

