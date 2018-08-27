using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngredientMemory : MonoBehaviour {

	public List<string> spawnedIngredients;
    public GameObject hamburgerPrefab, topBunPrefab, bottomBunPrefab, slicedCheesePrefab, segmentedCheesePrefab;
	public Vector3 spawnPosition;

	public int spawnsUntilReset = 15;
	public GameObject plate;

	// Use this for initialization
	void Start () {

		
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.F)) AddFoodToSpawnedIngredientList("Hamburger");

		if(Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
		
		if(spawnsUntilReset <= 0) StartCoroutine("OnOffPlate");
		
	}

	IEnumerator OnOffPlate()
	{
		plate.SetActive(false);
		yield return new WaitForSeconds(2f);
		plate.SetActive(true);
		spawnsUntilReset = 15;
	}


	public void AddFoodToSpawnedIngredientList(string ingredientName)
	{
		spawnsUntilReset -= 1;
		spawnedIngredients.Add(ingredientName);

		print(spawnedIngredients.Count);
		if(spawnedIngredients.Count >= 3)
		{
			spawnedIngredients.RemoveAt(0);
			print(spawnedIngredients.Count);

			if(ingredientName == spawnedIngredients[0] && ingredientName == spawnedIngredients[1])
			{
				GameObject umamiVersion = hamburgerPrefab;

				if(ingredientName.Contains("Hamburger")) umamiVersion = hamburgerPrefab;
				if(ingredientName.Contains("TopBun")) umamiVersion = topBunPrefab;
				if(ingredientName.Contains("BottomBun")) umamiVersion = bottomBunPrefab;
				if(ingredientName.Contains("SlicedCheese")) umamiVersion = slicedCheesePrefab;
				if(ingredientName.Contains("SegmentCheese")) umamiVersion = segmentedCheesePrefab;
			
				GameObject new3DFood = Instantiate(umamiVersion, spawnPosition, Quaternion.Euler(-90,0,0));
				new3DFood.GetComponent<Transform>().localScale = new3DFood.GetComponent<Transform>().localScale * 1.5f;
				spawnedIngredients.Clear();
				return;
			}
		}	

		
		if(ingredientName.Contains("Hamburger"))
		{
			GameObject new3DFood = Instantiate(hamburgerPrefab, spawnPosition, Quaternion.Euler(-90,0,0));
		}
		if(ingredientName.Contains("TopBun"))
		{
			GameObject new3DFood = Instantiate(topBunPrefab, spawnPosition, Quaternion.Euler(-90,0,0));
		}
		if(ingredientName.Contains("BottomBun"))
		{
			GameObject new3DFood = Instantiate(bottomBunPrefab, spawnPosition, Quaternion.Euler(-90,0,0));
		}
		if(ingredientName.Contains("SlicedCheese"))
		{
			GameObject new3DFood = Instantiate(slicedCheesePrefab, spawnPosition, Quaternion.Euler(-90,0,0));
		}
		if(ingredientName.Contains("SegmentCheese"))
		{
			GameObject new3DFood = Instantiate(segmentedCheesePrefab, spawnPosition, Quaternion.Euler(-90,0,0));
		}
	}
}
