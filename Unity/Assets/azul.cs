using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class azul : MonoBehaviour {

	public float velocidad = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.C))
			transform.Translate(Vector2.up * velocidad * Time.deltaTime);
		if(Input.GetKey(KeyCode.D))
			transform.Translate(Vector2.down * velocidad * Time.deltaTime);
		
		
	}
}
