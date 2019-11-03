using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verde : MonoBehaviour {

	public float velocidad = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.E))
			transform.Translate(Vector2.left * velocidad * Time.deltaTime);
		if(Input.GetKey(KeyCode.F))
			transform.Translate(Vector2.right * velocidad * Time.deltaTime);
		if(Input.GetKey(KeyCode.G))
			transform.Translate(Vector2.up * velocidad * Time.deltaTime);
		if(Input.GetKey(KeyCode.H))
			transform.Translate(Vector2.down * velocidad * Time.deltaTime);
		
		
	}
}
