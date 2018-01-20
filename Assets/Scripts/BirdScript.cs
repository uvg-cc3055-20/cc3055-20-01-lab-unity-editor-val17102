using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
	public float jumpforce = 10f;
	public float fowardspeed = 2f;
	public bool dead = false;
	public GameObject cam;
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();	
	}

	// Update is called once per frame
	void Update () {
		if (dead == false) {
			if (Input.GetButtonDown ("Jump")) {
				rb.velocity = Vector2.zero;
				rb.AddForce (Vector2.up * jumpforce);
			}
			rb.transform.Translate (new Vector3 (1, 0, 0) * fowardspeed * Time.deltaTime);
			cam.transform.Translate (new Vector3 (1, 0, 0) * fowardspeed * Time.deltaTime);
		}
		if (rb.position.x == 27) {
			dead = true;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Lose")
		dead = true;
	}
}
