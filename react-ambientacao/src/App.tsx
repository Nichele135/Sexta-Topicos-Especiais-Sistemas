import React from 'react';
import Caixa from './Soma';
import Soma from './Soma';

//1- O nome do componente OBRIGATORIAMENTE deve comecar com a primeira letra em maiusculo
//2- O componente DEVE ser uma funçao do JS ou TS
//3- O componente DEVE retornar APENAS UM elemento pai hmtl

function App() {
  return (
    <div>
      <Soma></Soma>
    </div>
  );
}

//4- O componente DEVE ser exportadado
export default App;
