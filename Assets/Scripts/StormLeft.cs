using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormLeft : MonoBehaviour
{
    public static float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movebirdright();
    }

    void movebirdright()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

}

