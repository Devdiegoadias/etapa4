using System;
using System.Collections;
using System.Collections.Generic;

namespace etapa4
{
    public abstract class Veiculo
    {
        private bool _automatico;
        private string _combustivel;

        public void ColocarCombustível()
        {
            Console.WriteLine("Basta colocar combustivel necessário");
        }

        #region Propriedades Veiculo        
        
        public bool Automatico
        {
            get
            {
                return _automatico;
            }
            set
            {
                _automatico = value;
            }
        }

        public string Combustivel
        {
            get
            {
                return _combustivel;
            }
            set
            {
                _combustivel = value;
            }
        }
        #endregion

        public Veiculo()
        {
            Console.WriteLine("Eu sou um veículo");
        }

        public abstract void Acelerar();
        public abstract void Freiar();
    }

    public class Aviao : Veiculo
    {
        public Aviao()
        {
            Console.WriteLine("Eu sou um avião.");
        }

        public override void Acelerar()
        {
                
        }

        public override void Freiar()
        {

        }
    }

    public class Carro : Veiculo
    {
        public Carro()
        {
            Console.WriteLine("Eu sou um carro.");
        }

        public override void Acelerar()
        {

        }

        public override void Freiar()
        {

        }
    }

    public class Colaborador
    {
        private int _matricula;
        private string _nome;
        private string _cpf;
        private bool _ativo;
        private Veiculo _veiculo;

        //Não é preciso declarar 
        public Colaborador()
        {

        }

        public Colaborador(int matricula, string nome, string cpf, bool ativo, Veiculo veiculo)
        {
            _matricula = matricula;
            _nome = nome;
            _cpf = cpf;
            _ativo = ativo;
            _veiculo = veiculo;
        }

        //Usando propriedades, Getter e Setter
        #region Propriedades Colaborador
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

        public bool Ativo
        {
            get
            {
                return _ativo;
            }
            set
            {
                _ativo = value;
            }
        }

        public Veiculo Veiculo
        {
            get
            {
                return _veiculo;
            }
            set
            {
                _veiculo = value;
            }
        }
        #endregion

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
                Aviao a = new Aviao();               
                
                
                var listaColaboradores = new ArrayList();
                Colaborador c1 = new Colaborador(111, "aaaa", "cpf1", false, new Carro());
                Colaborador c2 = new Colaborador(222, "bbb", "cpf2", false, new Carro());
                Colaborador c3 = new Colaborador(333, "ccc", "cpf3", false, new Aviao());

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
                    Console.WriteLine(c.Veiculo);
                }

                //Exemplo de Varrendo o nome;
                var lstNome = new List<string>();
                string nome = string.Empty;

                lstNome.Add("Diego A. Dias");
                lstNome.Add("Mateus Oliveira");
                lstNome.Add("Leonardo da Silva Xavier");

                foreach (var var in lstNome)
                {
                    if (var.Contains("Leo"))
                    {
                        nome = var;
                    }
                }

                //Exemplo calculando dias faltantes;
                DateTime nascimentoMateus = new DateTime(2001, 01, 22);
                DateTime niverMateus = DateTime.Now; //new DateTime(DateTime.Now.Year, 01, 22);
                DateTime proxNiverMateus = new DateTime(DateTime.Now.Year + 1, 01, 22);
                TimeSpan t = proxNiverMateus.Subtract(niverMateus);

                Console.WriteLine("Falta " + t.Days.ToString() + " dias para o aniversário do Mateus");

                Console.WriteLine("O nome é " + nome);

                string condicao = string.Empty;

                //Menu
                switch (condicao)
                {
                    case "caso1":
                        // Se a condicao for igual ao caso1 executamos esse trecho de código entre o case e o break
                        break;
                    case "caso2":
                        // Se a condicao for igual ao caso2 executamos esse trecho de código entre o case e o break
                        break;
                    default:
                        // Se a condicao diferente de todos os casos acima executamos esse trecho de código
                        break;
                }

                int sum1 = 10;
                int sum2 = 10;
                int vSoma = sum1 + sum2;
                int vSoma2 = vSoma * 1;

                //Operadores
                //&& - AND
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
                    Console.WriteLine("multiplicando Sum1 * i (" + i + ")" + sum1 * i);
                }

                ///Continuação ETAPA 4                 

                // Array instanciado com tamanho 3
                int[] segundoArray = new int[3];

                // Array inicializado com 3 elementos
                int[] terceiroArray = new int[] { 1, 2, 3 };

                // Array inicializado com 4 elementos do tipo string
                string[] quartoArray = new string[] { "a", "b", "c", "d" };

                Console.WriteLine(quartoArray[0] + quartoArray[1] + quartoArray[2] + quartoArray[3]);

                List<int> meuList = new List<int>();

                meuList.Add(1); //0
                meuList.Add(2); //1
                meuList.Add(3); //2
                meuList.Add(4);
                meuList.Add(5);
                meuList.Add(99);

                var numeros = new List<string>() { "Um", "Dois", "Três" };

                foreach (var numero in numeros)
                {
                    // Imprime no console cada um dos numeros do List
                    Console.WriteLine(numero);
                }

                var k = 10;
                while (k > 0)
                {
                    Console.WriteLine(k);

                    if (k == 5) //== significa 'igual'
                    {
                        break;
                    }

                    k--; //k=k-1
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
