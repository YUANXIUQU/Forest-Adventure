using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_platform : MonoBehaviour
{
    public Transform targetposition;
    public Transform initialposition;
    public bool atplatform = false;
    public bool moveback = false;
    public int speed = 2;
    void OnTriggerEnter2D(Collider2D other )
    {
        if (other.gameObject.name == "character")
        {
            atplatform = true;
        }
    }
    void Update()
    {
        if ( atplatform )
        {
            Move_p();
        }
        if (Vector2.Distance(transform.position,targetposition.position) < 0.1f)
        {
            atplatform = false;
            moveback = true;
        }
        if (moveback)
        {
            Moveback_p();
        }
        if (moveback && Vector2.Distance(transform.position, initialposition.position) < 0.1f)
        {
            moveback = false; 
        }
    }


    void Move_p()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetposition.position, speed * Time.deltaTime);

    }

    void Moveback_p()
    {
        transform.position = Vector2.MoveTowards(transform.position, initialposition.position, speed * Time.deltaTime);
    }
}
