using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    //Any Collider2D component will call this function on
    //any attached scripts when the collider enters a collision with another collider.
    //The gameobject must also have a RigidBody2D attached.

    public void ButtonPress()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

   
    public void ButtonTitle()
    {
        SceneManager.LoadScene(1);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.gameObject == level1)
        {
            Debug.Log("SWAP");

            SceneManager.LoadScene(2);
        }

        if (collision.collider.gameObject == level2)
        {
            Debug.Log("SWAP");

            SceneManager.LoadScene(3);
        }


        if (collision.collider.gameObject == level3)
        {
            Debug.Log("SWAP");

            SceneManager.LoadScene(0);
        }
    }


  
}
