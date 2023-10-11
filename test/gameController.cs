using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameController : MonoBehaviour
{
	// Start is called before the first frame update
	public	int contador;
	public	string vid = "Vidas ";
	public Button btn_block;
	public TextMeshProUGUI textElement;
	public TextMeshProUGUI contElement1;
	public TextMeshProUGUI contElement2;
	public int next;
	void Start()
	{
		contador = 0;
		next = 1;
		textElement.text = vid + contador.ToString();
	}
	public void Btn_sum() 
	{
		contador += next;
		textElement.text = vid + contador.ToString();
		Debug.Log(contador);
	}
	public void Btn_men()
	{
		contador -= next;
		textElement.text = vid + contador.ToString();
		Debug.Log(contador);
	}
	public void mejora() 
	{
		if (contador >= 25)
		{
			contador -= 25;
			next += next;
			contElement1.text = "+" + next.ToString();
			contElement2.text = "-" + next.ToString();
			textElement.text = vid + contador.ToString();
			btn_block.gameObject.SetActive(false);
		}

	}
	// Update is called once per frame
	void Update()
	{
		/*
		if (contador >= 25)
			btn_block.gameObject.SetActive(true);
		*/
	}
}
