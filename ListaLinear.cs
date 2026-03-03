namespace uaitech;

class ListaLinear
{
    private int[] dados;
    private int n;

    public ListaLinear(int MAX = 10)
    {
        dados = new int[MAX];
        n = 0;
    }

    public bool InserirInicio(int v)
    {
        if(n == dados.Length) return false;

        for(int i=n; i>0;i--)
            dados[i] = dados[i-1];
        
        dados[0] = v;
        n++;

        return true;
    }

    public bool InserirFim(int v)
    {
        if(n == dados.Length) return false;
        
        dados[n++] = v;

        return true;
    }

    public bool Inserir(int v, int pos)
    {
        if(n == dados.Length || pos < 0 || pos > n) return false;

        for(int i=n; i>pos;i--)
            dados[i] = dados[i-1];
        
        dados[pos] = v;
        n++;

        return true;        
    }

    public void Imprimir()
    {
        Console.WriteLine($"\n======= Lista - {n}");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(dados[i]);
        }
    }

    public int RemoverInicio()
    {
        if(n == 0) return default(int);
        int res = dados[0];

        n--;
        for(int i=0; i<n;i++)
            dados[i] = dados[i+1];

        return res;
    }

    public int RemoverFim()
    {
        if(n == 0) return -1;
        return dados[--n];
    }

    public int Remover(int pos)
    {
        if(n == 0 || pos < 0 || pos >= n ) return -1;
        int res = dados[pos];

        n--;
        for(int i=pos; i<n;i++)
            dados[i] = dados[i+1];

        return res;
    }

    public int Tamanho()
    {
        return n;
    }

    public bool Vazia()
    {
        return n == 0;
    }

    public bool Cheia()
    {
        return n == dados.Length;
    }

    public void Limpar()
    {
        n=0;
    }

    public int PesquisarIndex(int v)
    {
        for(int i=0; i<n; i++)
            if(dados[i] == v)
                return i;

        return -1;        
    }

    public bool Verifica(int v)
    {
        for(int i=0; i<n; i++)
            if(dados[i] == v)
                return true;

        return false;        
    }

    public ListaLinear PesquisarIndices(int v)
    {
        ListaLinear indices = new ListaLinear(n);
        
        for(int i=0; i<n; i++)
            if(dados[i] == v)
                indices.InserirFim(i);

        return indices;        
    }

    public int Maior()
    {
        int m = int.MinValue;
        for(int i=0; i<n; i++)
            if(dados[i] > m)
                m = dados[i];
        return m;
    }

    public int Menor()
    {
        int m = int.MaxValue;
        for(int i=0; i<n; i++)
            if(dados[i] < m)
                m = dados[i];
        return m;
    }
    
    
}