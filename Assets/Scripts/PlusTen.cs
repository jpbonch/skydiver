using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusTen : MonoBehaviour
{
    public static float plus;
    private GameObject plusCanvas;
    // Start is called before the first frame update
    void Start()
    {
        plus = 0;
        plusCanvas = GameObject.Find("PlusScoreCanvas");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waiting()
    {
        plusCanvas.SetActive(true);
        yield return new WaitForSeconds(1);
        plusCanvas.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            plus += 10;
            StartCoroutine(waiting());
        }

    }
}
