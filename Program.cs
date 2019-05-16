using System;

namespace SatouWork
{
    public class Program
    {
        static void Main()
        {
            var sato = new Sato(true);

            Console.Write(sato.Cute ? "佐藤好可愛" : "佐藤不可愛");
        }
    }

    public class Sato
    {
        public bool Cute;

        public Sato(bool cute)
        {
            Cute = cute;
        }
    }
    public class Test
    {
        /// <summary>
        /// F0 = 0
        /// F1 = 1
        /// Fn = Fn-1 + Fn-2
        /// F(x) = F(x-1) + F(x-2)
        /// </summary>
        /// <returns></returns>
        public int F(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return F(n - 1) + F(n - 2);
        }

    }



}














/*
public class Animal
{
    public Animal()
    {

    }

    public void Life()
    {
    }
}

public class People : Animal, CanTake
{
    public People()
    {

    }

    public void Take()
    {
    }
}

public class Robot : CanTake
{
    public void Take()
    {
    }
}

public interface CanTake
{
    void Take();

    void wolf();
}

public class Pig : Animal
{
    public Pig()
    {


    }

    public void EatShit()
    {
    }
}

public class Sato : Pig
{
    public Sato()
    {


    }


}


}
*/



/*
           int i,j = 1 ; int k ;
           While(i<10)
           {
           
           k=i*j 
           Console.Write(i + "*" + j + "=" + k + " ")

           }
 

     
     */



/*
            int i = 0;
            while(i<3)
            {
               Console.Write("喵");
              i = i+1;
            }

 */



