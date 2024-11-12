using System;
using System.Collections.Generic;

namespace Calculadoras
{
    public class Calculadora
    {
        private string data;
        private List<string> listaHistorico;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        
        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public List<string> Historico
        {
            get 
            {
                listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
                return listaHistorico;
            }
        }
    }
}
