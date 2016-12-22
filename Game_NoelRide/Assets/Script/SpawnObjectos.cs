using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectos : MonoBehaviour {

	public GameObject[] objetos;
	public float intervaloSpawn;
	public Transform spawnPosition;



	// Use this for initialization
	void Start () {
		StartCoroutine ("Spawn");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Spawn(){
		int idObjeto = Random.Range (0, objetos.Length);
		Instantiate (objetos[idObjeto], new Vector2(spawnPosition.position.x, objetos[idObjeto].transform.position.y), spawnPosition.rotation);
		yield return new WaitForSeconds (intervaloSpawn);
		StartCoroutine ("Spawn");
	}


}
