using API.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Produto produto = new Produto();
//produto.setNome("Andre"); --> Esee comando e em java
produto.Nome = "Andre";  // --> Esee comando e em C#

//Console.WriteLine(produto.getNome());    --> Esee comando e em java
Console.WriteLine(produto.Nome); // --> Esee comando e em C#

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto("Celular", "IOS", 4000));
produtos.Add(new Produto("Celular", "Android", 2500));
produtos.Add(new Produto("Televisão", "LG", 2000));
produtos.Add(new Produto("Notebook", "Avell", 5000));

app.MapGet("/", () => "Minha primeira API C#");

//caminho para acessar é local host do power shell mais o get abaixo;
//http://localhost:5018/api/produto/listar
app.MapGet("/api/produto/listar", () => produtos);

//http://localhost:5018/api/produto/buscar/id_do_produto
app.MapGet("/api/produto/buscar/{id}", (string id) =>
{
    foreach (Produto produtoCadastrado in produtos)
    {
        if(produtoCadastrado.Id == id)
        {
            //Retornar produto encontrado / codigo de bem sucedido é 200.
            return Results.Ok(produtoCadastrado);
        }
    }

    // Produto nao encontrado.
    return Results.NotFound("Produto não encontrado");
});


app.MapPost("/api/produto/cadastrar/", (Produto produto) => 
{

    produtos.Add(produto);

    return Results.Created("", produto);
});

app.MapDelete("/api/produto/delete/{id}", (String id) => 
{   
        foreach (Produto produtoCadastrado in produtos)
    {
        if(produtoCadastrado.Id == id)
        {
            produtos.Remove(produtoCadastrado);
            //Retornar produto encontrado / codigo de bem sucedido é 200.
            return Results.Ok(produtoCadastrado);
        }
    }

    // Produto nao encontrado.
    return Results.NotFound("Produto não encontrado");
}
);

app.MapPut("/api/produto/alterar/{id}", (string id, Produto produto, string nome, double valor) =>
{
            foreach (Produto produtoCadastrado in produtos)
    {
        if(produtoCadastrado.Id == id)
        {
            produtos.(produtoCadastrado);
            //Retornar produto encontrado / codigo de bem sucedido é 200.
            return Results.Ok(produtoCadastrado);
        }
    }
})



app.Run();
