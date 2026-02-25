namespace uaitech;

class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Valor { get; set; }
    public int Qtd { get; set; }
    public Categoria Categoria { get; set; }

    public void Imprimir()
    {
        Console.WriteLine($"{Id} - {Nome}- {Valor}- {Qtd}- {Categoria?.Nome}");
    }
}

class Produtos
{
    private List<Produto> lista;
    private List<Categoria> categorias;

    public Produtos(List<Categoria> cats)
    {
        lista = new List<Produto>();
        categorias = cats;
    }

    public void Adicionar()
    {
 
            Produto produto = new Produto();
            Console.Write("Digite o Id:");
            produto.Id = int.Parse(Console.ReadLine());

            if (lista.Any(x => x.Id == produto.Id))
            {
                Console.WriteLine("Id já cadastrado!");
                return;
            }

            Console.Write("Digite o Nome:");
            produto.Nome = Console.ReadLine();

            Console.Write("Digite o Valor:");
            produto.Valor = double.Parse(Console.ReadLine());

            Console.Write("Digite a Quantidade:");
            produto.Qtd = int.Parse(Console.ReadLine());

            Console.Write("Digite o id da Categoria:");
            int categoriaId = int.Parse(Console.ReadLine());

            produto.Categoria = categorias.Find(x => x.Id == categoriaId);

            lista.Add(produto);
    }

    public void Imprimir()
    {
        Console.WriteLine($"Produtos: {lista.Count}");
        //for(int i=0; i < lista.Count; i++)
        //    lista[i].Imprimir();

        foreach(var c in lista)
            c.Imprimir();
    }

    public void Editar()
    {
        Console.Write("Digite o Id:");
        int id = int.Parse(Console.ReadLine());

        Produto produto = lista.Find(x => x.Id == id);

        if (produto != null)
        {
            Console.Write("Digite o Nome:");
            produto.Nome = Console.ReadLine();

            Console.Write("Digite o Valor:");
            produto.Valor = double.Parse(Console.ReadLine());

            Console.Write("Digite a Quantidade:");
            produto.Qtd = int.Parse(Console.ReadLine());

            Console.Write("Digite o id da Categoria:");
            int categoriaId = int.Parse(Console.ReadLine());

            produto.Categoria = categorias.Find(x => x.Id == categoriaId);
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

        Produto produto = lista.Find(x => x.Id == id);
        
        if (produto != null)
        {
            produto.Imprimir();
        }
        else
        {
            Console.WriteLine("Id não encontrado!");
        }        
    }

   

  
}
