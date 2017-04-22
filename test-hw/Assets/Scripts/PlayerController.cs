using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		float moverHorizontal = Input.GetAxis ("Horizontal");
		float moverVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moverHorizontal, 0.0f, moverVertical);

		rb.velocity = movement * speed;
	}

	void Update () {
		
	}
}
