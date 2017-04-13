using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {


    public string name;
    public enum Type { equip };

    public Type type;
    public Sprite sprite;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        transform.parent.parent.GetComponent<InventoryControler>().selectedItem = this.transform;
    }
}
