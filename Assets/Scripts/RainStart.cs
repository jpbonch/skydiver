using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainStart : MonoBehaviour
{
    public GameObject rain;
    public GameObject lightning;
    public AudioSource source;
    public GameObject clouds;


    // Start is called before the first frame update
    void Start()
    {
        rain.SetActive(false);
        source = GetComponent<AudioSource>();
        lightning.SetActive(false);
        clouds.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            rain.SetActive(true);
            lightning.SetActive(true);
            source.Play();
            clouds.SetActive(true);

            
        }
    }

}

