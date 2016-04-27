using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Rigidbody rg;
	public float speed;
	public string left;
	public string right;
	public string front;
	public string back;

	// private float rotation = 0;

	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Unity Documentation: "FixedUpdate should be used instead of Update when dealing with Rigidbody"
	void FixedUpdate(){
		int moveLeft = Input.GetKey (left) ? 1 : 0;
		int moveRight = Input.GetKey (right) ? 1 : 0;
		int moveFront = Input.GetKey (front) ? 1 : 0;
		int moveBack = Input.GetKey (back) ? 1 : 0;

		Vector3 movement = new Vector3 ((moveRight - moveLeft) * speed, 0, (moveFront - moveBack) * speed);

		/*
		Vector3 movement = new Vector3 (0, 0, (moveFront - moveBack) * speed);

		bool bLeft = Input.GetKey (left);
		bool bRight = Input.GetKey (right);

		if (bLeft)
			rotation--;
		if (bRight)
			rotation++;
		rg.rotation.Set (1, rotation, 1, 1);
		*/


		rg.AddForce (movement);
	}


	void OnCollisionEnter (Collision other){

		if (other.gameObject.CompareTag (Tags.bullet)) {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}

		//other.AddExplosionForce(1.0, other.transform.position, 5.0);
	}
}
