using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public abstract class Item : ScriptableObject {

    public string title { get; set; }
    public string id { get; set; }
    public string type { get; set; }
    public Sprite sprite;



}
