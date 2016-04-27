using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public KeyCode shootKey;
	public Rigidbody projectile;

	public GameObject player;
	private Vector3 offset;

	public int bulletSpeed;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(shootKey)) {
			Rigidbody clone = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;
			clone.transform.position = player.transform.position + offset;
			clone.velocity = transform.TransformDirection (new Vector3 (0, 0, bulletSpeed));
			clone.gameObject.tag = Tags.bullet;
		}
	}
		
}