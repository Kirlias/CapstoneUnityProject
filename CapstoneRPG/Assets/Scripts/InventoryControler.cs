using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryControler : MonoBehaviour {


    public Transform selectedItem;
    public Transform selectedSlot { get; set; }
    public Transform originalSlot;

    public GameObject slotPrefab, itemPrefab;

    public Vector2 inventorySLots = new Vector2(6,2);

    public float slotSize;

    public Vector2 windowSize;


	// Use this for initialization
	void Start () {
		
        for(int i = 1; i <= inventorySLots.x; i++)
        {
            for(int j = 1; j <= inventorySLots.y; j++)
            {

                GameObject slot = Instantiate(slotPrefab) as GameObject;
                slot.transform.SetParent(this.transform);
                slot.name = "Slot_" + i + "_" + j;
                slot.GetComponent<RectTransform>().anchoredPosition = new Vector3(windowSize.x / (inventorySLots.x + 1) * i, 
                    (windowSize.y/inventorySLots.y+1) * - j, 0);

            }
        }

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) && selectedItem != null)
        {
            selectedItem.GetComponent<Collider2D>().enabled = false;

        }

        if (Input.GetMouseButton(0) && selectedItem != null)
        {
            selectedItem.position = Input.mousePosition;
        }

        else if(Input.GetMouseButtonUp(0) && selectedItem != null)
        {
            if (selectedSlot == null)
            {
                selectedItem.SetParent(originalSlot);
            }
            else
            {
                selectedItem.SetParent(selectedSlot);
                
            }

            selectedItem.localPosition = Vector3.zero;
            selectedItem.GetComponent<Collider2D>().enabled = true;
        }
	}
}
