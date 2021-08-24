using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MonsterTests
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        OpenFileDialog ofd = new OpenFileDialog();
        private void btnExam_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Documento de texto|*.txt";
            if( ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName; //ofd.SafeFileName;
                                            // leer(ruta);
                PuenteDat datos = new PuenteDat();
                datos.leer(ruta,texr);
               // texr.Text = "Se hizo clic";
            }
            
        }
        /*public static void leer(string ruta)
        {
            Stream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            

        }*/

       
    }
}
