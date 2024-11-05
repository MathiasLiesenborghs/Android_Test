using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathiasDescent : MonoBehaviour
{
    private float speed;

    public void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y < -Screen.height / 2f)
        {
            Destroy(gameObject);
        }
    }
}
