using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetos : MonoBehaviour {
	private Rigidbody2D objetoRb;
	public float velocidade;


	// Use this for initialization
	void Start () {
		objetoRb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		objetoRb.velocity = new Vector2 (velocidade, 0);
	}
}
