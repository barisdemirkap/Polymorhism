using System;

namespace inheritance
{
    public class animals:bios
    {   public animals () {
        base.breathing();
        base.feeding() ;
        base.pooping() ;

    }
       protected void adaptating ()
        {
            Console.WriteLine("animals adapting"); 
        }
        public override void stimulate()
        {
            base.stimulate();
            Console.WriteLine("animals will interact with stimulaters");
        }
        

        
       
    }

    public class reptiles:animals
    {   public reptiles(){
        base.adaptating() ;
        base.stimulate() ;
        

    }
       public  void crawl ()
        {
            Console.WriteLine("reptiles crawl"); 
        }
    }
    public class birds:animals
    {   public birds() {
        base.adaptating() ;
        base.stimulate() ;
      
    }
       public  void fly ()
        {
            Console.WriteLine("birds fly"); 
        }
    }
}