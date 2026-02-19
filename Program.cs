namespace uaitech;

class Program
{

    static int Menu()
    {
        Console.WriteLine("===> UAI TECH <===");
        Console.WriteLine("1 - Adicionar Categoria");
        Console.WriteLine("2 - Listar Categorias");
        Console.WriteLine("3 - Editar Categoria");
        Console.WriteLine("4 - Apagar Categoria");
        Console.WriteLine("5 - Pesquisar Categoria");
        Console.WriteLine("0 - Sair");
        Console.Write("Digite a opção desejada: ");
        int op = int.Parse(Console.ReadLine());
        return op;
    }


    static void Main(string[] args)
    {
        int opcao = 0;
        Categorias categorias = new Categorias(5);

        do
        {
            Console.Clear();
            opcao = Menu();

            switch (opcao)
            {
                case 1: categorias.Adicionar();
                break;
                case 2: categorias.Imprimir();
                break;
                case 3: categorias.Editar();
                break;
                case 4: categorias.Excluir();
                break;
                case 5: categorias.Pesquisar();
                break;
            }

        Console.WriteLine("\nDigite qualquer tecla para continuar...");
        Console.ReadKey();
            
        }while(opcao != 0);
    }
}
