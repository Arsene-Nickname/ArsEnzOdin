using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour {
    
    public int level = 0;
    public Text levelTexte;
	public float couldown;
	public float maxCouldown;
	public float couldownSpeed;
	public Slider couldownSlide;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        levelTexte.text = ("Level: " + level);
		couldownSlide.value = couldown;
		if (couldown <= maxCouldown) {
			couldown = couldown + couldownSpeed;
		}
		couldownSlide.maxValue = maxCouldown;
    }
    public void LevelAdd () {

		if (couldown >= maxCouldown) {
			level += 1;
			couldown = 0;
		}          
    }
    
}