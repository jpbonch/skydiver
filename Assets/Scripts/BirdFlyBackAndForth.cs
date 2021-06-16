using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlyBackAndForth : MonoBehaviour
{
    private bool facingRight = true;
    public float speed = 2.0f;
    private SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(facingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
            mySpriteRenderer.flipX = true;
        }

        if(transform.position.x >= 4.0f)
        {
            facingRight = false;
            
        }
      
        if(transform.position.x <= -4)
        {
            facingRight = true;
            
        }

        
    }
}
