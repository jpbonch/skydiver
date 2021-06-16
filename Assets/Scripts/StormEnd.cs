using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormEnd : MonoBehaviour
{
    public GameObject rain;
    public GameObject lightning;
    public GameObject clouds;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            rain.SetActive(false);
            lightning.SetActive(false);
            clouds.SetActive(false);
            

        }
    }
}
