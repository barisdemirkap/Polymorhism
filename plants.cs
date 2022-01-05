using System;

namespace inheritance
{
    public class plants:bios
        {public plants () {
        base.breathing();
        base.feeding() ;
        base.pooping() ;
        }
        protected void Photosynthesis()
        {
            Console.WriteLine("Plants photosynthesise"); 
        }

        public override void stimulate ()
        {
            base.stimulate() ;
            Console.WriteLine("Plants interact with sun") ;
        }
       
    }

    public class plantswithseeds:plants
    {    public plantswithseeds(){
        base.Photosynthesis() ;
        base.stimulate() ;
    }
        public void growth()
        {
              Console.WriteLine("Platswithseed growth by seeds");   
        }
    }
}