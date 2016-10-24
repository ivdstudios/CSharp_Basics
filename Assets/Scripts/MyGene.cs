using UnityEngine;
using System.Collections;

public class MyGene : MonoBehaviour {


	// Use this for initialization
	void Start () {
		MyRealGene mrg = new MyRealGene(); 

		mrg.Sum(1,2);

		int a = 34; 
		int b = 54645; 

		mrg.Swap<int>(ref a,ref b); 

		print("Value of a " + a);
		print("Value of b " + b); 

		// creating an object for generic class

		Gene<int> gn = new Gene<int>(); 

		print((int)gn.Printing(343)); 

		Jambo jb = new Jambo(); 
		Jambo.a; 
		jb.b; 

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
