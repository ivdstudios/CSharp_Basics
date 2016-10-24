using UnityEngine;
using System.Collections;

public class CannonBall : MonoBehaviour {

	public Rigidbody projectile;
	public int throwPower; 

	// Use this for initialization
	void Start () {
		projectile = projectile.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			Rigidbody clone; 
			clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.down * throwPower); 
		}
	}
}
