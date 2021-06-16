using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public float speed = 6f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(lavastart());
    }


    IEnumerator lavastart()
    {
        while (enabled)
        {
            transform.Translate(Vector2.right * speed);
            yield return new WaitForSeconds(2);
            transform.Translate(-Vector2.right * speed);
            yield return new WaitForSeconds(2);
        }
       

    }

    // Update is called once per frame
    void Update()
    {
       
    }

   
}
