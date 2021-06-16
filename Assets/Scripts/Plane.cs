using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public float movementSpeed = 6f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
    }
}
