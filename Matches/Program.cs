
using System;

namespace Matches
{
    
    class Program
    {

    public static bool isAllClosed( string source )
    {
        if( source == null || source.Length < 2 ) return false;
        
        char [] stack = new char[source.Length]; 
        int stackPtr = 0;
        foreach (var ch in source)
        {
            if( ! Char.IsWhiteSpace( ch ))
            {
                if( (stackPtr - 1) >= 0 )
                {
                    if( stack[stackPtr-1] != ch)
                    {
                        stack[stackPtr++] = ch;
                    }
                    else
                    {
                        stackPtr--;
                    }
                }
                else
                {
                    stack[stackPtr++] = ch;
                }
            }
        }
        return stackPtr == 0;
    }
        static void Main(string[] args)
        {
            // Console.WriteLine(isAllClosed("123321"));
            // Console.WriteLine(isAllClosed("11223131"));
            // Console.WriteLine(isAllClosed("21"));
            // Console.WriteLine(isAllClosed(""));
            // Console.WriteLine(isAllClosed("5"));
            // Console.WriteLine(isAllClosed("11221331"));
            Console.WriteLine(isAllClosed("1233442881"));
        }
    }
}
