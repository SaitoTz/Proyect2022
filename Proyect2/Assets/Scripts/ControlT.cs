using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlT : MonoBehaviour
{

    private float controlX, controlY;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    controlX = touchPos.x - transform.position.x;
                    controlY = touchPos.y - transform.position.y;
                    break;

                case TouchPhase.Moved:
                    rb.MovePosition(new Vector2(touchPos.x - controlX, touchPos.y - controlY));
                    break;

                case TouchPhase.Ended:
                    rb.velocity = Vector2.zero;
                    break;


            }




        }
    }
}
