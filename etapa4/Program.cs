using System;
using System.Collections;
using System.Collections.Generic;

namespace etapa4
{
    public class InfnetNegocioException : Exception
    {
        public InfnetNegocioException(string mensagem):base(mensagem)
        {
            
        }
    }

    public abstract class Veiculo
    {
        private string _combustivel;
        private string _modelo;
        private string _identificacao;

        public string Combustivel
        {
            get { return _combustivel; }
            set { _combustivel = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string Identificacao
        {
            get { return _identificacao; }
            set { _identificacao = value; }
        }

        public string Descricao()
        {
            return "Sou da classe Veiculo";
        }

    }

    public class helicoptero : Veiculo
    {
        private int _quantidadeHelice;

        public string Descricao()
        {
            return "Sou da classe Helicoptero";
        }

        #region Propriedades Helicoptero

        public int QuantidadeHelice
        {
            get { return _quantidadeHelice; }
            set { _quantidadeHelice = value; }
        }
        #endregion
    }

    public class Jato : Veiculo
    {
        private int _quantidadeTurbina;
       

        #region Propriedades Jato

        public int QuantidadeTurbina
        {
            get { return _quantidadeTurbina; }
            set { _quantidadeTurbina = value; }
        }
        #endregion
    }

    public class Carro : Veiculo
    {
        private string _placa;

        #region Propriedades carro

        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }
        #endregion
    }

    public class Colaborador
    {
        private int _matricula;
        private string _nome;
        private string _cpf;
        private bool _ativo;
        private int _nivel;
        private Veiculo _veiculo;


        public Colaborador(int matricula, string nome, string cpf, bool ativo, int nivel)
        {
            _matricula = matricula;
            _nome = nome;
            _cpf = cpf;
            _ativo = ativo;
            _nivel = nivel; // 1, 2 e 3
        }

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
            get { return _ativo; }
            set { _ativo = value; }
        }

        public Veiculo Veiculo
        {
            get { return _veiculo; }
            set 
            { 
                if(this.Nivel == 3 && value.GetType() != typeof(Jato))
                {
                    throw new InfnetNegocioException("Nivel 3 só pode usar jato.");
                }
                _veiculo = value; 
            }
        }

        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
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
                var lstNome = new List<string>();
                string nome = string.Empty;

                lstNome.Add("Diego A. Dias");
                lstNome.Add("Mateus Oliveira");
                lstNome.Add("Leonardo da Silva Xavier");

                var listaColaboradores = new ArrayList();

                /*
                 Área de produtos, solicitação Gerente josé, card 8892783 
                 Conforme a regra de negócio RN78, o funcionario que for nivel 3 pode só escolher jato; 
                */

                Colaborador c1 = new Colaborador(111, "Diego A. Dias", "cpf1", false, 3);
                Colaborador c2 = new Colaborador(222, "Mateus Oliveira", "cpf2", false, 2);
                Colaborador c3 = new Colaborador(333, "Leonardo da Silva Xavier", "cpf3", false, 1);

                c1.Veiculo = new helicoptero();
                Console.WriteLine(c1.Veiculo.Descricao());

                c1.Veiculo = new Carro();
                Console.WriteLine(c1.Veiculo.Descricao());

                c1.Veiculo = new Jato();
                Console.WriteLine(c1.Veiculo.Descricao());

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

                //pesquisando por nome
                foreach (var var in lstNome)
                {
                    if (var.Contains("Leo"))
                    {
                        nome = var;
                    }
                }

                //Diminuir 'tempo', subtrair datas
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
            catch (InfnetNegocioException ex)
            {
                throw new Exception("RN78 " + ex.Message);
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
