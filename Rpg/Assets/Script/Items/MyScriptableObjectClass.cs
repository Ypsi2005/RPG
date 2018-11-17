using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "Inventory/List", order = 1)]
public class MyScriptableObjectClass : ScriptableObject {
	public string objectName = "New MyScriptableObject";
	public bool colorIsRandom;
	public Color thisColor = Color.white;
	public Vector3[] spawnPoints;
}