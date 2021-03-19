using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
          string OpcaoUsuario = ObterOpcaoUsuario();
		
		while (OpcaoUsuario.ToUpper() != "X")
		{
		switch (OpcaoUsuario)
			{
		case "1":
		ListarContas();
		break;
		case "2":
		InserirConta();
		break;
		case "3":
		Transferir();
		break;
		case "4":
		Sacar();
		break;
		case "5":
		Depositar();
		break;
		case "C":
		Console.Clear();
		break;
		
		default:
		throw new ArgumentOutOfRangeException();
        }
        
        private static string ObterOpcaoUsuario()
{
	Console.WriteLine();
	Console.WriteLine("DIO bank ao seu dispor!");
	Console.WriteLine("Informe a opção Desejada:");
	Console.WriteLine("1- Listar Contas");
	Console.WriteLine("2- Inserir nova conta");
	Console.WriteLine("3- Transferir");
	Console.WriteLine("4- Sacar");
	Console.WriteLine("5- Depositar");
	Console.WriteLine("C- Limpar Tela");
	Console.WriteLine("X- Sair");

	string OpcaoUsuario = Console.ReadLine().ToUpper();
	Console.WriteLine();
	return OpcaoUsuario;
		}
    }
}
