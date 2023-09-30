//using Proyecto1;
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Proyecto1_01
//{
//    public class escenario
//    {
//        Punto puntos;

//        private Cubo pared;
//        private Cubo repisa;

//        private Cubo auto;
//        private Cubo auto1;

//        private Cubo llanta;
//        private Cubo llanta1;
//        private Cubo llanta2;
//        private Cubo llanta3;

//        public escenario(float x, float y, float z)
//        {
//            puntos = new Punto(x,y,z);
//        }
//        public void construir()
//        {
//            pared = new Cubo(puntos, 10, 10, 1, Color.Blue);//x=ancho,y= altura,z=profundidad
//            repisa = new Cubo(new Punto(puntos.x+0,puntos.y+0,puntos.z+5), 7, 1, 4, Color.Brown);
//            auto = new Cubo(new Punto(puntos.x+0, puntos.y+5, puntos.z + 4), 2, 1, 2, Color.Aqua);
//            auto1 = new Cubo(new Punto(puntos.x + 0, puntos.y + 3, puntos.z + 4), 2, 1, 5, Color.Chartreuse);

//            llanta = new Cubo(new Punto(puntos.x+3, puntos.y + 2, puntos.z + 7), 1, 1, 1, Color.DarkBlue);
//            llanta1 = new Cubo(new Punto(puntos.x-3, puntos.y + 2, puntos.z + 7), 1, 1, 1, Color.DarkBlue);
//            llanta2 = new Cubo(new Punto(puntos.x+3, puntos.y + 2, puntos.z + 2), 1, 1, 1, Color.DarkBlue);
//            llanta3 = new Cubo(new Punto(puntos.x - 3, puntos.y + 2, puntos.z + 2), 1, 1, 1, Color.DarkBlue);
//        }
//        public void dibujar()
//        {
//            this.pared.Dibujar();
//            this.repisa.Dibujar();
//            this.auto.Dibujar();
//            this.auto1.Dibujar();

//            this.llanta.Dibujar();
//            this.llanta1.Dibujar();
//            this.llanta2.Dibujar();
//            this.llanta3.Dibujar();
//        }
//    }

//}
