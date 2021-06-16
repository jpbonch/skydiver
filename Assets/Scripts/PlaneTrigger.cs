using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{
    public float waitTime = 1;
    public GameObject bird;
    public AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        bird.SetActive(false);
        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(birdActivate());
            source.Play();
        }
    }

    IEnumerator birdActivate()
    {
        yield return new WaitForSeconds(waitTime);
        bird.SetActive(true);



    }
}
