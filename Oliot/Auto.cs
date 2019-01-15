using System;
namespace Oliot
{
    public class Auto
    {
        private int maxSpeed;

        public Auto(int maxSpeed)
        {
            this.maxSpeed= maxSpeed;
        }


        //c# does not allow multi-inheritance (one line)
        public bool MoottoriKaynissa { get; set; }//default  = false; //ominaisuus 

        public int Nopeus { get; set; }  //default = 0//nama ovat ominaisuuksia (properties)

        public int MaxSpeed { get; set; }

        public void Kaynnista() //method
        {
            if (MoottoriKaynissa == true) // if you don't put == true, it assumes it is true as default
            {
                throw new Exception("The engine is already running, can not be started again");

            }
            else
            {
                Console.WriteLine("Start the engine.");
                MoottoriKaynissa = true;
                // methods keep track of things for example if you've started a car already you can't start it again while the engine is running.
            }
        }

        public void Kiihdyta()
        {

            if (!MoottoriKaynissa) // if you don't put == true, it assumes it is true as default
            {
                throw new Exception("The Engine is not running, can not accelerate");

            }

            if (Nopeus >= MaxSpeed)
            {
                throw new Exception("Speed limit reached, cannot accelerate");
            }

            //Nopeus = Nopeus + 5;
            Nopeus += 5;

            Console.WriteLine("Car accelerated");

        }

        public void Jarruta()
        {

            if (!MoottoriKaynissa) // if you don't put == true, it assumes it is true as default
            {
                throw new Exception("The Engine is not running, can not break");

            }

            //Nopeus = Nopeus + 5;
            Nopeus -= 5; 
        }
    }

}

