using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerConditionals : MonoBehaviour
{
	//Ejercicio 2
	public string nomb = "Kevs";
	//Ejercicio 3
	public string nomb2;
	//Ejercicio 4
	public string nomb3;
	//Ejercicio 5
	public string nomb4;
	//Ejercicio 6
	public string str;
	public int numInt;
	public float numDe;
	public bool bol;
	//Ejercicio 7
	public int a = 5;
	public int b = 5;
	public int result;
	//Ejercicio 8
	public int av2;
	public int bv2;
	public int resultv2;
	//Ejercicio 9
	public decimal valor1;
	public decimal valor2;
	public decimal valor3;
	public decimal sumaTotal;
	//Ejercicio 10
	public int contador;
	//Ejercicio 11
	public int contadorv2 = 1000;
	//Ejercicio 12
	public decimal n1 = 3.5m;
	public decimal n2 = 2.5m;
	public decimal n3 = 2.5m;
	public decimal n4 = 0.5m;
	public decimal n5 = 1.9m;
	public decimal mediaAritmetica;
	// Start is called before the first frame update
	void Start()
	{
		//Ejercicio 1
		Debug.Log("Hello world");
		//Eercicio 2
		Debug.Log("Hola " + nomb);
		//Ejercicio 3
		nomb2 = "David";
		Debug.Log("Hola" + nomb2);
		//Ejercicio 4
		Debug.Log(nomb3);
		//Ejercicio 5
		nomb4 = "josue";
		Debug.Log(nomb4);
		/*
			El comportamiento que hace es la de tomar el valor iniciado en la funcion start e ignora el valor que se le da por el editor de unity
		*/
		//Ejercicio 6
		Debug.Log(str + "\n" + numInt + "\n" + numDe + "\n" + bol);
		//ejercicio 7
		result = a + b;
		Debug.Log(result);
		//ejercicio 8
		resultv2 = av2 + bv2;
		Debug.Log(resultv2);
		//Ejercicio 9
		valor1 = 2.5m;
		valor2 = 3.5m;
		valor3 = 4.5m;
		sumaTotal = valor1 + valor2 + valor3;
		Debug.Log(valor1 + "\n" + (sumaTotal - valor3) + "\n" + sumaTotal);
		//Ejercicio 12
		mediaAritmetica = (n1 + n2 + n3 + n4 + n5) / 5;
		Debug.Log("La media Aritmetica es: " + mediaAritmetica);

	}

	// Update is called once per frame
	void Update()
	{
		//Ejercicio 10
		/*
			contador++;
			Debug.Log(contador);
		*/
		//Ejercicio 11
		/*
			contadorv2 -= 2;
			Debug.Log(contadorv2);
		*/

		
	}
}
