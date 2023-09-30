using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Proyecto1_01;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Proyecto1;
using Proyecto_grafica;

namespace Proyecto1
{
    public class Game : GameWindow
    {
        Objeto muro;
        Objeto repisa;
        Objeto chasis;
        Objeto llanta;
        Objeto ventana;

        Camera cam;

        //-----------------------------------------------------------------------------------------------------------------
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            cam.Update(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnLoad(EventArgs e)
        {
            Vector3 initialPosition = new Vector3(0,0,3);
            Vector3 initialFront = new Vector3(0,0,-1);
            Vector3 initialUp = Vector3.UnitY;
            float cameraSpeed = 1.0f;

            GL.ClearColor(Color4.Black);

            Poligono a = new Poligono(Color4.Blue);
            Poligono b = new Poligono(Color4.Blue);
            Poligono c = new Poligono(Color4.Red);
            Poligono d = new Poligono(Color4.Red);
            Poligono f = new Poligono(Color4.Red);
            Poligono g = new Poligono(Color4.Red);

            Poligono r1 = new Poligono(Color4.Green);
            Poligono r2 = new Poligono(Color4.Green);
            Poligono r3 = new Poligono(Color4.White);
            Poligono r4 = new Poligono(Color4.White);
            Poligono r5 = new Poligono(Color4.White);

            Poligono ch1 = new Poligono(Color4.Brown);
            Poligono ch2 = new Poligono(Color4.Brown);
            Poligono ch3 = new Poligono(Color4.Yellow);
            Poligono ch4 = new Poligono(Color4.Yellow);
            Poligono ch5 = new Poligono(Color4.Yellow);
            Poligono ch6 = new Poligono(Color4.Yellow);

            Poligono ch7 = new Poligono(Color4.Brown);
            Poligono ch8 = new Poligono(Color4.Brown);
            Poligono ch9 = new Poligono(Color4.Brown);
            Poligono ch10 = new Poligono(Color4.Brown);
            Poligono ch11 = new Poligono(Color4.Brown);
            Poligono ch12 = new Poligono(Color4.Brown);

            Poligono ch13 = new Poligono(Color4.Brown);
            Poligono ch14 = new Poligono(Color4.Brown);
            Poligono ch15 = new Poligono(Color4.Brown);
            Poligono ch16 = new Poligono(Color4.Brown);
            Poligono ch17 = new Poligono(Color4.Brown);
            Poligono ch18 = new Poligono(Color4.Brown);

            Poligono ch19 = new Poligono(Color4.Brown);
            Poligono ch20 = new Poligono(Color4.Brown);
            Poligono ch21 = new Poligono(Color4.Brown);
            Poligono ch22 = new Poligono(Color4.Brown);
            Poligono ch23 = new Poligono(Color4.Brown);
            Poligono ch24 = new Poligono(Color4.Brown);

            Poligono ch25 = new Poligono(Color4.Brown);
            Poligono ch26 = new Poligono(Color4.Brown);
            Poligono ch27 = new Poligono(Color4.Brown);
            Poligono ch28 = new Poligono(Color4.Brown);
            Poligono ch29 = new Poligono(Color4.Brown);
            Poligono ch30 = new Poligono(Color4.Brown);

            Poligono ch31 = new Poligono(Color4.Brown);
            Poligono ch32 = new Poligono(Color4.Brown);
            Poligono ch33 = new Poligono(Color4.Brown);
            Poligono ch34 = new Poligono(Color4.Brown);
            Poligono ch35 = new Poligono(Color4.Brown);
            Poligono ch36 = new Poligono(Color4.Brown);

            Poligono ch37 = new Poligono(Color4.Brown);
            Poligono ch38 = new Poligono(Color4.Brown);
            Poligono ch39 = new Poligono(Color4.Brown);
            Poligono ch40 = new Poligono(Color4.Brown);
            Poligono ch41 = new Poligono(Color4.Brown);
            Poligono ch42 = new Poligono(Color4.Brown);

            Poligono ch43 = new Poligono(Color4.YellowGreen);
            Poligono ch44 = new Poligono(Color4.YellowGreen);
            Poligono ch45 = new Poligono(Color4.YellowGreen);
            Poligono ch46 = new Poligono(Color4.YellowGreen);
            Poligono ch47 = new Poligono(Color4.YellowGreen);
            Poligono ch48 = new Poligono(Color4.YellowGreen);

            Poligono ll1 = new Poligono(Color4.Gray);
            Poligono ll2 = new Poligono(Color4.Gray);
            Poligono ll3 = new Poligono(Color4.White);
            Poligono ll4 = new Poligono(Color4.White);
            Poligono ll5 = new Poligono(Color4.White);
            Poligono ll6 = new Poligono(Color4.White);
            Poligono ll7 = new Poligono(Color4.White);
            Poligono ll8 = new Poligono(Color4.White);
            Poligono ll9 = new Poligono(Color4.White);
            Poligono ll10 = new Poligono(Color4.White);

            Poligono ll11 = new Poligono(Color4.Gray);
            Poligono ll12 = new Poligono(Color4.Gray);
            Poligono ll13 = new Poligono(Color4.White);
            Poligono ll14 = new Poligono(Color4.White);
            Poligono ll15 = new Poligono(Color4.White);
            Poligono ll16 = new Poligono(Color4.White);
            Poligono ll17 = new Poligono(Color4.White);
            Poligono ll18 = new Poligono(Color4.White);
            Poligono ll19 = new Poligono(Color4.White);
            Poligono ll20 = new Poligono(Color4.White);

            Poligono ll21 = new Poligono(Color4.Gray);
            Poligono ll22 = new Poligono(Color4.Gray);
            Poligono ll23 = new Poligono(Color4.White);
            Poligono ll24 = new Poligono(Color4.White);
            Poligono ll25 = new Poligono(Color4.White);
            Poligono ll26 = new Poligono(Color4.White);
            Poligono ll27 = new Poligono(Color4.White);
            Poligono ll28 = new Poligono(Color4.White);
            Poligono ll29 = new Poligono(Color4.White);
            Poligono ll30 = new Poligono(Color4.White);

            Poligono ll31 = new Poligono(Color4.Gray);
            Poligono ll32 = new Poligono(Color4.Gray);
            Poligono ll33 = new Poligono(Color4.White);
            Poligono ll34 = new Poligono(Color4.White);
            Poligono ll35 = new Poligono(Color4.White);
            Poligono ll36 = new Poligono(Color4.White);
            Poligono ll37 = new Poligono(Color4.White);
            Poligono ll38 = new Poligono(Color4.White);
            Poligono ll39 = new Poligono(Color4.White);
            Poligono ll40 = new Poligono(Color4.White);

            Poligono ve1 = new Poligono(Color4.SkyBlue);
            Poligono ve2 = new Poligono(Color4.SkyBlue);
            Poligono ve3 = new Poligono(Color4.SkyBlue);
            Poligono ve4 = new Poligono(Color4.SkyBlue);
            Poligono ve5 = new Poligono(Color4.SkyBlue);
            Poligono ve6 = new Poligono(Color4.SkyBlue);
            Poligono ve7 = new Poligono(Color4.SkyBlue);
            Poligono ve8 = new Poligono(Color4.SkyBlue);
            Poligono ve9 = new Poligono(Color4.SkyBlue);
            Poligono ve10 = new Poligono(Color4.SkyBlue);
            Poligono ve11 = new Poligono(Color4.SkyBlue);
            Poligono ve12 = new Poligono(Color4.SkyBlue);




            a.Adicionar(0, 0, 10);
            a.Adicionar(10, 0, 10);
            a.Adicionar(10, 10, 10);
            a.Adicionar(0, 10, 10);

            b.Adicionar(0, 0, 9);
            b.Adicionar(10, 0, 9);
            b.Adicionar(10, 10, 9);
            b.Adicionar(0, 10, 9);

            c.Adicionar(0, 0, 10);
            c.Adicionar(0, 0, 9);
            c.Adicionar(0, 10, 9);
            c.Adicionar(0, 10, 10);

            d.Adicionar(10, 0, 10);
            d.Adicionar(10, 0, 9);
            d.Adicionar(10, 10, 9);
            d.Adicionar(10, 10, 10);

            f.Adicionar(10, 10, 10);
            f.Adicionar(10, 10, 9);
            f.Adicionar(0, 10, 9);
            f.Adicionar(0, 10, 10);

            g.Adicionar(10, 0, 10);
            g.Adicionar(10, 0, 9);
            g.Adicionar(0, 0, 9);
            g.Adicionar(0, 0, 10);

            //----------------------------------------------------------------------------
            r1.Adicionar(0, 4, 10);
            r1.Adicionar(10, 4, 10);
            r1.Adicionar(10, 4, 20);
            r1.Adicionar(0, 4, 20);

            r2.Adicionar(0, 5, 10);
            r2.Adicionar(10, 5, 10);
            r2.Adicionar(10, 5, 20);
            r2.Adicionar(0, 5, 20);

            r3.Adicionar(0, 4, 10);
            r3.Adicionar(0, 5, 10);
            r3.Adicionar(0, 5, 20);
            r3.Adicionar(0, 4, 20);

            r4.Adicionar(10, 4, 10);
            r4.Adicionar(10, 5, 10);
            r4.Adicionar(10, 5, 20);
            r4.Adicionar(10, 4, 20);

            r5.Adicionar(0, 4, 20);
            r5.Adicionar(0, 5, 20);
            r5.Adicionar(10, 5, 20);
            r5.Adicionar(10, 4, 20);

            //------------------------------------------------

            ch1.Adicionar(0, 7, 10);
            ch1.Adicionar(0, 9, 10);
            ch1.Adicionar(0, 9, 20);
            ch1.Adicionar(0, 7, 20);

            ch2.Adicionar(10, 7, 10);
            ch2.Adicionar(10, 9, 10);
            ch2.Adicionar(10, 9, 20);
            ch2.Adicionar(10, 7, 20);

            ch3.Adicionar(0, 7, 20);
            ch3.Adicionar(0, 9, 20);
            ch3.Adicionar(10, 9, 20);
            ch3.Adicionar(10, 7, 20);

            ch4.Adicionar(0, 7, 10);
            ch4.Adicionar(0, 9, 10);
            ch4.Adicionar(10, 9, 10);
            ch4.Adicionar(10, 7, 10);

            ch5.Adicionar(0, 7, 10);
            ch5.Adicionar(10, 7, 10);
            ch5.Adicionar(10, 7, 20);
            ch5.Adicionar(0, 7, 20);

            ch6.Adicionar(0, 9, 10);
            ch6.Adicionar(10, 9, 10);
            ch6.Adicionar(10, 9, 20);
            ch6.Adicionar(0, 9, 20);

            ch7.Adicionar(0, 9, 11);
            ch7.Adicionar(1, 9, 11);
            ch7.Adicionar(1, 9, 12);
            ch7.Adicionar(0, 9, 12);

            ch8.Adicionar(0, 12, 11);
            ch8.Adicionar(1, 12, 11);
            ch8.Adicionar(1, 12, 12);
            ch8.Adicionar(0, 12, 12);

            ch9.Adicionar(0, 9, 11);
            ch9.Adicionar(1, 9, 11);
            ch9.Adicionar(1, 12, 11);
            ch9.Adicionar(0, 12, 11);

            ch10.Adicionar(0, 9, 12);
            ch10.Adicionar(1, 9, 12);
            ch10.Adicionar(1, 12, 12);
            ch10.Adicionar(0, 12, 12);

            ch11.Adicionar(0, 9, 11);
            ch11.Adicionar(0, 12, 11);
            ch11.Adicionar(0, 12, 12);
            ch11.Adicionar(0, 9, 12);

            ch12.Adicionar(1, 9, 11);
            ch12.Adicionar(1, 12, 11);
            ch12.Adicionar(1, 12, 12);
            ch12.Adicionar(1, 9, 12);

            ch13.Adicionar(0, 9, 14);
            ch13.Adicionar(1, 9, 14);
            ch13.Adicionar(1, 9, 15);
            ch13.Adicionar(0, 9, 15);

            ch14.Adicionar(0, 12, 14);
            ch14.Adicionar(1, 12, 14);
            ch14.Adicionar(1, 12, 15);
            ch14.Adicionar(0, 12, 15);

            ch15.Adicionar(0, 9, 14);
            ch15.Adicionar(1, 9, 14);
            ch15.Adicionar(1, 12, 15);
            ch15.Adicionar(0, 12, 15);

            ch16.Adicionar(0, 9, 15);
            ch16.Adicionar(1, 9, 15);
            ch16.Adicionar(1, 12, 15);
            ch16.Adicionar(0, 12, 15);

            ch17.Adicionar(0, 9, 14);
            ch17.Adicionar(0, 12, 14);
            ch17.Adicionar(0, 12, 14);
            ch17.Adicionar(0, 9, 14);

            ch18.Adicionar(1, 9, 14);
            ch18.Adicionar(1, 12, 14);
            ch18.Adicionar(1, 12, 15);
            ch18.Adicionar(1, 9, 15);

            ch19.Adicionar(0, 9, 17);
            ch19.Adicionar(1, 9, 17);
            ch19.Adicionar(1, 9, 18);
            ch19.Adicionar(0, 9, 18);

            ch20.Adicionar(0, 12, 17);
            ch20.Adicionar(1, 12, 17);
            ch20.Adicionar(1, 12, 18);
            ch20.Adicionar(0, 12, 18);

            ch21.Adicionar(0, 9, 17);
            ch21.Adicionar(1, 9, 17);
            ch21.Adicionar(1, 12, 18);
            ch21.Adicionar(0, 12, 18);

            ch22.Adicionar(0, 9, 18);
            ch22.Adicionar(1, 9, 18);
            ch22.Adicionar(1, 12, 18);
            ch22.Adicionar(0, 12, 18);

            ch23.Adicionar(0, 9, 17);
            ch23.Adicionar(0, 12, 17);
            ch23.Adicionar(0, 12, 17);
            ch23.Adicionar(0, 9, 17);

            ch24.Adicionar(1, 9, 17);
            ch24.Adicionar(1, 12, 17);
            ch24.Adicionar(1, 12, 18);
            ch24.Adicionar(1, 9, 18);

            ch25.Adicionar(10, 9, 11);
            ch25.Adicionar(9, 9, 11);
            ch25.Adicionar(9, 9, 12);
            ch25.Adicionar(10, 9, 12);

            ch26.Adicionar(10, 12, 11);
            ch26.Adicionar(9, 12, 11);
            ch26.Adicionar(9, 12, 12);
            ch26.Adicionar(10, 12, 12);

            ch27.Adicionar(10, 9, 11);
            ch27.Adicionar(9, 9, 11);
            ch27.Adicionar(9, 12, 11);
            ch27.Adicionar(10, 12, 11);

            ch28.Adicionar(10, 9, 12);
            ch28.Adicionar(9, 9, 12);
            ch28.Adicionar(9, 12, 12);
            ch28.Adicionar(10, 12, 12);

            ch29.Adicionar(10, 9, 11);
            ch29.Adicionar(10, 12, 11);
            ch29.Adicionar(10, 12, 12);
            ch29.Adicionar(10, 9, 12);

            ch30.Adicionar(9, 9, 11);
            ch30.Adicionar(9, 12, 11);
            ch30.Adicionar(9, 12, 12);
            ch30.Adicionar(9, 9, 12);

            ch31.Adicionar(10, 9, 14);
            ch31.Adicionar(9, 9, 14);
            ch31.Adicionar(9, 9, 15);
            ch31.Adicionar(10, 9, 15);

            ch32.Adicionar(10, 12, 14);
            ch32.Adicionar(9, 12, 14);
            ch32.Adicionar(9, 12, 15);
            ch32.Adicionar(10, 12, 15);

            ch33.Adicionar(10, 9, 14);
            ch33.Adicionar(9, 9, 14);
            ch33.Adicionar(9, 12, 15);
            ch33.Adicionar(10, 12, 15);

            ch34.Adicionar(10, 9, 15);
            ch34.Adicionar(9, 9, 15);
            ch34.Adicionar(9, 12, 15);
            ch34.Adicionar(10, 12, 15);

            ch35.Adicionar(10, 9, 14);
            ch35.Adicionar(10, 12, 14);
            ch35.Adicionar(10, 12, 15);
            ch35.Adicionar(10, 9, 15);

            ch36.Adicionar(9, 9, 14);
            ch36.Adicionar(9, 12, 14);
            ch36.Adicionar(9, 12, 15);
            ch36.Adicionar(9, 9, 15);

            ch37.Adicionar(10, 9, 17);
            ch37.Adicionar(9, 9, 17);
            ch37.Adicionar(9, 9, 18);
            ch37.Adicionar(10, 9, 18);

            ch38.Adicionar(10, 12, 17);
            ch38.Adicionar(9, 12, 17);
            ch38.Adicionar(9, 12, 18);
            ch38.Adicionar(10, 12, 18);

            ch39.Adicionar(10, 9, 17);
            ch39.Adicionar(9, 9, 17);
            ch39.Adicionar(9, 12, 18);
            ch39.Adicionar(10, 12, 18);

            ch40.Adicionar(10, 9, 18);
            ch40.Adicionar(9, 9, 18);
            ch40.Adicionar(9, 12, 18);
            ch40.Adicionar(10, 12, 18);

            ch41.Adicionar(10, 9, 17);
            ch41.Adicionar(10, 12, 17);
            ch41.Adicionar(10, 12, 18);
            ch41.Adicionar(10, 9, 18);

            ch42.Adicionar(9, 9, 17);
            ch42.Adicionar(9, 12, 17);
            ch42.Adicionar(9, 12, 18);
            ch42.Adicionar(9, 9, 18);

            ch43.Adicionar(0, 12, 11);
            ch43.Adicionar(10, 12, 11);
            ch43.Adicionar(10, 12, 18);
            ch43.Adicionar(0, 12, 18);

            ch44.Adicionar(0, 13, 11);
            ch44.Adicionar(10, 13, 11);
            ch44.Adicionar(10, 13, 18);
            ch44.Adicionar(0, 13, 18);

            ch45.Adicionar(0, 12, 11);
            ch45.Adicionar(10, 12, 11);
            ch45.Adicionar(10, 13, 11);
            ch45.Adicionar(0, 13, 11);

            ch46.Adicionar(0, 12, 18);
            ch46.Adicionar(10, 12, 18);
            ch46.Adicionar(10, 13, 18);
            ch46.Adicionar(0, 13, 18);

            ch47.Adicionar(0, 12, 11);
            ch47.Adicionar(0, 12, 18);
            ch47.Adicionar(0, 13, 18);
            ch47.Adicionar(0, 13, 11);

            ch48.Adicionar(10, 12, 11);
            ch48.Adicionar(10, 12, 18);
            ch48.Adicionar(10, 13, 18);
            ch48.Adicionar(10, 13, 11);

            //-----------------------------------------------

            ll1.Adicionar(11,8,18);
            ll1.Adicionar(11, 8, 17);
            ll1.Adicionar(11, 7, 16);
            ll1.Adicionar(11, 6, 16);
            ll1.Adicionar(11, 5, 17);
            ll1.Adicionar(11, 5, 18);
            ll1.Adicionar(11, 6, 19);
            ll1.Adicionar(11, 7, 19);

            ll2.Adicionar(10, 8, 18);
            ll2.Adicionar(10, 8, 17);
            ll2.Adicionar(10, 7, 16);
            ll2.Adicionar(10, 6, 16);
            ll2.Adicionar(10, 5, 17);
            ll2.Adicionar(10, 5, 18);
            ll2.Adicionar(10, 6, 19);
            ll2.Adicionar(10, 7, 19);

            ll3.Adicionar(11,8,18);
            ll3.Adicionar(11,8,17);
            ll3.Adicionar(10, 8, 17);
            ll3.Adicionar(10, 8, 18);

            ll4.Adicionar(11, 5, 18);
            ll4.Adicionar(11, 5, 17);
            ll4.Adicionar(10, 5, 17);
            ll4.Adicionar(10, 5, 18);

            ll5.Adicionar(11, 7, 16);
            ll5.Adicionar(11, 6, 16);
            ll5.Adicionar(10, 7, 16);
            ll5.Adicionar(10, 6, 16);

            ll6.Adicionar(11, 7, 19);
            ll6.Adicionar(11, 6, 19);
            ll6.Adicionar(10, 6, 19);
            ll6.Adicionar(10, 7, 19);

            ll7.Adicionar(11, 7, 19);
            ll7.Adicionar(11, 8, 18);
            ll7.Adicionar(10, 8, 18);
            ll7.Adicionar(10, 7, 19);

            ll8.Adicionar(11, 7, 16);
            ll8.Adicionar(11, 8, 17);
            ll8.Adicionar(10, 8, 17);
            ll8.Adicionar(10, 7, 16);

            ll9.Adicionar(11, 6, 19);
            ll9.Adicionar(11, 5, 18);
            ll9.Adicionar(10, 5, 18);
            ll9.Adicionar(10, 6, 19);

            ll10.Adicionar(11,6, 16);
            ll10.Adicionar(11, 5, 17);
            ll10.Adicionar(10, 5, 17);
            ll10.Adicionar(10, 6, 16);

            ll11.Adicionar(-1, 8, 18);
            ll11.Adicionar(-1, 8, 17);
            ll11.Adicionar(-1, 7, 16);
            ll11.Adicionar(-1, 6, 16);
            ll11.Adicionar(-1, 5, 17);
            ll11.Adicionar(-1, 5, 18);
            ll11.Adicionar(-1, 6, 19);
            ll11.Adicionar(-1, 7, 19);

            ll12.Adicionar(0, 8, 18);
            ll12.Adicionar(0, 8, 17);
            ll12.Adicionar(0, 7, 16);
            ll12.Adicionar(0, 6, 16);
            ll12.Adicionar(0, 5, 17);
            ll12.Adicionar(0, 5, 18);
            ll12.Adicionar(0, 6, 19);
            ll12.Adicionar(0, 7, 19);

            ll13.Adicionar(-1, 8, 18);
            ll13.Adicionar(-1, 8, 17);
            ll13.Adicionar(0, 8, 17);
            ll13.Adicionar(0, 8, 18);

            ll14.Adicionar(-1, 5, 18);
            ll14.Adicionar(-1, 5, 17);
            ll14.Adicionar(0, 5, 17);
            ll14.Adicionar(0, 5, 18);

            ll15.Adicionar(-1, 7, 16);
            ll15.Adicionar(-1, 6, 16);
            ll15.Adicionar(0, 7, 16);
            ll15.Adicionar(0, 6, 16);

            ll16.Adicionar(-1, 7, 19);
            ll16.Adicionar(-1, 6, 19);
            ll16.Adicionar(0, 6, 19);
            ll16.Adicionar(0, 7, 19);

            ll17.Adicionar(-1, 7, 19);
            ll17.Adicionar(-1, 8, 18);
            ll17.Adicionar(0, 8, 18);
            ll17.Adicionar(0, 7, 19);

            ll18.Adicionar(-1, 7, 16);
            ll18.Adicionar(-1, 8, 17);
            ll18.Adicionar(0, 8, 17);
            ll18.Adicionar(0, 7, 16);

            ll19.Adicionar(-1, 6, 19);
            ll19.Adicionar(-1, 5, 18);
            ll19.Adicionar(0, 5, 18);
            ll19.Adicionar(0, 6, 19);

            ll20.Adicionar(-1, 6, 16);
            ll20.Adicionar(-1, 5, 17);
            ll20.Adicionar(0, 5, 17);
            ll20.Adicionar(0, 6, 16);

            ll21.Adicionar(11, 8, 13);
            ll21.Adicionar(11, 8, 12);
            ll21.Adicionar(11, 7, 11);
            ll21.Adicionar(11, 6, 11);
            ll21.Adicionar(11, 5, 12);
            ll21.Adicionar(11, 5, 13);
            ll21.Adicionar(11, 6, 14);
            ll21.Adicionar(11, 7, 14);

            ll22.Adicionar(10, 8, 13);
            ll22.Adicionar(10, 8, 12);
            ll22.Adicionar(10, 7, 11);
            ll22.Adicionar(10, 6, 11);
            ll22.Adicionar(10, 5, 12);
            ll22.Adicionar(10, 5, 13);
            ll22.Adicionar(10, 6, 14);
            ll22.Adicionar(10, 7, 14);

            ll23.Adicionar(11, 8, 12);
            ll23.Adicionar(11, 8, 13);
            ll23.Adicionar(10, 8, 13);
            ll23.Adicionar(10, 8, 12);

            ll24.Adicionar(11, 5, 12);
            ll24.Adicionar(11, 5, 13);
            ll24.Adicionar(10, 5, 13);
            ll24.Adicionar(10, 5, 12);

            ll25.Adicionar(11, 7, 14);
            ll25.Adicionar(11, 6, 14);
            ll25.Adicionar(10, 7, 14);
            ll25.Adicionar(10, 6, 14);

            ll26.Adicionar(11, 7, 11);
            ll26.Adicionar(11, 6, 11);
            ll26.Adicionar(10, 6, 11);
            ll26.Adicionar(10, 7, 11);

            ll27.Adicionar(11, 7, 11);
            ll27.Adicionar(11, 8, 12);
            ll27.Adicionar(10, 8, 12);
            ll27.Adicionar(10, 7, 11);

            ll28.Adicionar(11, 7, 14);
            ll28.Adicionar(11, 8, 13);
            ll28.Adicionar(10, 8, 13);
            ll28.Adicionar(10, 7, 14);

            ll29.Adicionar(11, 6, 11);
            ll29.Adicionar(11, 5, 12);
            ll29.Adicionar(10, 5, 12);
            ll29.Adicionar(10, 6, 11);

            ll30.Adicionar(11, 6, 14);
            ll30.Adicionar(11, 5, 13);
            ll30.Adicionar(10, 5, 13);
            ll30.Adicionar(10, 6, 14);

            ll31.Adicionar(-1, 8, 13);
            ll31.Adicionar(-1, 8, 12);
            ll31.Adicionar(-1, 7, 11);
            ll31.Adicionar(-1, 6, 11);
            ll31.Adicionar(-1, 5, 12);
            ll31.Adicionar(-1, 5, 13);
            ll31.Adicionar(-1, 6, 14);
            ll31.Adicionar(-1, 7, 14);

            ll32.Adicionar(0, 8, 13);
            ll32.Adicionar(0, 8, 12);
            ll32.Adicionar(0, 7, 11);
            ll32.Adicionar(0, 6, 11);
            ll32.Adicionar(0, 5, 12);
            ll32.Adicionar(0, 5, 13);
            ll32.Adicionar(0, 6, 14);
            ll32.Adicionar(0, 7, 14);

            ll33.Adicionar(-1, 8, 12);
            ll33.Adicionar(-1, 8, 13);
            ll33.Adicionar(0, 8, 13);
            ll33.Adicionar(0, 8, 12);

            ll34.Adicionar(-1, 5, 12);
            ll34.Adicionar(-1, 5, 13);
            ll34.Adicionar(0, 5, 13);
            ll34.Adicionar(0, 5, 12);

            ll35.Adicionar(-1, 7, 14);
            ll35.Adicionar(-1, 6, 14);
            ll35.Adicionar(0, 7, 14);
            ll35.Adicionar(0, 6, 14);

            ll36.Adicionar(-1, 7, 11);
            ll36.Adicionar(-1, 6, 11);
            ll36.Adicionar(0, 6, 11);
            ll36.Adicionar(0, 7, 11);

            ll37.Adicionar(-1, 7, 11);
            ll37.Adicionar(-1, 8, 12);
            ll37.Adicionar(0, 8, 12);
            ll37.Adicionar(0, 7, 11);

            ll38.Adicionar(-1, 7, 14);
            ll38.Adicionar(-1, 8, 13);
            ll38.Adicionar(0, 8, 13);
            ll38.Adicionar(0, 7, 14);

            ll39.Adicionar(-1, 6, 11);
            ll39.Adicionar(-1, 5, 12);
            ll39.Adicionar(0, 5, 12);
            ll39.Adicionar(0, 6, 11);

            ll40.Adicionar(-1, 6, 14);
            ll40.Adicionar(-1, 5, 13);
            ll40.Adicionar(0, 5, 13);
            ll40.Adicionar(0, 6, 14);
            //------------------------------------------------

            ve1.Adicionar(9, 9, 18);
            ve1.Adicionar(9, 12, 18);
            ve1.Adicionar(1, 12, 18);
            ve1.Adicionar(1, 9, 18);

            ve2.Adicionar(9, 9, 11);
            ve2.Adicionar(9, 12, 11);
            ve2.Adicionar(1, 12, 11);
            ve2.Adicionar(1, 9, 11);

            ve3.Adicionar(10, 9, 12);
            ve3.Adicionar(10, 9, 14);
            ve3.Adicionar(10, 12, 14);
            ve3.Adicionar(10, 12, 12);

            ve4.Adicionar(10, 9, 15);
            ve4.Adicionar(10, 9, 17);
            ve4.Adicionar(10, 12, 17);
            ve4.Adicionar(10, 12, 15);

            ve5.Adicionar(0, 9, 12);
            ve5.Adicionar(0, 9, 14);
            ve5.Adicionar(0, 12, 14);
            ve5.Adicionar(0, 12, 12);

            ve6.Adicionar(0, 9, 15);
            ve6.Adicionar(0, 9, 17);
            ve6.Adicionar(0, 12, 17);
            ve6.Adicionar(0, 12, 15);


            //------------------------------------------------
            Parte parte1 = new Parte();
            parte1.Adicionar(a);
            parte1.Adicionar(b);
            parte1.Adicionar(c);
            parte1.Adicionar(d);
            parte1.Adicionar(f);
            parte1.Adicionar(g);

            Parte parte2 = new Parte();
            parte2.Adicionar(r1);
            parte2.Adicionar(r2);
            parte2.Adicionar(r3);
            parte2.Adicionar(r4);
            parte2.Adicionar(r5);

            Parte parte3 = new Parte();

            parte3.Adicionar(ch1);
            parte3.Adicionar(ch2);
            parte3.Adicionar(ch3);
            parte3.Adicionar(ch4);
            parte3.Adicionar(ch5);
            parte3.Adicionar(ch6);

            parte3.Adicionar(ch7);
            parte3.Adicionar(ch8);
            parte3.Adicionar(ch9);
            parte3.Adicionar(ch10);
            parte3.Adicionar(ch11);
            parte3.Adicionar(ch12);

            parte3.Adicionar(ch13);
            parte3.Adicionar(ch14);
            parte3.Adicionar(ch15);
            parte3.Adicionar(ch16);
            parte3.Adicionar(ch17);
            parte3.Adicionar(ch18);

            parte3.Adicionar(ch19);
            parte3.Adicionar(ch20);
            parte3.Adicionar(ch21);
            parte3.Adicionar(ch22);
            parte3.Adicionar(ch23);
            parte3.Adicionar(ch24);

            parte3.Adicionar(ch25);
            parte3.Adicionar(ch26);
            parte3.Adicionar(ch27);
            parte3.Adicionar(ch28);
            parte3.Adicionar(ch29);
            parte3.Adicionar(ch30);

            parte3.Adicionar(ch31);
            parte3.Adicionar(ch32);
            parte3.Adicionar(ch33);
            parte3.Adicionar(ch34);
            parte3.Adicionar(ch35);
            parte3.Adicionar(ch36);

            parte3.Adicionar(ch37);
            parte3.Adicionar(ch38);
            parte3.Adicionar(ch39);
            parte3.Adicionar(ch40);
            parte3.Adicionar(ch41);
            parte3.Adicionar(ch42);

            parte3.Adicionar(ch43);
            parte3.Adicionar(ch44);
            parte3.Adicionar(ch45);
            parte3.Adicionar(ch46);
            parte3.Adicionar(ch47);
            parte3.Adicionar(ch48);

            Parte parte4 = new Parte();

            parte4.Adicionar(ll1);
            parte4.Adicionar(ll2);
            parte4.Adicionar(ll3);
            parte4.Adicionar(ll4);
            parte4.Adicionar(ll5);
            parte4.Adicionar(ll6);
            parte4.Adicionar(ll7);
            parte4.Adicionar(ll8);
            parte4.Adicionar(ll9);
            parte4.Adicionar(ll10);
            parte4.Adicionar(ll11);
            parte4.Adicionar(ll12);
            parte4.Adicionar(ll13);
            parte4.Adicionar(ll14);
            parte4.Adicionar(ll15);
            parte4.Adicionar(ll16);
            parte4.Adicionar(ll17);
            parte4.Adicionar(ll18);
            parte4.Adicionar(ll19);
            parte4.Adicionar(ll20);
            parte4.Adicionar(ll21);
            parte4.Adicionar(ll22);
            parte4.Adicionar(ll23);
            parte4.Adicionar(ll24);
            parte4.Adicionar(ll25);
            parte4.Adicionar(ll26);
            parte4.Adicionar(ll27);
            parte4.Adicionar(ll28);
            parte4.Adicionar(ll29);
            parte4.Adicionar(ll30);
            parte4.Adicionar(ll31);
            parte4.Adicionar(ll32);
            parte4.Adicionar(ll33);
            parte4.Adicionar(ll34);
            parte4.Adicionar(ll35);
            parte4.Adicionar(ll36);
            parte4.Adicionar(ll37);
            parte4.Adicionar(ll38);
            parte4.Adicionar(ll39);
            parte4.Adicionar(ll40);

            Parte parte5 = new Parte();

            parte5.Adicionar(ve1);
            parte5.Adicionar(ve2);
            parte5.Adicionar(ve3);
            parte5.Adicionar(ve4);
            parte5.Adicionar(ve5);
            parte5.Adicionar(ve6);


            muro = new Objeto();
            muro.AdicionarParte("muro", parte1);

            repisa = new Objeto();
            repisa.AdicionarParte("Repisa", parte2);

            chasis = new Objeto();
            chasis.AdicionarParte("Chasis", parte3);

            llanta = new Objeto();
            llanta.AdicionarParte("llanta", parte4);

            ventana = new Objeto();
            ventana.AdicionarParte("ventana",parte5);

            cam = new Camera(initialPosition, initialFront, initialUp , cameraSpeed);

            base.OnLoad(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);
            base.OnUnload(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnRenderFrame(FrameEventArgs e)
        {


            //GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();

            Matrix4 viewMatrix = cam.GetViewMatrix();
            //Matrix4 viewMatrix = Matrix4.LookAt(new Vector3(p.x + 15, p.y, p.z), Vector3.Zero, Vector3.UnitY);//costado eje x
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMatrix);

            //-----------------------

            muro.Dibujar();
            repisa.Dibujar();
            chasis.Dibujar();
            llanta.Dibujar();
            ventana.Dibujar();

            //-----------------------
            Context.SwapBuffers();
            base.OnRenderFrame(e);

        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            float d = 30;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            //GL.Frustum(-80, 80, -80, 80, 4, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }

    }
}
