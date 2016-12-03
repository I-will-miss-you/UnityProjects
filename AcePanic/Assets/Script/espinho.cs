using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinho : MonoBehaviour {

	private 	Rigidbody2D		espinhoRb;
	private 	int 			atrito;
	public 		int 			atritoMax, atritoMin;
	public 		Vector3 		posicao;
	public 		GameObject 		espinhoPrefab;

	// Use this for initialization
	void Start () {
		espinhoRb = GetComponent<Rigidbody2D> (); 	
		atrito = Random.Range(atritoMin, atritoMax);
		espinhoRb.drag = atrito;
		posicao = transform.position;

	}

	void OnBecameInvisible () {
		Instantiate (espinhoPrefab, posicao, transform.localRotation);
		pontuacao.pontos += 1; 
		Destroy (this.gameObject);
	}
}
