using System;

/// <summary>
/// 1. 예약어는 정리해 두자.
/// 2. 자동 구현 프로퍼티 정리해두자.
/// </summary>


class Person
{
    private string name = "James";

    public string Name
    {
        set 
        { 
            if(value.Length == 0)
            {
                throw new ArgumentException("이름이 입력되지 않았습니다.");
            }
            else
            {
                name = value;
            }
        }
        get { return name; }
    }
}


internal class MyProgram
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "Bob";

        Console.WriteLine("안녕하세요, "+ p.Name + "씨");

    }   
}


            ////1
            // int ageInt;
            // int sum;

            // Console.Write("Age:    ");
            // ageInt  = Convert.ToInt32(Console.ReadLine());

            // sum = ageInt + 1;
            
            // Console.WriteLine($"?떦?떊?쓽 ?굹?씠?뿉 ?븳?궡?쓣 ?뜑?븯硫? {sum}?궡?씠 ?맗?땲?떎.");

            ////2
            // int y = 0;
            // while(++y < 10)
            // {
            //     Console.WriteLine(y);
            // }
            
            // Console.WriteLine( );
            // Console.WriteLine( );
            
            // int z = 0;
            // while(z++ < 10) 
            // {
            //     Console.WriteLine(z);
            // }

            ////3
            ///    static void  SwapNum_1(out int a, out int b)
            // {
            //     a = 3; b = 2;
            //     int temp = a;
            //     a = b;
            //     b = temp;
            // }

            // static void  SwapNum_2(ref int a, ref int b)
            // {
            //     int temp = a;
            //     a = b;
            //     b = temp;
            // }
            // static void Main(string[] args)
            // {
            //     int x = 1;
            //     int y = 2;

            //     SwapNum_1(out x, out y);
            //     Console.WriteLine("x?쓽 媛믪?? {0}?엯?땲?떎.", x);
            //     Console.WriteLine("y?쓽 媛믪?? {0}?엯?땲?떎.", y);

            //     Console.WriteLine();

            //     x = 1;
            //     y = 2;
            //     SwapNum_2(ref x , ref y);
            //     Console.WriteLine("x?쓽 媛믪?? {0}?엯?땲?떎.", x);
            //     Console.WriteLine("y?쓽 媛믪?? {0}?엯?땲?떎.", y);
            // }