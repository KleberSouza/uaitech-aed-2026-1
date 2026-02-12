namespace uaitech;

class Program
{

    static int Menu()
    {
        Console.WriteLine("===> UAI TECH <===");
        Console.WriteLine("1 - Adicionar Categoria");
        Console.WriteLine("2 - Listar Categorias");
        Console.WriteLine("0 - Sair");
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
            }
        Console.ReadKey();
            
        }while(opcao != 0);
    }
}
