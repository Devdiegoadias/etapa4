using System;
using System.Collections;
using System.Collections.Generic;

namespace etapa4
{
    public class Colaborador
    {
        private int _matricula;
        private string _nome;
        private string _cpf;

        public Colaborador()
        {

        }

        public Colaborador(int matricula, string nome, string cpf)
        {
            _matricula = matricula;
            _nome = nome;
            _cpf = cpf;
        }

        public int Matricula
        {
            get
            {
                return _matricula;
            }
            set
            {
                _matricula = value;
            }
        }

        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public decimal Comissao(decimal salarioColaborador, int percentagem)
        {
            return salarioColaborador * percentagem;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sum1 = 10;
                int sum2 = 10;

                int vSoma = sum1 + sum2;
                int vSoma2 = vSoma * 1;

                // && - AND
                // || - OR
                //  ! - Negação

                bool comissao = true;

                if (!comissao)
                    Console.WriteLine("pagar comissao");
                else
                    Console.WriteLine("não pagar comissao");


                          //V         //V
                if (vSoma >= 20 || vSoma2 == 40)
                {
                    Console.WriteLine(">= que 20");
                    Console.WriteLine("---------");
                }
                else
                {
                    Console.WriteLine("< a 20");
                    Console.WriteLine("--------");
                }

                // % mod - Pega resto de divisão

                int j;

                for (int i = 1; i <= 10; i++)
                {
                    j = sum1 % i;

                    Console.WriteLine("j ->" + j);

                    Console.WriteLine("**********************");



                    //Console.WriteLine("multiplicando Sum1 * i (" + i + ")" + sum1 * i);
                }

                Console.ReadLine();

                var listaColaboradores = new ArrayList();

                Colaborador c1 = new Colaborador(111, "aaaa", "cpf1");
                Colaborador c2 = new Colaborador(222, "bbb", "cpf2");
                Colaborador c3 = new Colaborador(333, "ccc", "cpf3");

                listaColaboradores.Add(c1);
                listaColaboradores.Add(c2);
                listaColaboradores.Add(c3);

                IList<Colaborador> lC = new List<Colaborador>();

                foreach (Colaborador c in listaColaboradores)
                {
                    lC.Add(c);

                    Console.WriteLine(c.Nome);
                    Console.WriteLine(c.CPF);
                    Console.WriteLine(c.Matricula);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("E01" + ex.Message + ex.InnerException?.Message);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
