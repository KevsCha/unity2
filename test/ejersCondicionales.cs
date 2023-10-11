using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejersCondicionales : MonoBehaviour
{
	//Ejercicio 1
	public  string playerName;
	//Ejercicio 2
	public  string player2;
	public  int age2;
	//Ejercicio 3
	public string player3;
	public int age3;
	//Ejercicio 4
	public string player4;
	public int age4;
	//Ejercicio 5
	public string ciudad;
	public float precio;
	//Ejercicio 6
	public string ciudad2;
	public float precio2;
	//Ejercicio 7
	public string ciudad3;
	public float precio3;
	//Ejercicio 8
	public int contador1;
	//Ejercicio 9
	public int contador2;
	// Start is called before the first frame update
	void Start()
	{
		//Ejercicio 1
		if (playerName == "Kevin")
			Debug.Log("Ejercicio 1 Correcto");
		//Ejercicio 2
		if (player2 == "Kevs" && age2 == 22)
			Debug.Log("Ejercicio 2 Correcto");
		else
			Debug.Log("Ejercicio 2 Incorrecto");
		//Ejercicio 3
		if (player3 == "Canela" || age3 == 22)
			Debug.Log("Ejercicio 3 Correcto");
		else
			Debug.Log("Ejercicio 3 Incorrecto");
		//Ejercicio 4
		if (player4 == "Kevs")
			if (age4 == 22)
				Debug.Log("Ejercicio 4 Correcto");
		else
			Debug.Log("Ejercicio 4 Incorrecto");
		//Ejercicio 5
		if ((ciudad == "Madrid" || ciudad == "Barcelona" || ciudad == "Sevilla" || ciudad == "Bilbao") && (precio < 200.000))
			Debug.Log("Valido de la compra");
		//Ejercicio 6
		if ((ciudad2 == "Madrid" || ciudad2 == "Barcelona" || ciudad2 == "Sevilla" || ciudad2 == "Bilbao") && (precio2 > 150000 && precio2 < 200000))
			Debug.Log("Valido de la compra");
		else
			Debug.Log("Vivienda no coincide con requisitos");
		//Ejercicio 7
		if ((ciudad3 == "Madrid" || ciudad3 == "Barcelona" || ciudad3 == "Sevilla" || ciudad3 == "Bilbao") && (precio3 > 150000 && precio3 < 200000))
			Debug.Log("Valido de la compra");
		else if (((precio3 >= 100000 && precio3 <= 150000) || precio3 >= 200000 && precio3 <= 250000) && (ciudad2 == "Madrid" || ciudad2 == "Barcelona" || ciudad2 == "Sevilla" || ciudad2 == "Bilbao"))
			Debug.Log("Vivienda paraestudiar viabilidad de compra");
		else
			Debug.Log("Valido de la compra");
	}

	// Update is called once per frame
	void Update()
	{
		//Ejercicio 8
		/*
		contador1++;
		if (contador1 == 50 || contador1 == 500 || contador1 == 5000)
			Debug.Log(contador1);
		*/
		//Ejercicio 9
		/*
		contador2++;
		if (contador2 % 250 == 0)
			Debug.Log("El numero ValorDeContador, es multiplo de 250:  " + contador2);
		*/
	}
}
