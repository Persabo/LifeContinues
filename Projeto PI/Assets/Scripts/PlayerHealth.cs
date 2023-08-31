using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{


 

    int Health = 1;
    public bool fireResistance = false;
    public bool iceResistance = false;
    public bool acidResistance = false;


    private void Update()
    {
        if (Health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fireFruit"))
        {
            fireResistance = true;
            iceResistance = false;
            acidResistance = false;
        }


        if (collision.gameObject.CompareTag("iceFruit"))
        {
            fireResistance = false;
            iceResistance = true;
            acidResistance = false;
        }
         if (collision.gameObject.CompareTag("acidFruit"))
        {
            fireResistance = false;
            iceResistance = false;
            acidResistance = true;
        }
        if (collision.gameObject.CompareTag("StatusRemover"))
        {
            fireResistance = false;
            iceResistance = false;
            acidResistance = false;
        } 
    }






    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FireDMG") && fireResistance == false)
        {
            Debug.Log("damage");
            Health -= 1;
        }

    //    if (collision.gameObject.CompareTag("acidDMG") && acidResistance == false)
    //    {
       //     Debug.Log("damage");
       //     Health -= 1;
     //   }

        if (collision.gameObject.CompareTag("iceDMG") && iceResistance == false)
        {
            Debug.Log("damage");
            Health -= 1;
        }
         if (collision.gameObject.CompareTag("acidDMG") && acidResistance == true)
        {
            Debug.Log("esta gamer?");
            Destroy(collision.gameObject);
        }
    }
}
