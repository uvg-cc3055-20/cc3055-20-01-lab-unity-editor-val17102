using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
	public float jumpforce = 10f;
	public float fowardspeed = 2f;
	public GameObject cam;
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.up * jumpforce);
		}
		rb.transform.Translate (new Vector3 (1, 0, 0) * fowardspeed * Time.deltaTime);
		cam.transform.Translate (new Vector3 (1, 0, 0) * fowardspeed * Time.deltaTime);
	}
}
