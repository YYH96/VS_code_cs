using System;
using RockScissorsPaper;
using MultiplicationTable;
using Calculator;

namespace MainProgram
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            //     //가위바위보 
            //    RSPMachine rspMachine = new RSPMachine();
            //    rspMachine.RSPMachineRun();

            // //구구단
            // MultiplicationTableMachine multiTableMachine = new MultiplicationTableMachine();
            // multiTableMachine.MultiplicationTableMachineRun();

            //계산기
            CalculatorMachin calculator = new CalculatorMachin();
            calculator.CalculatorMachinRun();

        }
    }
}