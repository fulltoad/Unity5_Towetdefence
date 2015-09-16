//Bruno Melo


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cilindro : MonoBehaviour {

	public CanvasGroup abc;

	void Start () {
		StartCoroutine (underConstructoin (1));
	}

	void Update () {
		//showUI ();
	}

	public void showUI(){
		if (Input.GetMouseButtonDown (0)) {
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			if(Physics.Raycast(ray, out hit)){
				if(hit.collider.tag == "Cilindro"){
					abc.interactable = true;
				}
			}else{
				//Aqui faz ser falso a UI
			}
		}
	}

	IEnumerator underConstructoin(float wTime){
		print ("Comecou");
		gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
		yield return new WaitForSeconds (wTime);
		gameObject.GetComponent<Renderer> ().material.color = Color.blue;
	}
}
