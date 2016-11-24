using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
            SortProgram fact=new SortProgram();
            var array=new int[]{1,3,2};
            fact.Sort(array);
            foreach (var item in array)
            {
                Console.Write(item);
            }
            
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }
    }
}
