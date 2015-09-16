using UnityEngine;
using System.Collections;

public class generateFloor : MonoBehaviour {

	public int sizeX, sizeY;
	public GameObject floor;

	void Start () {
		for(int i = 0; i < sizeY; i++){
			for(int j = 0; j < sizeX; j++){
				Instantiate (floor, new Vector3(i,0,j), Quaternion.identity);
			}
		}	
	}
}
