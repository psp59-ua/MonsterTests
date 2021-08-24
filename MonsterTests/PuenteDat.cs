using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterTests
{
    public struct Pregunta
    {
        public string pre;
        Respuesta respuesta;
    }

    public struct Respuesta
    {
        public string resp;
        public bool correcta;
    }

    class PuenteDat
    {
        public void leer(string ruta,TextBox texr)
        {
            Pregunta pregunta;
           // texr.text = "Se hizo clic";
            Stream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line;
            while((line= sr.ReadLine())!= null)
            {
                if (line[0] == '*')
                {
                   pregunta.pre = line;
                }

                //texr.Text = pregunta[0].pre;
            }


        }




    }
}
