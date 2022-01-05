using System;

namespace inheritance
{
    public class bios //sealed
    {
        protected void feeding ()
        {
            Console.WriteLine("bios eat"); 
        }
        protected  void breathing ()
        {
            Console.WriteLine("bios breath"); 
        }
        protected  void pooping ()
        {
            Console.WriteLine("bios poop"); 
        }

        public virtual void stimulate() {
        Console.WriteLine("bios could interact with stimulater") ;    
        }
    }
}