using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// LateUpdate is called after all Update functions have been called
	void LateUpdate (){
		if (player.gameObject != null) {
			transform.position = player.transform.position + offset;
		}
	}
}
