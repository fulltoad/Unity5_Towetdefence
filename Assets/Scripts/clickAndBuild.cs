using UnityEngine;
using System.Collections;

public class clickAndBuild : MonoBehaviour {

	public GameObject item;

	void Start () {
	
	}
	
	void Update () {
		instantiateDefense ();
	}

	public void instantiateDefense(){
		if (Input.GetMouseButtonDown (0)) {

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if(Physics.Raycast(ray, out hit)){
				if(hit.collider.tag == "Vazio"){
					print("Clicou no vazio");
					Instantiate (item, new Vector3(hit.transform.position.x,hit.transform.position.y +1,hit.transform.position.z), Quaternion.identity);
				}
			}
		}
	}
}
