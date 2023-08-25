using System;

//ref link:https://www.youtube.com/watch?v=Iod4m852YqQ&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=10
//  boxing -- downside garbage collection - heap defragmentation - 

class MainClass
{
    static void Main()
    {
        //int i = 5;
        //object o = i;
        //i = 20;
        //Console.WriteLine(o);
        //Console.WriteLine(i);
        //o = 99;
        //Console.WriteLine(o);

        ////////

        int i = 5;
        object o = i;
        i++;
    }
}