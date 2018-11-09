using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;

namespace RSAlgorithm
{
    // Clase que se usará para realizar las operaciones de cifrado y descifrado de datos.
    public class RSA

    {
        // Variables que se utilizarán para realizar el cifrado.
        private int p, q, n, phi_n, e, d;
        private ArrayList Nprimos;
        
        // Método que calcula las claves(p, q, n, phi(n), e , d) que se usarán para cirar y descifrar los datos.
        public void calcularClaves()
        {
            Random rnd = new Random();
            this.Nprimos = generarPrimos();
            this.p = (int)Nprimos[rnd.Next(0, Nprimos.Count - 1)];
            this.q = (int)Nprimos[rnd.Next(0, Nprimos.Count - 1)];
            this.n = this.p * this.q;
            this.phi_n = (this.p - 1) * (this.q - 1);
            while (true) {
                 this.e = (int)Nprimos[rnd.Next(1, Nprimos.Count-1)];
                 if (e < this.phi_n)
                     break;
             }
           
            
            this.d = this.InvMult(this.e, this.phi_n);
           

        }

        // Método que genera una lista de números primos que se usará para generar las claves.
        public ArrayList generarPrimos()
        {
            
            ArrayList primos = new ArrayList();

            for(int x=2; x<1024;x++)
            {
                primos.Add(x);
            }
            
            for(int numero =2;numero<1024; numero++)
            {
                int n = numero * 2;
                while (n < (int)primos[primos.Count-1])
                {
                    
                    primos.Remove(n);
                    n += numero;
                    
                }
            }
            return primos;
        }

        // Método que aplica el algoritmo de cifrado con una cadena dada. Devuelve la cadena cifrada.
        public String cifrar(String datos)
        {
            String codigo = "", final="";
            foreach(char caracter in datos)
            {


                codigo += (int)BigInteger.ModPow(Convert.ToUInt32(caracter), this.e, this.n)+" "; 
                
            }
            foreach (char caracter in codigo)
            {
                
                final += Convert.ToChar(Convert.ToInt32(caracter)+50);

            }
            return final;
           
        }

        // Método que aplica el algoritmo de descifrado con una cadena dada. Devuelve la cadena descifrada.
        public String descifrar(String datos)
        {
            String codigo = "", final = "";
            String[] arregloDatos;
            try
            {
                foreach (char dato in datos)
                {
                    codigo += Convert.ToChar(Convert.ToInt32(dato) - 50);
                }
                arregloDatos = codigo.Split(' ');

                foreach (String dato in arregloDatos)
                {
                    if (dato != "")
                        final += Convert.ToChar((int)BigInteger.ModPow(Convert.ToUInt32(dato), this.d, this.n));
                }
                return final;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. Es posible que los datos ingresados no hayan sido generados con las claves determinadas.");
               
            }
            return final;  
        }
        // Método que calcula e inverso multiplicativo modular. Se usará para calcular "d".
        public int InvMult(int e, int phi_n)
        {
            int d = 1;
            while (true)
            {
                if ((e * d) % phi_n == 1)
                    return d;
                d++;
            }
        }
        // Método que establece "p" al valor del atributo recibido.
        public void setP(int p)
        {
            this.p = p;
        }
       // Método que devuelve el valor de "p".
        public int getP()
        {
            return this.p;
        }
        // Método que establece "q" al valor del atributo recibido.
        public void setQ(int q)
        {
            this.q = q;
        }
        // Método que devuelve el valor de "q".
        public int getQ()
        {
            
            return this.q;
        }
        // Método que establece "n" al valor del atributo recibido.
        public void setN(int n)
        {
            this.n = n;
        }
        // Método que devuelve el valor de "n".
        public int getN()
        {

            return this.n;
        }
        // Método que establece "phi(n)" al valor del atributo recibido.
        public void setPhi_N(int phi_n)
        {
            this.phi_n = phi_n;
        }
        // Método que devuelve el valor de "phi(n)".
        public int getPhi_n()
        {

            return this.phi_n;
        }
        // Método que establece "e" al valor del atributo recibido.
        public void setE(int e)
        {
            this.e = e;
        }
        // Método que devuelve el valor de "e".
        public int getE()
        {

            return this.e;
        }
        // Método que establece "d" al valor del atributo recibido.
        public void setD(int d)
        {
            this.d = d;
        }
        // Método que devuelve el valor de "d".
        public int getD()
        {

            return this.d;
        }

        
    }
}
