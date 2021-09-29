using System;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Contas>();
    
        static void Main(string[] args){
            string opcaoUsuario = ObterOpcaoUsuario()
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario){
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        ListarContas();
                        break;
                    case "4":
                            ListarContas();
                        break;
                    case "5":
                        ListarContas();
                        break;
                    case "X":
                        ListarContas();
                        break;

                        
                }
                {
                    
                    default:
                        throw new ArgumentOutOfRangeException(); 
                }
                opcaoUsuario = ObterOpcaoUsuario();
                    
            }
            Console.WriteLine("Agradecemos sua Utilização! ");
            Console.WriteLine("Volte Sempre. ");
            Console.ReadLine();
        }
        private static void Sacar(){
            Console.Write("Digite o numero da conta: ")
            int indiceConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());
            listContas[indiceConta].Sacar(valorSaque);
        }
        private static void Depositar(){
            Console.Write("Digite o numero da conta: ")
            int indiceConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor a ser sacado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            listContas[indiceConta].Depositar(valorDeposito);
        }
        private static void Transferir(){
            Console.Write("Conta de Origem:");
            int indiceContaOrigem = int.Parse(console.ReadLine());
            
            Console.Write("Conta de Destino:");
            int indiceContaDestino = int.Parse(console.ReadLine());
            
            Console.Write("Valor da Transferencia:");
            double indiceContaOrigem = double.Parse(console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino])
        }

        private static void ObterOpcaoUsuario(){

            Console.WriteLine("Inserir nova Conta ");

            Console.Write("Digite 1 para PF ou 2 para PJ");
            int entradaTipoConta = int.Parse(Console.ReadLine()); //int.Parse converse as informações em numero inteiro

            Console.Write("Digite o Nome: ");
            string entradaNome = Console.ReadLine();
            
            Console.Write("Digite o Saldo: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: "); ///estabeleço um novo objeto
            double entradaCredito = double.Parse(Console.ReadLine());
            Conta novaConta = new Conta(
                tipoConta: (TipoConta)entradaTipoConta, 
                saldo: entradaSaldo, 
                credito: entradaCredito, 
                nome: entradaNome);

            listContas.Add(novaConta);    
        }
        private static void ListarContas(){
            Console.WriteLine("Listando Contas");
            if (listContas.Count == 0){
                Console.WriteLine("Nenhuma Conta cadastrada.");
                return;
            }
            for (int i = 0; i < listContas.Count ; i++){
                Conta conta = listContas[];
                Console.Write('#{0} -', i);
                Console.WriteLine(conta);

            }

        }
        
    
        pivate static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Dio Bank | O Maior Banco de Aprendizado!");
            Console.WriteLine("Informe a Opção desajada: ");

            Console.WriteLine("1 - Listar Contas;");
            Console.WriteLine("2 - Inserir Nova conta;");
            Console.WriteLine("3 - Transferir; ");
             
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            
            Console.WriteLine("X - Sair"));

            string opçãoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opçãoUsuario; 
        }    

    }
}
