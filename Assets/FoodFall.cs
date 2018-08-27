using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFall : MonoBehaviour {

	public GameObject burgerPrefab;	
	public Vector3 burgerSpawnPosition;
	GameObject plate;

	// Use this for initialization
	void Start () {
		plate = GameObject.Find("Plate");

		
	}
	
	// Update is called once per frame
	void Update () {

		// if(Input.GetKeyDown(KeyCode.F))
		// {
		// 	print("burger Spawned");
		// 	GameObject burger;
		// 	burger = Instantiate(burgerPrefab, plate.transform.position + burgerSpawnPosition, Quaternion.identity);
		// }
		
	}
}
