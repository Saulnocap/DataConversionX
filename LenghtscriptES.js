var valor = document.getElementById("valor1");
valor.addEventListener('keyup',convertir);
txtResultado = document.getElementById("resultado1");

unidad1 = document.getElementById("unidad1");
unidad2 = document.getElementById("unidad2");

unidad1.addEventListener('change',convertir);
unidad1.addEventListener('change',convertir);

var resultado;

function convertir() {
	if(valor.value==''){
		return;
	}
	numero = valor.value;
	numero = parseFloat(numero);

{	
{
	if(unidad1.value=="" || unidad2.value==""){
		txtResultado.innerHTML = "Seleccione una unidad de medida para convertir";
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Kilometro"){
		txtResultado.innerHTML = "Seleccione unidades distintas";
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Hectometro"){
		resultado = numero * 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Decametro"){
		resultado = numero * 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Metro"){
		resultado = numero * 1000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Decimetro"){
		resultado = numero * 10000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Centimetro"){
		resultado = numero * 100000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Milimetro"){
		resultado = numero * 1000000;
		txtResultado.innerHTML = resultado;
		console.log(resultado);
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Pulgada"){
		resultado = numero * 39370;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Pie"){
		resultado = numero * 3281;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Kilometro" && unidad2.value=="Yarda"){
		resultado = numero * 1094;
		txtResultado.innerHTML = resultado;
	}
}

{
	if(unidad1.value=="Hectometro" && unidad2.value=="Kilometro"){
		resultado = numero / 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Hectometro" && unidad2.value=="Hectometro"){
		txtResultado.innerHTML = txtResultado.innerHTML = "Seleccione unidades distintas";;
	}
	if(unidad1.value=="Hectometro" && unidad2.value=="Decametro"){
		resultado = numero * 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Hectometro" && unidad2.value=="Metro"){
		resultado = numero * 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Hectometro" && unidad2.value=="Decimetro"){
		resultado = numero * 1000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Hectometro" && unidad2.value=="Centimetro"){
		resultado = numero * 10000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Hectometro" && unidad2.value=="Milimetro"){
		resultado = numero * 100000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Hectometro" && unidad2.value=="Pulgada"){
		resultado = numero * 3937;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Hectometro" && unidad2.value=="Pie"){
		resultado = numero * 328.1;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Hectometro" && unidad2.value=="Yarda"){
		resultado = numero * 109.4;
		txtResultado.innerHTML = resultado;
	}
}

{
	if(unidad1.value=="Decametro" && unidad2.value=="Kilometro"){
		resultado = numero / 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decametro" && unidad2.value=="Hectometro"){
		resultado = numero / 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decametro" && unidad2.value=="Decametro"){
		txtResultado.innerHTML = "Seleccione unidades distintas";
	}
	if(unidad1.value=="Decametro" && unidad2.value=="Metro"){
		resultado = numero * 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decametro" && unidad2.value=="Decimetro"){
		resultado = numero * 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decametro" && unidad2.value=="Centimetro"){
		resultado = numero * 1000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decametro" && unidad2.value=="Milimetro"){
		resultado = numero * 10000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decametro" && unidad2.value=="Pulgada"){
		resultado = numero * 393.7;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decametro" && unidad2.value=="Pie"){
		resultado = numero * 32.808;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decametro" && unidad2.value=="Yarda"){
		resultado = numero * 10.936;
		txtResultado.innerHTML = resultado;
	}
}

{
	if(unidad1.value=="Metro" && unidad2.value=="Kilometro"){
		resultado = numero / 1000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Metro" && unidad2.value=="Hectometro"){
		resultado = numero / 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Metro" && unidad2.value=="Decametro"){
		resultado = numero / 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Metro" && unidad2.value=="Metro"){
		txtResultado.innerHTML = "Seleccione unidades distintas";
	}
	if(unidad1.value=="Metro" && unidad2.value=="Decimetro"){
		resultado = numero * 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Metro" && unidad2.value=="Centimetro"){
		resultado = numero * 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Metro" && unidad2.value=="Milimetro"){
		resultado = numero * 1000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Metro" && unidad2.value=="Pulgada"){
		resultado = numero * 39.37;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Metro" && unidad2.value=="Pie"){
		resultado = numero * 3.281;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Metro" && unidad2.value=="Yarda"){
		resultado = numero * 1.094;
		txtResultado.innerHTML = resultado;
	}
}

{
	if(unidad1.value=="Decimetro" && unidad2.value=="Kilometro"){
		resultado = numero / 10000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decimetro" && unidad2.value=="Hectometro"){
		resultado = numero / 1000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decimetro" && unidad2.value=="Decametro"){
		resultado = numero / 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decimetro" && unidad2.value=="Metro"){
		resultado = numero / 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decimetro" && unidad2.value=="Decimetro"){
		txtResultado.innerHTML = "Seleccione unidades distintas";
	}
	if(unidad1.value=="Decimetro" && unidad2.value=="Centimetro"){
		resultado = numero * 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decimetro" && unidad2.value=="Milimetro"){
		resultado = numero * 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decimetro" && unidad2.value=="Pulgada"){
		resultado = numero * 3.937;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decimetro" && unidad2.value=="Pie"){
		resultado = numero / 3.048;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Decimetro" && unidad2.value=="Yarda"){
		resultado = numero / 9.144;
		txtResultado.innerHTML = resultado;
	}
}

{
	if(unidad1.value=="Centimetro" && unidad2.value=="Kilometro"){
		resultado = numero / 100000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Centimetro" && unidad2.value=="Hectometro"){
		resultado = numero / 10000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Centimetro" && unidad2.value=="Decametro"){
		resultado = numero / 1000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Centimetro" && unidad2.value=="Metro"){
		resultado = numero / 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Centimetro" && unidad2.value=="Decimetro"){
		resultado = numero / 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Centimetro" && unidad2.value=="Centimetro"){
		txtResultado.innerHTML = "Seleccione unidades distintas";
	}
	if(unidad1.value=="Centimetro" && unidad2.value=="Milimetro"){
		resultado = numero * 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Centimetro" && unidad2.value=="Pulgada"){
		resultado = numero / 2.54;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Centimetro" && unidad2.value=="Pie"){
		resultado = numero / 30.48;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Centimetro" && unidad2.value=="Yarda"){
		resultado = numero / 91.44;
		txtResultado.innerHTML = resultado;
	}
}

{
	if(unidad1.value=="Milimetro" && unidad2.value=="Kilometro"){
		resultado = numero / 1000000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Milimetro" && unidad2.value=="Hectometro"){
		resultado = numero / 100000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Milimetro" && unidad2.value=="Decametro"){
		resultado = numero / 10000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Milimetro" && unidad2.value=="Metro"){
		resultado = numero / 1000;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Milimetro" && unidad2.value=="Decimetro"){
		resultado = numero / 100;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Milimetro" && unidad2.value=="Centimetro"){
		resultado = numero / 10;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Milimetro" && unidad2.value=="Milimetro"){
		txtResultado.innerHTML = "Seleccione unidades distintas";
	}
	if(unidad1.value=="Milimetro" && unidad2.value=="Pulgada"){
		resultado = numero / 25.4;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Milimetro" && unidad2.value=="Pie"){
		resultado = numero / 304.8;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Milimetro" && unidad2.value=="Yarda"){
		resultado = numero / 914.4;
		txtResultado.innerHTML = resultado;
	}
}

{
	if(unidad1.value=="Pulgada" && unidad2.value=="Kilometro"){
		resultado = numero / 39370;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pulgada" && unidad2.value=="Hectometro"){
		resultado = numero / 3937.008;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pulgada" && unidad2.value=="Decametro"){
		resultado = numero / 393.700;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pulgada" && unidad2.value=="Metro"){
		resultado = numero / 39.37;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pulgada" && unidad2.value=="Decimetro"){
		resultado = numero / 3.937;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pulgada" && unidad2.value=="Centimetro"){
		resultado = numero * 2.54;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pulgada" && unidad2.value=="Milimetro"){
		resultado = numero * 25.4;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pulgada" && unidad2.value=="Pulgada"){
		txtResultado.innerHTML = "Seleccione unidades distintas";
	}
	if(unidad1.value=="Pulgada" && unidad2.value=="Pie"){
		resultado = numero / 12;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pulgada" && unidad2.value=="Yarda"){
		resultado = numero / 36;
		txtResultado.innerHTML = resultado;
	}
}

{
	if(unidad1.value=="Pie" && unidad2.value=="Kilometro"){
		resultado = numero / 3281;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pie" && unidad2.value=="Hectometro"){
		resultado = numero / 328.1;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pie" && unidad2.value=="Decametro"){
		resultado = numero / 32.808;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pie" && unidad2.value=="Metro"){
		resultado = numero / 3.281;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pie" && unidad2.value=="Decimetro"){
		resultado = numero * 3.048;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pie" && unidad2.value=="Centimetro"){
		resultado = numero * 30.48;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pie" && unidad2.value=="Milimetro"){
		resultado = numero * 304.8;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pie" && unidad2.value=="Pulgada"){
		resultado = numero * 12;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Pie" && unidad2.value=="Pie"){
		txtResultado.innerHTML = "Seleccione unidades distintas";
	}
	if(unidad1.value=="Pie" && unidad2.value=="Yarda"){
		resultado = numero / 3;
		txtResultado.innerHTML = resultado;
	}
}

{
	if(unidad1.value=="Yarda" && unidad2.value=="Kilometro"){
		resultado = numero / 1094;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Yarda" && unidad2.value=="Hectometro"){
		resultado = numero / 109.4;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Yarda" && unidad2.value=="Decametro"){
		resultado = numero / 10.936;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Yarda" && unidad2.value=="Metro"){
		resultado = numero / 1.094;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Yarda" && unidad2.value=="Decimetro"){
		resultado = numero / 0.109;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Yarda" && unidad2.value=="Centimetro"){
		resultado = numero * 91.44;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Yarda" && unidad2.value=="Milimetro"){
		resultado = numero * 914.4;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Yarda" && unidad2.value=="Pulgada"){
		resultado = numero * 36;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Yarda" && unidad2.value=="Pie"){
		resultado = numero * 3;
		txtResultado.innerHTML = resultado;
	}
	if(unidad1.value=="Yarda" && unidad2.value=="Yarda"){
		txtResultado.innerHTML = "Seleccione unidades distintas";
	}
}
}

}