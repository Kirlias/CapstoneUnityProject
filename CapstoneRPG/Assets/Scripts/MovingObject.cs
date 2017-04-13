using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingObject : MonoBehaviour
{

    //Timcalculations
    public float moveTime = 0.1f;
    //layer for checking collisions
    public LayerMask blockingLayer;

    //boxes to check for collisions
    private BoxCollider2D boxCollider;
    private Rigidbody2D rd2d;

    //used for calculations
    private float inverseMoveTime;

    // Use this for initialization
    protected virtual void Start()
    {

        //references towards in game objects
        boxCollider = GetComponent<BoxCollider2D>();
        rd2d = GetComponent<Rigidbody2D>();

        //inverse the movetime
        inverseMoveTime = 1f / moveTime;
    }

    protected bool Move(int xDir, int yDir, out RaycastHit2D hit)
    {
        Vector2 start = transform.position;
        Vector2 end = start + new Vector2(xDir, yDir);

        boxCollider.enabled = false;
        hit = Physics2D.Linecast(start, end, blockingLayer);
        boxCollider.enabled = true;

        if (hit.transform == null)
        {
            StartCoroutine(SmoothMovement(end));
            return true;
        }

        return false;
    }

    //to make the character move
    protected IEnumerator SmoothMovement(Vector3 end)
    {
        //used for checking remaining distance to move
        float sqrRemainingDistance = (transform.position - end).sqrMagnitude;

        while (sqrRemainingDistance > float.Epsilon)
        {
            Vector3 newPosition = Vector3.MoveTowards(rd2d.position, end, inverseMoveTime * Time.deltaTime);
            rd2d.MovePosition(newPosition);
            sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            yield return null;
        }
    }

    protected abstract void OnCantMove<T>(T component)
        where T : Component;

    protected virtual void AttemptMove<T>(int xDir, int yDir)
        where T : Component
    {
        RaycastHit2D hit;
        bool canMove = Move(xDir, yDir, out hit);

        if (hit.transform == null)
            //If nothing was hit, return and don't execute further code.
            return;

        //Get a component reference to the component of type T attached to the object that was hit
        T hitComponent = hit.transform.GetComponent<T>();

        //If canMove is false and hitComponent is not equal to null, meaning MovingObject is blocked and has hit something it can interact with.
        if (!canMove && hitComponent != null)

            //Call the OnCantMove function and pass it hitComponent as a parameter.
            OnCantMove(hitComponent);
    }
}