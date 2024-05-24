import { useState } from "react";

function Soma() {

    const [contador, setContador] = useState(0);
    const [num1, setNum1] = useState("");
    const [num2, setNum2] = useState("");
    const [resultado, setResultado] = useState(0);

    function incrementarContador(){
        setContador(contador + 1);
        console.log(contador);
    }
    
    function somar(){
      setResultado(parseInt(num1) + parseInt(num2));

    }
    function digitarNum1(e: any){
      // console.log(e.target.value);
      setNum1(e.target.value);
    }
    function digitarnum2(){

    }
    return (
      <div id = "soma">
        <h1>Componente da soma:</h1>
        <label>Numero 1:</label>
        <input type="text" onChange={digitarNum1}/><br />
        <label>Numero 2:</label>
        <input type="text"onChange= {(e: any) => {setNum2(e.target.value)} }/><br />
        <button onClick={incrementarContador} >Contador</button>

        <button onClick={somar} >Calcular</button>

        <p>
          { contador }
        </p>
        <p>
          { resultado }
        </p>
      </div>
    );
  }

  export default Soma;