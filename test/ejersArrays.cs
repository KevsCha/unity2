using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ejersArrays : MonoBehaviour
{
	//Ejercicio 1
	public TextMeshProUGUI val1;
	public float[] puntuacionesMaximas;
	//Ejercicio 2
	//Ejercicio 3
	public float[] puntuacionesMaximas2;
	//Ejercicio 4
	public float[] puntuacionesMaximas3;
	//Ejercicio 5
	public decimal[] arrayDecimales;
	public string[] arrayCadenaCaracteres;
	public bool[] arrayBooleanos;
	public int[] arrayEnteros1;
	public int[] arrayEnteros2;
	//Ejercicio 6
	public decimal[] arrayDecimalesV2 = {1m, 2.3m, 3.4m, 5.3m, 4.6m };
	public string[] arrayCadenaCaracteresV2 = {"1", "2", "3", "4", "5" };
	public bool[] arrayBooleanosV2 = { true, false, true, false, true };
	public int[] arrayEnteros1V2 = { 5, 2, 3, 4, 5};
	public int[] arrayEnteros2V2 = { 6, 7, 8, 9, 10};
	//Ejercicio 7
	//Ejercicio 8
	//Ejercicio 9
	//Ejercicio 10
	//Ejercicio 11
	//Ejercicio 12
	//Ejercicio 13
	public int[] arr= { 1, 1, 1, 1 };
	//Ejercicio 14
	public int[] arr2 = { 1, 1, 1, 1 };

	// Start is called before the first frame update
	void Start()
	{
		//Ejercicio 1
		val1.text = puntuacionesMaximas[0].ToString();
			// darle el valor dentro del editor y edita un gameObject de tipo text(TMP)
		//Ejercicio 2
		/* El programa los identifica como 0 y 11*/
		//Ejercicio 3
		puntuacionesMaximas2 = new float[12];
		//Ejercicio 4
		puntuacionesMaximas3 = new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10 ,11};
		//Ejercicio 5
		//Ejercicio 6
		//Ejercicio 7
		string[] str = arrayCadenaCaracteresV2; 
		Debug.Log(str[0] + str[1] + str[2] + str[3] + str[4]);
			/* coloque el array de cadena en una variable que tenga nombre mas corto */
		//Ejercicio 8
		decimal[] arrD = arrayDecimalesV2; 
		decimal result= arrD[0] + arrD[1] + arrD[2] + arrD[3] + arrD[4];
		Debug.Log(result);
		//Ejercicio 9
		str[0] = "Claudio";
		str[1] = "Maria";
		//Ejercicio 10
		/*
		int i;

		i = 0;
		while (i < arrayEnteros1V2.Length && i < arrayEnteros2V2.Length) 
		{
			arrayEnteros1V2[i] = arrayEnteros2V2[i];
			Debug.Log(arrayEnteros1V2[i]);
			i++;
		}
		*/
		//Ejercicio 11
		arrayEnteros1V2[1] = arrayEnteros2V2.Length;
		//Ejercicio 12
		int medA;
		int sum = 0;
		int j = 0;

		while (j < arrayEnteros1V2.Length) 
		{
			sum += arrayEnteros1V2[j];
			j++;
		}
		medA = sum / arrayEnteros1V2.Length;
		Debug.Log("Media artimetica: " + medA);
	}

	// Update is called once per frame
	void Update()
	{
		//Ejercicio 13		
		arr[0] ++;
		arr[1] += 2;
		arr[2] += 3;
		arr[3] += 4;
		//Ejercicio 14
		
		arr2[0] += 2;
		arr2[1] *= 2;
		arr2[2] *= 3;
		arr2[3] += arr2[0];

	}
}
