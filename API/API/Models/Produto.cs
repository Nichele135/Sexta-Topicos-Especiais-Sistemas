namespace API.Models;

// esse record foi para gravar os nomes e descriçao dos celulares no program.cs;
//record Produto(string Nome, string Descricao);

public class Produto
{
    //Contrutores
    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }
    
    public Produto(string nome, string descricao, double valor)
    {
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    
    
    // //Atributos == caracteristicas, propriedades
    
    public string Id {get;set;}
    public string Nome {get;set;} // ---> Esse comando é oq faz o get e set em C#
    public string Descricao {get;set;}
    public double Valor {get;set;}
    public DateTime CriadoEm {get;set;}

    
    
    // private String nome;


    // public void setNome(String nome)
    // {
    //     this.nome = nome;
    // }

    // public String getNome()
    // {
    //     return this.nome;
    // }

    //tudo isso acima e usado em JAVA.

    

    

}

