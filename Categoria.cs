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
    public List<Categoria> lista;

    public Categorias()
    {
        lista = new List<Categoria>();
    }

    public void Adicionar()
    {
 
            Categoria categoria = new Categoria();
            Console.Write("Digite o Id:");
            categoria.Id = int.Parse(Console.ReadLine());

            if (lista.Any(x => x.Id == categoria.Id))
            {
                Console.WriteLine("Id já cadastrado!");
                return;
            }

            Console.Write("Digite o Nome:");
            categoria.Nome = Console.ReadLine();

            lista.Add(categoria);
    }

    public void Imprimir()
    {
        Console.WriteLine($"Categorias: {lista.Count}");
        //for(int i=0; i < lista.Count; i++)
        //    lista[i].Imprimir();

        foreach(var c in lista)
            c.Imprimir();
    }

    public void Editar()
    {
        Console.Write("Digite o Id:");
        int id = int.Parse(Console.ReadLine());

        Categoria cat1 = lista.Find(x => x.Id == id);

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

        int index = lista.FindIndex(x => x.Id == id);

        if (index != -1)
        {
            lista.RemoveAt(index);
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

        Categoria cat1 = lista.Find(x => x.Id == id);
        
        if (cat1 != null)
        {
            cat1.Imprimir();
        }
        else
        {
            Console.WriteLine("Id não encontrado!");
        }        
    }

   

  
}
