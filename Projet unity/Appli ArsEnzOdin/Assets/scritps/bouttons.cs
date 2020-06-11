using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bouttons : MonoBehaviour {

	public int tailleTexte = 0;
	public Text texte;

	void Start () {
		
	}

	void Update () {
		texte.text = ("taille: " + tailleTexte);
	}
	public void BOUTTONTEXTE(){
		tailleTexte += 1;
	}
}