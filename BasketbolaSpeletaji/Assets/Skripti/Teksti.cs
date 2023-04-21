using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teksti : MonoBehaviour {
	
	private string iesauka;
	private int vecums;

	public GameObject ievadesLauks1;
	public GameObject ievadesLauks2;

	public GameObject tekstaAttelosana;


	public void UzglabatTekstu(){

		do{
			vecums=int.Parse(ievadesLauks2.GetComponent<Text>().text);
		}while(vecums<18 || vecums>45);
		iesauka = ievadesLauks1.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text>().text = 
			iesauka+" ir "+vecums+" gadus vecs";
	}
}

