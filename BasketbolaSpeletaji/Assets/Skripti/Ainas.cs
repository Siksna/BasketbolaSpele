using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ainas : MonoBehaviour {

	// Use this for initialization
	public void UzSakumu(){
		SceneManager.LoadScene ("Ievads", LoadSceneMode.Single);
	}

	public void UzSpeli(){
		SceneManager.LoadScene (1, LoadSceneMode.Single);
	}

}
