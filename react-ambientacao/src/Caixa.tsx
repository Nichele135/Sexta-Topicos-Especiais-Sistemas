import { useState } from "react";



function Caixa() {

    const [contador, setContador] = useState(0);

    function clicar(){
        setContador(contador + 1);
        console.log(contador);
        alert ("Cliquei no botao");
    }
    return (
      <div>
        <h1>Componente da soma:</h1>
        <label>Numero 1:</label>
        <input type="text"/><br />
        <label>Numero 2:</label>
        <input type="text"/><br />
        <button onClick={clicar} >Calcular</button>
      </div>
    );
  }

  export default Caixa;