using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
  public Transform target;
  Camera player_camera;

  void Start() {
    player_camera = GetComponent<Camera> ();

  }

  void Update () {
    player_camera.orthographicSize = (Screen.height / 100f ) / 2f;

    if (target) {
      transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3(0,0,-10);
    }
  }
}

