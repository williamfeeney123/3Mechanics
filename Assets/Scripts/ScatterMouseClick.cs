using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScatterMouseClick : MonoBehaviour
{
    Rigidbody2D rb;
    private float explode = 500f;
    public int counterForGravity;
    public bool UporDown = false;
    public Text text2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (UporDown == false)
            {
                Vector2 move = transform.up;
                rb.AddForce(move * explode);
            }
            if (UporDown == true)
            {
                Vector2 move = -transform.up;
                rb.AddForce(move * explode);
            }

            counterForGravity--;
            text2.text = "Gravity Pulse: " + counterForGravity;
            if(counterForGravity == 0)
            {
                Destroy(this);
            }
        }
    }
}
