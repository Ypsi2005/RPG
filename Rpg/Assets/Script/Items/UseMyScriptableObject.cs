using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;

public class UseMyScriptableObject : MonoBehaviour {
	public MyScriptableObjectClass myScriptableObject;
	public GameObject chest;
	private List<SpriteRenderer> mySprites;

	// Use this for initialization
	void Start () 
	{
		mySprites = new List<SpriteRenderer>();
		foreach (Vector3 spawn in myScriptableObject.spawnPoints) {
			Instantiate(chest, spawn, Quaternion.identity);
//			mySprite.transform.position = spawn;
//			mySprite.GetComponent<Light>().enabled = false;
//			mySprites.Add (mySprite.GetComponent<SpriteRenderer>());
		}
	}
    
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) 
		{
			foreach (SpriteRenderer light in mySprites) 
			{
				light.enabled = !light.enabled;
			}
		}
		if (Input.GetButtonDown("Fire2"))
		{
			
		}

	}
//
//	void UpdateLights () 
//	{
//		foreach (var myLight in mySprites)
//		{
//			myLight.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
//		}
//	}
}