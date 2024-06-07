import { useEffect, useState } from "react";
import { Produto } from "../../../models/produto";
//EXERCÍCIOS
//1 - Consutar os produtos da API(CORS)
//2 - Exibir no HTML uma lista de produtos

function ProdutoListar(){

    const[produtos, setProdutos] = useState<Produto[]>([]);

    useEffect(() => {

        carregarProdutos();

    }, []);

    function carregarProdutos(){
        //FETCH ou AXIOS
        fetch("http://localhost:5134/api/produto/listar")
        .then((resposta) => 

            resposta.json()

        ).then((produtos : Produto[]) => {
            console.table(produtos);
            setProdutos(produtos);
        });
    }

    function cadastarProdutos(){
const produto: Produto = {
        nome: "Feijao",
		descricao: "PRETO",
		valor: 10,
		quantidade: 5
}

        //FETCH ou AXIOS
        fetch("http://localhost:5134/api/produto/cadastrar", 
        {
            method: "POST",
            headers: ("Content-type": "application/json"), body: JSON.stringify(produto);
        })
        .then((resposta) => 

            resposta.json()

        ).then((produto : Produto[]) => {
            console.table(produto);
        });
    }

    return(
        <div>

            <h1>Listar Produtos</h1>
            <table border={1}>
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Nome:</th>
                        <th>Descricao:</th>
                        <th>Quantidade:</th>
                        <th>Valor:</th>
                        <th>Criado em:</th>
                    </tr>
                </thead>
                <tbody>
                    {produtos.map(produto =>(
                        <tr key={produto.id}>
                            <td>{produto.id}</td>
                            <td>{produto.nome}</td>
                            <td>{produto.descricao}</td>
                            <td>{produto.quantidade}</td>
                            <td>{produto.valor}</td>
                            <td>{produto.criadoEm}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}

export default ProdutoListar;