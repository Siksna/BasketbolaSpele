using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teksti : MonoBehaviour {
	
	private string iesauka;
	private int vecums;

	public GameObject IesaukasIevade;
	public GameObject VecumaIevade;

	public GameObject tekstaAttelosana;


	public void UzglabatTekstu(){

			vecums = int.Parse (VecumaIevade.GetComponent<Text> ().text);
		
		iesauka = IesaukasIevade.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text>().text = 
			iesauka+" ir "+vecums+" gadus vecs";
	}

}

