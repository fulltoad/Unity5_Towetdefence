using UnityEngine;
using System.Collections;

public class chanceTag : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col){
		if (col.tag == "Cilindro") {
			gameObject.tag = col.tag;
		}
	}

	void OnTriggerExit (Collider col){
		gameObject.tag = "Vazio";
	}
}
