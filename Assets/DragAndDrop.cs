using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    bool moveAllowed;
    Collider2D col;
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);         //we get first touch
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);  //first touch's position storing

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if(col == touchedCollider)
                    moveAllowed = true;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                if(moveAllowed)
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);
            }
            if (touch.phase == TouchPhase.Ended)
            {
                moveAllowed = false;
            }
        }
    }
}
