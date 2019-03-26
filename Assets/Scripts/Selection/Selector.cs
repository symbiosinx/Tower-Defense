using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour {

	[Header("Towers")]
	public GameObject[] towers;

	GameObject[] holograms;
	int currentIndex = 0;

	void Start () {
		holograms = new GameObject[towers.Length];
	}
	
	void Update () {
		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(mouseRay, out hit)) {
			Placeable p = hit.transform.GetComponent<Placeable>();
			if (p) {
				print(p);
			}
		}
	}

	/// <summary>
	/// Changes currentIndex to selected index
	/// </summary>
	/// <param name="index"></param>
	public void SelectTower(int index) {
		if (index >= 0 && index < towers.Length) {
			currentIndex = index;
		}
	}
}
