using System;
namespace Oliot
{
    public class UrheiluAuto : Auto // this is how a sub class can inherit from a more general class
    {
        public bool Metallivari { get; set; }
        public bool Takaveto { get; set; }

        public UrheiluAuto (int maxSpeed) 
        : base(maxSpeed)
        { }

        public void AvaaKattoLuukku()
        { 
        }
    }
}
