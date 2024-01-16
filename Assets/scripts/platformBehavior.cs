using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBehavior : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    public static float speed;
    private float xPosition;
    private float yPosition;
    void Start()
    {
        yPosition = transform.position.y;
        transform.position = pointB.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = transform.position.x + speed * Time.deltaTime;
        if (transform.position.x >= pointB.transform.position.x)
        {
            speed *= -1f;
            xPosition -= 0.1f;

        }
        if (transform.position.x <= pointA.transform.position.x)
        {
            speed *= -1f;
            xPosition += 0.1f;
        }

        transform.position = new Vector3(xPosition, yPosition, 0);

    }
}
