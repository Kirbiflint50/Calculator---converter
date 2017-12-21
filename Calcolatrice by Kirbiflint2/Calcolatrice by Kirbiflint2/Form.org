using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;



namespace Calcolatrice_by_Kirbiflint2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double num1;
        int Operazione = 0; // 1 = addizione, 2 = sottrazione, 3 = moltiplicazione, 4 = divisione  
        int Risultato;
        ///static bool Risultato = false;
        //string Risultato; 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox1.Text.Contains("0"))
            {



            }*/

        



            //textBox1.Text = textBox1.Text + '0';


            /*if (textBox1.Text == "q" + "w" + "e" + "r" + "t" + "y" + "u" + "i" + "o" + "p" + "è" + "+" + "a" + "s" + "d" + "f" + "g"  + "h" + "j" + "k" + "l" + "ò" + "à" + "ù" + "<" + ">" + "z" + "x" + "c" + "v" + "b" + "n" + "m" + "," + "." + "-"
                
  + "=" + "'" + "ì" + ";" + ":" + "_") 




            {

                textBox1.Text = string.Empty;


            }*/










            //string numerouno = textBox1.Text;

            /*if (double.Parse( numeruno = ""))
            {

                textBox1.Clear();
            }*/










            //int NumeroUno = Convert.ToInt32(numerouno);



            //if (numerouno == null)



            //return;
            //return int.Parse(numerouno, (IFormatProvider)CultureInfo.CurrentCulture);
            //}

            //NumeroUno = numerouno;
            /*if (int.TryParse(textBox1.Text, out NumeroUno))
            {
                if ((NumeroUno > 0) && (NumeroUno < 10))
                {
                    textBox1.Text = String.Empty;
                }
            }



            if (double.TryParse(numerouno, out num1))
            {
                if ((numerouno > 0) &&())

            */


            //int NumeroUno = int.Parse(numerouno);



            //double numeruno = double.Parse(numerouno);



            //if (NumeroUno = 0)
            //{




            // }












            //string numerouno;


            //int Numerouno;


            /*while (true)
            {
                if (!int.TryParse(textBox1.Text = "0", out, Convert.ToDouble( num1)));
                {
                    textBox1.Text = String.Empty;
                }
                Console.Write(textBox1);
            }*/






        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //textBox4.Text = Convert.ToString(result);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //string Segno;

            //Console.Write(textBox3.Text);
            //segno = textBox3.Text;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //string Numerodue = textBox2.Text;

            //num2 = Convert.ToDouble(Numerodue);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 HxD = new Form2();
            HxD.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("0"))
            {



                textBox1.Text = "1";

            }
            else

                textBox1.Text = textBox1.Text + "1";
                //textBox1.Text = "1";



        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = 
            if (textBox1.Text.Contains("0"))
            {


                textBox1.Text = "2";

            }
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("0"))
            {



                textBox1.Text = "3";

            }
            else

                textBox1.Text = textBox1.Text + "3";

            //textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("0"))
            {



                textBox1.Text = "4";

            }
            else

                textBox1.Text = textBox1.Text + "4";


            ///textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("0"))
            {



                textBox1.Text = "5";

            }
            else

                textBox1.Text = textBox1.Text + "5";

            //textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("0"))
            {



                textBox1.Text = "6";

            }

            
            else

                textBox1.Text = textBox1.Text + "6";


            //textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Contains("0"))
            {



                textBox1.Text = "7";

            }
            else

                textBox1.Text = textBox1.Text + "7";

            //textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("0"))
            {



                textBox1.Text = "8";

            }
            else

                textBox1.Text = textBox1.Text + "8";



            //textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("0"))
            {



                textBox1.Text = "9";

            }
            else

                textBox1.Text = textBox1.Text + "9";



            //textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("0"))
            {



                textBox1.Text = textBox1.Text + "0";
            }

            
            else

                textBox1.Text = textBox1.Text + "0";

            /*if (textBox1.Text.Contains("00"))
            {


                textBox1.Text = textBox1.Text + "0";

            }*/








        }
    

        private void button17_Click(object sender, EventArgs e)
        {
            Form3 About = new Form3();
            About.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;  

            }
            if (e.KeyChar == '.')
            {

                if (textBox1.Text.Contains("."))
                    e.Handled = true;
                
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".")) 
            { }
            else

            textBox1.Text = textBox1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Risultato = 1
            ;
            //Risultato = textboxnumero;
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            switch (Risultato)
            {
                case 1:

                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + num1);
                    ///SpeechSynthesizer synth = new SpeechSynthesizer();
                    //synth.Speak();

                    break;

                case 2:

                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - num1);
                    break;

                case 3:

                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * num1);
                    break;

                case 4:

                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / num1);
                    break;



            }
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("hello");

            /*bool Risultato = Convert.ToBoolean(risultato);

            char risult = Convert.ToChar(Risultato); 

            switch (risult)
            {
                case 'a':

                    
                    textBox3.Text = "+" + (Risultato = Convert.ToBoolean(num1 + num2));
                    //string Risultatoadd;
                   /// Risultatoadd = Convert.ToString(Risultato);
                    //textBox4.Text = Risultatoadd;
                    textBox4.Text = Risultato.ToString();


                    break;


                case 'b':


                    textBox3.Text = "-" + (Risultato = System.Convert.ToBoolean(num1 - num2));
                    //string Risultatosott;
                    //Risultatosott = Convert.ToString(Risultato);
                    textBox4.Text = Risultato.ToString();
                    break;

                case 'c':

                    textBox3.Text = "X" + (Risultato = System.Convert.ToBoolean(num1 * num2));
                    //string RisultatoMolti;
                    //RisultatoMolti = Convert.ToString(Risultato);
                    textBox4.Text = Risultato.ToString();
                    break;


                case 'd':


                    textBox3.Text = ":" + (Risultato = System.Convert.ToBoolean(num1 / num2));
                    //string Risultatodiv;
                    //Risultatodiv = Convert.ToString(Risultato);
                    textBox4.Text = Risultato.ToString();
                    break;

            }*/



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*string numerouno;
            //int Numerouno;
            numerouno = textBox1.Text;
            
             
            
            num1 = Convert.ToDouble(numerouno);

            Console.Write(textBox1.Text); 

            
        */   
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Risultato = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Risultato = 3;                
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Risultato = 4;
        }


        /*public static class Melodie
        {
            private static SpeechLib.SpVoice WomenAgent = new SpeechLib.SpVoice();

            public static void AnnounceRestrictionOfAccount()
            {
                WomenAgent.Speak("You're account has been block by the system security", SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault);
            }

            public static void SayGoodBye()
            {
                WomenAgent.Speak("Goodbye!");
            }

            public static void WelcomeUser(User userToBeWelcomed)
            {
                string Salutation = ConstructWelcomeSpeech(userToBeWelcomed);
                WomenAgent.Speak(Salutation);
            }

            private static string ConstructWelcomeSpeech(User user)
            {
                string salutation = "Welcome ";
                if (user.Gender == "Male")
                {
                    salutation += " Mr. ";
                }
                else if (user.Gender == "Female")
                {
                    if (user.CivilStatus != null)
                    {
                        if (user.CivilStatus == "Single")
                            salutation += " Ms. ";
                        else
                            salutation += " Mrs. ";
                    }
                }
                salutation += user.FirstName + " " + user.LastName;
                return salutation;
            }

            public static void AnnounceMessage(string message)
            {
                WomenAgent.Speak(message);
          */
    }
        }


    
