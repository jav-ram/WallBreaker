using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreate : MonoBehaviour {

	public GameObject rows1;
	public GameObject rows2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.childCount <= 0) {
			GameObject row = Instantiate(rows1, new Vector3(0,0,0),Quaternion.identity);
			row.transform.parent = GameObject.Find ("Rows").transform;
			row = Instantiate(rows2, new Vector3(0,2,0),Quaternion.identity);
			row.transform.parent = GameObject.Find ("Rows").transform;
		}
	}
}
