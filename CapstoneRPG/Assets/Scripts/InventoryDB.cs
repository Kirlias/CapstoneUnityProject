using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;


public class InventoryDB : MonoBehaviour {

    public static List<ItemController> itemList = new List<ItemController>();


    public Sprite[] sprites;

	// Use this for initialization
	void Start () {

        ItemController i0 = new ItemController();

        i0.name = "BRoken Blade";
        i0.type = ItemController.Type.equip;
        i0.sprite = sprites[0];
        itemList.Add(i0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
