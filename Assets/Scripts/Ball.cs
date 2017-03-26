using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public GameObject player;

	private Component script;
	private Rigidbody2D rb;
	private Vector2 sum;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		script = player.GetComponent<MovementPlayer> ();
		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){

		if (other.gameObject.name.Equals ("down")) {
			Debug.Log ("hit");
			Destroy (this.gameObject);
			MovementPlayer.state = false;
		} else if (other.gameObject.tag.Equals ("Wall")) {
			Destroy (other.gameObject);
		} 
	}
}
