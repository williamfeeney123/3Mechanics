using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



// Allows the user to click on the square, drag, and release to fling
public class Fling : MonoBehaviour
{
    public float flingSpeed = 200f;
    public int counterForShots;
    public Text text;
    Rigidbody2D rb;
    Vector2 mouseDownPos;
    Vector2 mouseUpPos;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseUp() {
        // get mouse position in world coordinates
        mouseUpPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // difference vector
        Vector2 diff = (Vector2)transform.position - mouseUpPos;

        // add that force with speed
        rb.AddForce(diff * flingSpeed);

        counterForShots++;

        text.text = "Shots: " + counterForShots;

    }
}
