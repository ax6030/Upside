namespace Sideways
{
    using Upside;
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int i = 1;
            bool b = true;
            string s = i.ToPrice();
            s.SendIt();
            b.Green().SendIt();
            b = false;
            b.Green().SendIt();
            i = 3;
            i.ToPrice().SendIt();
        }

        
    }
}