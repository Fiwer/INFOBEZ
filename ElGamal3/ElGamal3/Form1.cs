using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Rand()//Ф-я получения случайного числа
        {
            Random random = new Random();
            return random.Next();
        }
        int power(int a, int b, int n) // a^b mod n - возведение a в степень b по модулю n
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }
        int mul(int a, int b, int n) // a*b mod n - умножение a на b по модулю n
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }
        void crypt(int p, int g, int x, string strIn)
        {
            txtBCrypt.Text = "";
            int y = power(g, x, p);
            txtBPublicKey.Text = "(" + p + "," + g + "," + y + ")";
            if (strIn.Length > 0)
            {
                char[] temp = new char[strIn.Length - 1];
                temp = strIn.ToCharArray();
                for (int i = 0; i <= strIn.Length - 1; i++)
                {
                    int m = (int)temp[i];
                    if (m > 0)
                    {
                        int k = Rand() % (p - 2) + 1; // 1 < k < (p-1)
                        int a = power(g, k, p); // a = g^k modp 
                        int b = mul(power(y, k, p), m, p); // b = y^k M modp
                        txtBCrypt.Text = txtBCrypt.Text + a + " " + b + " ";
                    }
                }
            }
        }
        void decrypt(int p, int x, string strIn)
        {
            if (strIn.Length > 0)
            {
                txtBDecrypt.Text = "";
                string[] strA = strIn.Split(' ');
                if (strA.Length > 0)
                {
                    for (int i = 0; i < strA.Length - 1; i += 2)
                    {
                        char[] a = new char[strA[i].Length];
                        char[] b = new char[strA[i + 1].Length];
                        int ai = 0;
                        int bi = 0;
                        a = strA[i].ToCharArray();
                        b = strA[i + 1].ToCharArray();
                        for (int j = 0; (j < a.Length); j++)
                        {
                            ai = ai * 10 + (int)(a[j] - 48); 
                        }
                        for (int j = 0; (j < b.Length); j++)
                        {
                            bi = bi * 10 + (int)(b[j] - 48);
                        }
                        if ((ai != 0) && (bi != 0))
                        {
                            int deM = mul(bi, power(ai, p - 1 - x, p), p);// формула для дешифрования  M = b(a^x)^-1 mod p = ba^(p-1-x) mod p
                            char m = (char)deM;
                            txtBDecrypt.Text = txtBDecrypt.Text + m;
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBSecretKey.Text.Length > 0)
            {
                int p = Convert.ToInt32(textBox_p.Text);
                int q = Convert.ToInt32(textBox_q.Text);

                int x = Convert.ToInt32(txtBSecretKey.Text);
                crypt(p, q, x, txtBIn.Text);
                decrypt(p, x, txtBCrypt.Text);
            }
            else
                MessageBox.Show("Введите p и q!");
        }

        private void txtBIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBCrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBSecretKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_q_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            //Решето Эратосфена
            listBox1.Items.Clear();
            Random random = new Random();
            List<int> primes = get_primes(10000);

            foreach (var item in primes)
                listBox1.Items.Add(item);


            textBox_p.Text = listBox1.Items[random.Next(226, listBox1.Items.Count)].ToString();
            textBox_q.Text = listBox1.Items[new Random().Next(50, 500)].ToString();
        }
        public static List<int> get_primes(int n)
        {

            bool[] is_prime = new bool[n + 1];
            for (int i = 2; i <= n; ++i)
                is_prime[i] = true;

            List<int> primes = new List<int>();

            for (int i = 2; i <= n; ++i)
                if (is_prime[i])
                {
                    primes.Add(i);
                    if (i * i <= n)
                        for (int j = i * i; j <= n; j += i)
                            is_prime[j] = false;
                }

            return primes;
        }
    }
}
