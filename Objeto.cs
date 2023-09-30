using OpenTK.Input;
using Proyecto1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Objeto
    {
        Hashtable partes;

        public Objeto()
        {
            partes = new Hashtable();
        }

        public void AdicionarParte(String s, Parte p)
        {
            partes.Add(s, p);
        }

        public void EliminarParte(String s)
        {
            partes.Remove(s);
        }

        public void Dibujar()
        {
            foreach (Parte valor in partes.Values)
            {
                valor.Dibujar();
            }
        }
    }
}
