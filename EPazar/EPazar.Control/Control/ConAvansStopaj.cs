using System;

namespace EPazar.Control.Control
{
    public static class ConAvansStopaj
    {
        public static decimal StopajHesapla(decimal Tutar)
           => Math.Floor(((Tutar / 0.98m) - Tutar) * 100) / 100;
    }
}