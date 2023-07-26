using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (ParentException ex) { }
            catch (ChildException ex) { 
            }
        }
    }
}


public class ParentException : Exception
{

}

public class ChildException : ParentException
{

}