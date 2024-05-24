import { useEffect } from "react";

function CepConsultar(){

    // () => {} cria uma funçao dentro
    
    //evento de carregamento do componente
    useEffect(() => {
        console.log("O componente carrgou...");

        //FETCH ou AXIOS
        fetch("https://viacep.com.br/ws/01001000/json/").then((resposta) => {
            resposta.json;
        })
        .then((cep) => {
            console.log(cep);
        })

    });
    return(
        <div>
            <h1>Consultar cep</h1>
        </div>
    )
}

export default CepConsultar;