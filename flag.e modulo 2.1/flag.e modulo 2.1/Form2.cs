using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flag.e_modulo_2._1
{
    public partial class Form2 : Form
    {
        Graphics g;
        Color cor = Color.Red;
        Boolean draw = false;
        Boolean paint = false;
        string respostaC;
        int RespostaE;
        int Num = 0;
        int tentativas = 6;
        
      
        public Form2()
        {
            InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            comboBox1.Visible = false;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == respostaC)
            {
panel1.Visible=false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
                button5.PerformClick();
                MessageBox.Show("Acertou a Bandeira"); Num += 1; tentativas = 6;

                
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
                button5.PerformClick();
                

            }

            else
            {
                MessageBox.Show("Errou uma resposta");
                tentativas -= 1;

            }
        
            if (tentativas == 2)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = true;
                panel5.Visible = false;
                panel6.Visible = false;
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
                button5.PerformClick();


            }
          

            if (tentativas == 3)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = false;
                panel6.Visible = false;
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
                button5.PerformClick();
            }
            if (tentativas == 4)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = false;
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
                button5.PerformClick();
            }
            if (tentativas == 5)
            {
               panel1.Visible = true; 
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = false;
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
                button5.PerformClick();
            }
            if (tentativas == 6)
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
                button5.PerformClick();
            }
            if (tentativas == 1)
            {
                panel5.Visible = false;
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
                button5.PerformClick();
            }
            if (Num == 1)

            {
                button2.Visible = true;
                
            }
            else if (Num == 2)
            {
                button3.Visible = true;
               
            }

            else if (Num == 3)
            {
                button4.Visible = true;
            }
            else if (Num == 4)
            {
                button5.Visible = true;
            }
        }
private void button1_Click(object sender, EventArgs e)
        {

            

            SolidBrush pincel = new SolidBrush(Color.Green);
            g.FillRectangle(pincel, 50, 100, 200, 250);
            SolidBrush pincel2 = new SolidBrush(Color.White);
            g.FillRectangle(pincel2, 250, 100, 200, 250);
            SolidBrush pincel3 = new SolidBrush(Color.Green);
            g.FillRectangle(pincel3, 450, 100, 200, 250);
            respostaC = "Nigeria";
            comboBox1.Visible = true;
         

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            SolidBrush pincel = new SolidBrush(Color.White);
            g.FillRectangle(pincel, 50, 100, 600, 150);
            SolidBrush pincel2 = new SolidBrush(Color.Red);
            g.FillRectangle(pincel2, 50, 222, 600, 128);
         
            respostaC = "Polónia";
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SolidBrush pincel = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(pincel, 50, 100, 200, 250);
            SolidBrush pincel2 = new SolidBrush(Color.Yellow);
            g.FillRectangle(pincel2, 250, 100, 200, 250);
            SolidBrush pincel3 = new SolidBrush(Color.Red);
            g.FillRectangle(pincel3, 450, 100, 200, 250);
            respostaC = "Roménia";

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            SolidBrush pincel = new SolidBrush(Color.Red);
            g.FillRectangle(pincel, 50, 100, 600, 150);
            SolidBrush pincel2 = new SolidBrush(Color.White);
            g.FillRectangle(pincel2, 50, 222, 600, 134);
            respostaC = "Indonésia";
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            SolidBrush pincel = new SolidBrush(Color.White);
            g.FillRectangle(pincel, 50, 100, 600, 60);
            SolidBrush pincel2 = new SolidBrush(Color.Red);
            g.FillRectangle(pincel2, 50, 150, 600, 134);
            SolidBrush pincel3 = new SolidBrush(Color.White);
            g.FillRectangle(pincel3, 50, 250, 600, 60);
            SolidBrush pincel4 = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(pincel4, 50, 50, 600, 60);
            SolidBrush pincel5 = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(pincel5, 50, 300, 600, 60);
            respostaC = "Costa Rica";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
    }

