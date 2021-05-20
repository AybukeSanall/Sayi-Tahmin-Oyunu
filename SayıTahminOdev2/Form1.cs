using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıTahminOdev2
{ 
    public partial class Form1 : Form
    {
        int sayi,sayi2;//sayi değişkeni yerini ve varlığı doğru olan sayiları tutmak için
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            button1.Enabled = false;   
            uret: //random sayı oluşturmak için

            Random sayi_pizza = new Random(); //Random sayı oluşturmak için kullandığımız random sayı
         int   s1=sayi_pizza.Next(1,10) , s2 = sayi_pizza.Next(0, 10), s3 = sayi_pizza.Next(0, 10),s4=sayi_pizza.Next(0,10);
            if (s1 == s2 || s1 == s3 || s1 == s4 || s2 == s3 || s2 == s4 || s3 == s4) //sayıların birbirinden farklı olması için 
            {
                goto uret; //farklı değilse tekrar uretir.
            }
            else
            {
                label1.Text = s1 + "" + s2 + "" + s3 + "" + s4; //oluşturulan tek haneli sayo
            }
            char [] sayilar_zuzu(string girilenmetin)
            {
                Char[] dizi = girilenmetin.ToCharArray();
                return dizi;
            }
            char[] yeni = sayilar_zuzu(label1.Text);
            foreach(char eleman in yeni)
            {
                listBox1.Items.Add(eleman.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
           
            textBox5.Text = "0";
            textBox6.Text = "0";
            sayi = 0;
            sayi2 = 0;
            
            if (textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text=="")
            {
                MessageBox.Show("Lütfen tüm basamakları tahmin ediniz");
                this.Close();
            }
            if (textBox1.Text == listBox1.Items[0].ToString())
            {
                sayi++;

                sayi2 = 0;


                textBox6.Text = "+" + Convert.ToString(sayi);
                textBox5.Text = "-" + Convert.ToString(sayi2);

            }
            else
            {
                foreach (string item in listBox1.Items)
                {
                    if (item.ToLower().Contains(textBox1.Text.ToLower()))
                        ++sayi2;
                    textBox5.Text = "-" + Convert.ToString(sayi2);
                    textBox6.Text = "+" + Convert.ToString(sayi);

                }
            }
            if(textBox2.Text == listBox1.Items[1].ToString())
            {
                sayi++;

                textBox6.Text = "+" + Convert.ToString(sayi);
                textBox5.Text = "-" + Convert.ToString(sayi2);

            }
            else
            {
                foreach (string item in listBox1.Items)
                {
                    if (item.ToLower().Contains(textBox2.Text.ToLower()))
                        sayi2++;
                    textBox5.Text = "-" + Convert.ToString(sayi2);
                    textBox6.Text = "+" + Convert.ToString(sayi);

                }
            }
            if (textBox3.Text == listBox1.Items[2].ToString())
            {
                sayi++;

                textBox6.Text = "+" + Convert.ToString(sayi);
                textBox5.Text = "-" + Convert.ToString(sayi2);

            }
            else {
                foreach (string item in listBox1.Items)
                {
                    if (item.ToLower().Contains(textBox3.Text.ToLower()))
                        sayi2++;
                    textBox5.Text = "-" + Convert.ToString(sayi2);
                    textBox6.Text = "+" + Convert.ToString(sayi);

                }
            }
            if (textBox4.Text == listBox1.Items[3].ToString())
            {
                sayi++;

                textBox6.Text = "+" + Convert.ToString(sayi);
                textBox5.Text = "-" + Convert.ToString(sayi2);

            }
            else
            {
                foreach (string item in listBox1.Items)
                {
                    if (item.ToLower().Contains(textBox3.Text.ToLower()))
                        sayi2++;
                    textBox5.Text = "-" + Convert.ToString(sayi2);
                    textBox6.Text = "+" + Convert.ToString(sayi);

                }
            }
            if ((textBox6.Text == "+4") && (textBox5.Text == "-0"))
            {
                MessageBox.Show("Tebrikler Kazandınız");
                this.Close();
            }
            
        }
        }

        }
        
                    
                
                   
               
            
        
    

