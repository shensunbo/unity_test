using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armRotate : MonoBehaviour
{
    private Vector3 startPosition;
    private bool movingForward = true;
    public float moveDistance = 8500f;
    public float moveSpeed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingForward)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.World);
            if (Vector3.Distance(startPosition, transform.position) >= moveDistance)
            {
                movingForward = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime, Space.World);
            if (Vector3.Distance(startPosition, transform.position) <= 0.01f)
            {
                transform.position = startPosition;
                movingForward = true;
            }
        }
    }
}
