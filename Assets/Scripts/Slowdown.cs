using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowdown : MonoBehaviour
{
    private GameObject effectscanvas;

    IEnumerator waiter()
    {
        Time.timeScale = 0.75f;
        yield return new WaitForSeconds(5);  //wait for 5 seconds 
        Time.timeScale = 0.9f;
        effectscanvas.SetActive(false);
        yield return new WaitForSeconds(5);
        Time.timeScale = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        effectscanvas = GameObject.Find("EffectsCanvas");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            effectscanvas.SetActive(true);
            StartCoroutine(waiter());
        }
    }
}
