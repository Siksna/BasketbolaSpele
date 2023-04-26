using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {

	public GameObject Krekli;
	public GameObject Shorti;
	public GameObject Kurpes;
	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;
	public GameObject IzmeraSlaideris;




	public void Izkritosais(int indekss)
	{
		if(indekss == 0)
			mainigaisAttels.GetComponent<Image>().sprite 
			= atteluMasivs[0];

		else if (indekss == 1)
			mainigaisAttels.GetComponent<Image>().sprite
			= atteluMasivs[1];

		else if (indekss == 2)
			mainigaisAttels.GetComponent<Image>().sprite
			= atteluMasivs[2];
	}

	/*public void mainitAugstumu()
	{
		float pasreizejaisIzmers =
			IzmeraSlaideris.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale =
			new Vector2(1f* pasreizejaisIzmers,
				1f*pasreizejaisIzmers);
	}

	public void mainitPlatumu()
	{
		float pasreizejaisIzmers =
			IzmeraSlaideris.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale =
			new Vector2(1f* pasreizejaisIzmers,
				1f*pasreizejaisIzmers);
	}*/


	public void KreklaAtteli(bool vertiba)
	{
		Krekli.SetActive(vertiba);
	}

	public void ShortuAtteli(bool vertiba)
	{
		Shorti.SetActive(vertiba);
	}

	public void KurpjuAtteli(bool vertiba)
	{
		Kurpes.SetActive(vertiba);
	}
}
