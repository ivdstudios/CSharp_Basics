using UnityEngine;
using System.Collections;

public class CubeAnim : MonoBehaviour {

	Animation anim; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>(); 
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			anim.Play();
		}
		if(Input.GetButtonDown("Fire2"))
		{
			anim.Stop(); 
		}
	}
}
