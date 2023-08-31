using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrutasDeleite : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    public float height = 0.05f;
    public float startY = 3.25f;

    void Update()
    {
        var pos = transform.position;
        var newY = startY + height * Mathf.Sin(Time.time * speed);
        transform.position = new Vector2(pos.x, newY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
