using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlyLeft : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movebirdleft();
    }
    void movebirdleft()
    {
        transform.Translate(speed * -Time.deltaTime, 0, 0);
    }
}
