using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MovingObject {


    protected override void OnCantMove<T>(T component)
    {
        
    }

    // Use this for initialization
    protected override void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit;
        Move(2, 2, out hit);

	}
}
