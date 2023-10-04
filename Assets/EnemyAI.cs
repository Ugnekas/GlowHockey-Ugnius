using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform ball;
    public Transform defensePoint;
    public float speed;
    private Rigidbody2D rb;

    Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.x > 0)
        {


            var finalPos = Vector3.MoveTowards(transform.position, ball.position, speed * Time.deltaTime); ;
            rb.MovePosition(finalPos);
        }
        else
        {
            //defense
        var finalPos = Vector3.MoveTowards(transform.position, defensePoint.position, speed * Time.deltaTime);
        rb.MovePosition(finalPos);
            
        }
    }
}
