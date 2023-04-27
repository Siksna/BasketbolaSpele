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
	public GameObject mainigaisAttelsKrekliem;
	public GameObject mainigaisAttelsShortiem;
	public GameObject mainigaisAttelsKurpem;
	public Sprite[] atteluMasivs;
	public Sprite[] atteluMasivsKrekliem;
	public Sprite[] atteluMasivsShortiem;
	public Sprite[] atteluMasivsKurpem;
	public GameObject IzmeraSlaiderisY;
    public GameObject IzmeraSlaiderisX;




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
	public void IzkritosaisKrekliem(int indekss)
	{
		if(indekss == 0)
			mainigaisAttelsKrekliem.GetComponent<Image>().sprite 
			= atteluMasivsKrekliem[0];

		else if (indekss == 1)
			mainigaisAttelsKrekliem.GetComponent<Image>().sprite
			= atteluMasivsKrekliem[1];

		else if (indekss == 2)
			mainigaisAttelsKrekliem.GetComponent<Image>().sprite
			= atteluMasivsKrekliem[2];
	}
	public void IzkritosaisShortiem(int indekss)
	{
		if(indekss == 0)
			mainigaisAttelsShortiem.GetComponent<Image>().sprite 
			= atteluMasivsShortiem[0];

		else if (indekss == 1)
			mainigaisAttelsShortiem.GetComponent<Image>().sprite
			= atteluMasivsShortiem[1];

		else if (indekss == 2)
			mainigaisAttelsShortiem.GetComponent<Image>().sprite
			= atteluMasivsShortiem[2];
	}
	public void IzkritosaisKurpem(int indekss)
	{
		if(indekss == 0)
			mainigaisAttelsKurpem.GetComponent<Image>().sprite 
			= atteluMasivsKurpem[0];

		else if (indekss == 1)
			mainigaisAttelsKurpem.GetComponent<Image>().sprite
			= atteluMasivsKurpem[1];

		else if (indekss == 2)
			mainigaisAttelsKurpem.GetComponent<Image>().sprite
			= atteluMasivsKurpem[2];
	}

	public void mainitAugstumu()
	{
		float pasreizejaisIzmers =
			IzmeraSlaiderisY.GetComponent<Slider>().value;
		Krekli.transform.localScale =
			new Vector2(1f* pasreizejaisIzmers,
				1f*pasreizejaisIzmers);
	}

	public void mainitPlatumu()
	{
		float pasreizejaisIzmers =
			IzmeraSlaiderisX.GetComponent<Slider>().value;
		Krekli.transform.localScale =
			new Vector2(1f*pasreizejaisIzmers,
				1f*pasreizejaisIzmers);
	}


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
