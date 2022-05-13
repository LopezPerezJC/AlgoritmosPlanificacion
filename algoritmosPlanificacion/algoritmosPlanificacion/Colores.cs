using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosPlanificacion
{
    public static class Colores
    {
        //Colores diseño
        public static Color panelAgregarTarea;
        public static Color SeccionDiagramas;


        //Colores cuadros a pintar
        public static Color ColorAmarillo; //Amarillo
        public static Color ColorNaranja; //Naranja
        public static Color ColorVerdeLimon; //Verde limon
        public static Color ColorAzul; //Azul
        public static Color ColorRojo; //Rojo

        public static Color ColorAzulCielo; //azul cielo
        public static Color ColorRosa; //rosa
        public static Color ColorMorado; //Morado
        public static Color ColorAzulFuerte; //azul fuerte
        public static Color ColorVerdeFuerte; //verde fuerte


        //colores
        private static readonly Color ColorSeccion1 = Color.FromArgb(95, 84, 250);
        private static readonly Color ColorSeccion2 = Color.FromArgb(147, 113, 245);
        
        private static readonly Color Color1 = Color.FromArgb(255, 215, 0);
        private static readonly Color Color2 = Color.FromArgb(255, 127, 80);
        private static readonly Color Color3 = Color.FromArgb(173, 255, 47);
        private static readonly Color Color4 = Color.FromArgb(0, 191, 255);
        private static readonly Color Color5 = Color.FromArgb(255, 0, 0);
        private static readonly Color Color6 = Color.FromArgb(135, 206, 235);
        private static readonly Color Color7 = Color.FromArgb(255, 192, 203);
        private static readonly Color Color8 = Color.FromArgb(138, 43, 226);
        private static readonly Color Color9 = Color.FromArgb(0, 0, 255);
        private static readonly Color Color10 = Color.FromArgb(50, 205, 50);

        public static void ElegirColor(string color)
        {
            if(color == "amarillo")
            {
                ColorAmarillo = Color1;

                panelAgregarTarea = ColorSeccion1;
                SeccionDiagramas = ColorSeccion2;

            }
            if (color == "naranja")
            {
                ColorNaranja = Color2;
            }
            if (color == "verdeLimon")
            {
                ColorVerdeLimon = Color3;
            }
        }

    }
}
