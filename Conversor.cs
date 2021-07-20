using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traductor_Texto_a_Binario
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
            result.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = CONVERTIR_A_BINARIO(textInput.Text);
        }

        private string CONVERTIR_A_BINARIO(string Input)
        {
            ASCII ascii = new ASCII();
            string Output = "";

            for (int letraActual = 0; letraActual < Input.Length; letraActual++)
            {
                string Letra = Convert.ToString(Input[letraActual]);
                int codigoAsciiLetra = Array.IndexOf(ascii.Letras_Ascii, Letra);

                for (int Contador2 = 0; Contador2 < ascii.Numero_Bits.Length; Contador2++)
                {
                    int[] letraBinario = new int[ascii.Numero_Bits.Length];

                    if (codigoAsciiLetra >= ascii.Numero_Bits[Contador2])
                    {

                        letraBinario[Contador2] = 1;
                        codigoAsciiLetra -= ascii.Numero_Bits[Contador2];
                    }

                    Output = Output + Convert.ToString(letraBinario[Contador2]);
                }

                if ((letraActual  + 1) % 4 == 0)
                    Output = Output + "\n";

                else
                    Output = Output + "   ";
            }

            return Output;
        }
        class ASCII
        {
            public int[] Numero_Bits = new int[8];
            static int[] Ascii_Decimal = new int[255];
            public string[] Letras_Ascii = new string[255];
            static string[] Letras_No_Null = { " ", "!", "\"", "#", "$", "%", "&", "\'", "(",")","*","+",",","-",".","/","0","1","2","3","4",
            "5","6","7","8","9",":",";","<","=",">","?","@","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V" ,
            "W","X","Y","Z","[","\\","]","^","_","`","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y",
            "z","{","|","}","~"};
            public ASCII()
            {
                int a = 0;
                for (int Contador = Numero_Bits.Length - 1; Contador >= 0; Contador--)
                {
                    if (Contador == Numero_Bits.Length - 1)
                    {
                        Numero_Bits[Contador] = 1;
                    }
                    else
                    {
                        Numero_Bits[Contador] = Numero_Bits[(Contador + 1)] * 2;
                    }
                }
                for (int Contador = 0; Contador < Ascii_Decimal.Length; Contador++)
                {
                    if (Contador < 32 || Contador > 126)
                    {
                        Letras_Ascii[Contador] = null;
                    }
                    else
                    {
                        Letras_Ascii[Contador] = Letras_No_Null[a];
                        a++;
                    }
                }
            }
        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
