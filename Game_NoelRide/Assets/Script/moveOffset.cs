using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOffset : MonoBehaviour {

	private 	Material 	materialAtual;
	public		float 		velocidadeX, velocidadeY;
	private 	float 		escalaMovimento;

	// Use this for initialization
	void Start () {
		materialAtual = GetComponent<Renderer> ().material;
	}
	
	// Update is called once per frame
	void Update () {
		escalaMovimento += 0.01f;
		materialAtual.SetTextureOffset ("_MainTex", new Vector2 (escalaMovimento * velocidadeX, escalaMovimento * velocidadeY));
	}
}
