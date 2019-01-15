using System;

namespace Oliot
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto omaAuto = new Auto(200); //this is called an instance 
            Auto naapurinAuto = new Auto(150);
            UrheiluAuto oma = new UrheiluAuto(325);

            // omaAuto.MoottoriKaynissa = true;
            //omaAuto.Nopeus = 45;

            //naapurinAuto.MoottoriKaynissa = false;
            //naapurinAuto.Nopeus = 0;

            omaAuto.MaxSpeed = 200;
            omaAuto.Kaynnista();
            omaAuto.Kiihdyta();



            
                
        }
    }
}
