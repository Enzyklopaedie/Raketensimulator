using System;

namespace Raketenflug
{
    public class Rakete
    {
        private double Beschleunigung;
        private double Zielhöhe;

        public Rakete(double beschleunigung, double zielhoehe)
        {
            Beschleunigung = beschleunigung;
            Zielhöhe = zielhoehe;
        }

        public double GibBeschleunigung()
        {
            return Beschleunigung;
        }

        public double GibZielhöhe()
        {
            return Zielhöhe;
        }
    }
}
