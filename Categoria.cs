namespace uaitech;

class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public void Imprimir()
    {
        Console.WriteLine($"{Id} - {Nome}");
    }
}

class Categorias
{
    private Categoria[] lista;
    private int n;
    private int MAX;

    public Categorias(int max)
    {
        MAX = max;
        lista = new Categoria[max];
        n=0;
    }

    public void Adicionar()
    {
        if(n == MAX)
        {
            Console.WriteLine("Lista cheia! :( )");            
        }else{
            Categoria categoria = new Categoria();
            Console.Write("Digite o Id:");
            categoria.Id = int.Parse(Console.ReadLine());

            Categoria cat1 = PesquisaPorId(categoria.Id);

            if (cat1 != null)
            {
                Console.WriteLine("Id já cadastrado!");
                cat1.Imprimir();
                return;
            }

            Console.Write("Digite o Nome:");
            categoria.Nome = Console.ReadLine();

            lista[n] = categoria;
            n++;
        }

    }

    public void Imprimir()
    {
        Console.WriteLine($"Categorias: {n}");
        for(int i=0; i < n; i++)
            lista[i].Imprimir();
    }

    public void Editar()
    {
        Console.Write("Digite o Id:");
        int id = int.Parse(Console.ReadLine());

        Categoria cat1 = PesquisaPorId(id);

        if (cat1 != null)
        {
            Console.Write("Digite o Nome:");
            cat1.Nome = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Id não encontrado!");
        }        
    }

    public void Excluir()
    {
        Console.Write("Digite o Id:");
        int id = int.Parse(Console.ReadLine());

        int index = PesquisarIndexPorId(id);

        if (index != -1)
        {
            n--;
            for(int i=index; i<n;i++)
                lista[i] = lista[i+1];
        }
        else
        {
            Console.WriteLine("Id não encontrado!");
        }        
    }
    
    public void Pesquisar()
    {
        Console.Write("Digite o Id:");
        int id = int.Parse(Console.ReadLine());

        Categoria cat1 = PesquisaPorId(id);

        if (cat1 != null)
        {
            cat1.Imprimir();
        }
        else
        {
            Console.WriteLine("Id não encontrado!");
        }        
    }

    public Categoria PesquisaPorId(int id)
    {
        for(int i=0; i < n; i++)
        {
            if(lista[i].Id == id)
                return lista[i];
        }
        return null;
    }

    public int PesquisarIndexPorId(int id)
    {
        for(int i=0; i < n; i++)
        {
            if(lista[i].Id == id)
                return i;
        }
        return -1;
    }
}
