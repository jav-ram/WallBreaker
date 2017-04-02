using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour {

	public Rigidbody2D rb;
	public float v;
	public static bool state;
	public GameObject ball;

	private Rigidbody2D rbb;
	private GameObject ballprefab;

	private float x;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		v = v * 10;
		state = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (state) {
			Move ();
		} else {
			Shoot ();
		}
	}

	void Move(){
		if (Input.GetKey (KeyCode.RightArrow)) {
			x = v;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			x = -v;
		} else {
			x = 0;
		}
		rb.AddForce (new Vector2 (x,0));
	}

	void Shoot(){
		rb.transform.position = new Vector2 (0, -4f);
		if (ballprefab == null) {
			ballprefab = Instantiate (ball, rb.transform.position, Quaternion.identity);
			rbb = ballprefab.GetComponent<Rigidbody2D> ();	
		} else {
			if (Input.GetKey (KeyCode.Space)){
				rbb.velocity = new Vector2 (0, 5f);
				ChangeState();
			}
		}

	}

	public void ChangeState(){
		state = !state;
	}

	void FixedUpdate(){
		Vector3 forwardForce = new Vector3 (0, 0, 10f);
		rb.AddForce (forwardForce);
	}


}
