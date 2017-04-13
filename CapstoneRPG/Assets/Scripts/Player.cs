using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;      //Allows us to use SceneManager

//Player inherits from MovingObject, our base class for objects that can move, Enemy also inherits from this.
public class Player : MonoBehaviour
{

    private BoxCollider2D boxCollider;
    private Rigidbody2D rd2d;

    //Start overrides the Start function of MovingObject
    void Start()
    {
        //references towards in game objects
        boxCollider = GetComponent<BoxCollider2D>();
        rd2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 movement_Vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rd2d.MovePosition(rd2d.position + 2 * (movement_Vector * Time.deltaTime));
    }

   
}
