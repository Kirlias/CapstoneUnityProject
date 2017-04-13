using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

    public Transform warpTarget;

    IEnumerator OnTriggerEnter2D(Collider2D Other) {

        Debug.Log("Object collided");
        if (true)
        {
            ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();

            yield return StartCoroutine(sf.FadeToBlack());

            Other.gameObject.transform.position = warpTarget.position;

            yield return StartCoroutine(sf.FadeToClear());
        }
    }

}
