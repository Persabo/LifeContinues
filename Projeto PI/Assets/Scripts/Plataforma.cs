using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public Transform Point_A, Point_b;
    public int speed;
    Vector2 targetPos;


    void Start()
    {
        targetPos = Point_b.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Point_A.position) < 1f) targetPos = Point_b.position;

        if (Vector2.Distance(transform.position, Point_b.position) < 1f) targetPos = Point_A.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }

}
