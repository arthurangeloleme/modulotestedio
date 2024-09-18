using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraOperacoes
    {
        private List<string> listahistorico;

        public CalculadoraOperacoes()
        {
            listahistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            DateTime data = DateTime.Now;
            int res = num1 + num2;
            listahistorico.Insert(0, $"{data} || {num1} + {num2} = {res}");
            return res;
        }
        public int Subitrair(int num1, int num2)
        {
            DateTime data = DateTime.Now;
            int res = num1 - num2;
            listahistorico.Insert(0, $"{data} || {num1} - {num2} = {res}");
            return res;
        }
        public int Multiplicar(int num1, int num2)
        {
            DateTime data = DateTime.Now;
            int res = num1 * num2;
            listahistorico.Insert(0, $"{data} || {num1} * {num2} = {res}");
            return res;
        }
        public int Dividir(int num1, int num2)
        {
            DateTime data = DateTime.Now;
            int res = num1 / num2;
            listahistorico.Insert(0, $"{data} || {num1} / {num2} = {res}");
            return res;
        }
        public List<string> Historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count -3);
            return listahistorico;
        }
    }
}