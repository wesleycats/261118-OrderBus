﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Temp1 : MonoBehaviour {

	List<Item> equipedItems = new List<Item>();
	bool test = false;

	void Update()
	{
		DisplayItem(test);
	}

	void DisplayItem(bool display){
		GameObject coffee = this.gameObject.transform.GetChild(0).gameObject;
		if(display == true){
			for(int i = 0; i < equipedItems.Count; i++){
				if(equipedItems[i].GetItem == ItemType.Coffee){
					coffee.SetActive(true);
				}
			}
		}
		else
		{
			coffee.SetActive(false);
		}
	}

	public void Test(){
		if (test == false)
		{
			test = true;
		}
		else
		{
			test = false;
		}
	}

}
