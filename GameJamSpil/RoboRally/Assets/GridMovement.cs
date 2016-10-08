using UnityEngine;
using System.Collections;

public class GridMovement : MonoBehaviour
{
    /*enum Direction{
        right = 0,
        up,
        left,
        down
    }

   */

    public Vector2 Position;
    public Vector2 Direction;

    
    void TurnLeft()
    {
        transform.RotateAround(transform.position, Vector3.forward, 90);
        Direction = transform.right;
        Debug.Log("direction = " + Direction);

    }

    void TurnRight()
    {
        transform.RotateAround(transform.position, Vector3.forward, -90);
        Direction = transform.right;
        Debug.Log("direction = " + Direction);
    }

    public void SetDirection(Vector2 vec)
    {
        Direction = vec;
    }

    public void DriveForward()
    {
        bool CanIDrive = GridController.GridCtrlInstance.CheckTile(transform.position, transform.right);
        if (CanIDrive)
        {
            //Position.x = (int)(Position.x + Direction.x);
            //Position.y = (int)(Position.y + Direction.y);
            Position += (Vector2)transform.right;
            Position.x = Mathf.Round(Position.x);
            Position.y = Mathf.Round(Position.y);
            transform.position = Position;
        }
    }
    public void DriveBackwards()
    {
        bool CanIDrive = GridController.GridCtrlInstance.CheckTile(transform.position, -transform.right);
        if (CanIDrive)
        {
            Position -= (Vector2)transform.right;
            Position.x = Mathf.Round(Position.x);
            Position.y = Mathf.Round(Position.y);

            transform.position = Position;
        }

    }

    // Use this for initialization
    void Start()
    {
        Position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("w"))
        {
            DriveForward();
        }
        if (Input.GetKeyUp("s"))
        {
            DriveBackwards();
        }
        if (Input.GetKeyUp("a"))
        {
            TurnLeft();
        }
        if (Input.GetKeyUp("d"))
        {
            TurnRight();
        }

    }
}
