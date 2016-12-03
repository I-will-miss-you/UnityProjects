using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour {

	private Rigidbody2D playerRb;
	private SpriteRenderer playerSprite; 

	public float velocidade , velocidadeAux;
	public bool flipX; 

	// Use this for initialization
	void Start () {
		playerRb = GetComponent<Rigidbody2D>();
		playerSprite = GetComponent<SpriteRenderer> ();
		velocidadeAux = velocidade;
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetMouseButtonDown (0)) {
			velocidade *= -1; 
			flipX = !flipX;
			playerSprite.flipX = flipX; 
		}
		*/
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			if (velocidade == (-1 * velocidadeAux)) {
				velocidade *= 2;
			} else {
				velocidade = -1 * velocidadeAux;
				playerSprite.flipX = true;
			}

		}
			
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			if(velocidade == velocidadeAux){
				velocidade *= 2;
			}
			else{
			velocidade = velocidadeAux; 
			playerSprite.flipX = false;
			}
		}


			
		playerRb.velocity = new Vector2 (velocidade, playerRb.velocity.y);
	}

	void OnCollisionEnter2D(Collision2D colisao){
		if(colisao.gameObject.tag == "espinho"){
			SceneManager.LoadScene ("gameOver");
		}
	
	}

	void OnTriggerEnter2D(Collider2D colisao){
		if(colisao.gameObject.tag == "espinho"){
			SceneManager.LoadScene ("gameOver");
		}
	}
}
