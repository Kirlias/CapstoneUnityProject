using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotControler : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    

    void OnMouseEnter()
    {
        transform.parent.GetComponent<InventoryControler>().selectedSlot = this.transform;
    }

    void OnMouseExit()
    {
        transform.parent.GetComponent<InventoryControler>().selectedSlot = null;
    }
}
