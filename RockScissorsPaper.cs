using System;

//Rock Scissors Paper.
public enum RSP { Rock = 1, Scissors = 2, Paper = 3, EXIT = 4 }
public enum RSPResult { NONE = -2, Lose = -1, Draw = 0, Win = 1 }

namespace RockScissorsPaper
{
    public class RSPSystem
    {
        //use Random Instance
        static RSP RSPRandom()
        {
            //Random Instanace 
            Random random = new Random();
            int temp = random.Next(1, 4); //Range 1~3

            return (RSP)temp;
        }

        public int RSPResult(RSP _myRSP)
        {
            int result = 0;
            //AI의 RSP 결과값을 받아온다.
            RSP aiRSP = RSPRandom();
            string sAiRsp = "";
            switch (aiRSP)
            {
                case RSP.Rock:
                    sAiRsp = "Rock";
                    break;
                case RSP.Scissors:
                    sAiRsp = "Scissors";
                    break;
                case RSP.Paper:
                    sAiRsp = "Paper";
                    break;
            }
            Console.WriteLine("The other person used {0}.", sAiRsp);

            //내 RSP와 결과를 추론한다.
            if (_myRSP == RSP.Rock)
            {
                if (aiRSP == RSP.Rock)   //Rock vs Rock
                {
                    result = 0;
                }
                else if (aiRSP == RSP.Scissors)     //Rock vs Scissors
                {
                    result = 1;
                }
                else if (aiRSP == RSP.Paper)        //Rock vs Paper
                {
                    result = -1;
                }
            }
            else if (_myRSP == RSP.Scissors)
            {
                if (aiRSP == RSP.Rock)        //Scissors vs Rock
                {
                    result = -1;
                }
                else if (aiRSP == RSP.Scissors)     //Scissors vs Scissors
                {
                    result = 0;
                }
                else if (aiRSP == RSP.Paper)        //Scissors vs Paper
                {
                    result = 1;
                }
            }
            else if (_myRSP == RSP.Paper)
            {
                if (aiRSP == RSP.Rock)        //Paper vs Rock
                {
                    result = 1;
                }
                else if (aiRSP == RSP.Scissors)     //Paper vs Scissors
                {
                    result = -1;
                }
                else if (aiRSP == RSP.Paper)        //Paper vs Paper
                {
                    result = 0;
                }
            }
            return result;
        }
    }
    public class RSPMachine
    {
        public void RSPMachineRun()
        {
            int iTotal = 0, iWin = 0, iLose = 0, iDraw = 0;
            int myRSP = (int)RSP.Rock;
            RSPSystem rpsSys = new RSPSystem();

            while (true)
            {
                try
                {
                    Console.WriteLine("1.Rock    2.Scissors    3.Paper    4.EXIT");
                    Console.Write("choice :");
                    myRSP = Convert.ToInt32(Console.ReadLine()); //Covert string to int32

                    switch ((RSP)myRSP)
                    {
                        case RSP.Rock:
                        case RSP.Scissors:
                        case RSP.Paper:
                            int result = rpsSys.RSPResult((RSP)myRSP);
                            ++iTotal;
                            if (result == 0)
                            {
                                Console.WriteLine("Your Draw -.-");
                                ++iDraw;
                            }
                            else if (result == 1)
                            {
                                Console.WriteLine("Your Win!!!!!");
                                ++iWin;
                            }
                            else
                            {
                                Console.WriteLine("Your Lose XD");
                                ++iLose;
                            }
                            break;
                        case RSP.EXIT:  //EXIT is OUT
                            Console.WriteLine("EXIT");
                            return;
                        default:
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                            break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Total : {0}    Win : {1}    Draw : {2}    Lose : {3}",iTotal, iWin, iDraw, iLose);
                    Console.WriteLine("");
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}