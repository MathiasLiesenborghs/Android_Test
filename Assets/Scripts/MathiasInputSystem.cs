using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathiasInputSystem : MonoBehaviour
{
    void Update()
    {
        
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                MoveObject(touch.position);
            }
        }
        else if (Input.GetMouseButton(0)) 
        {
            MoveObject(Input.mousePosition);
        }
    }

    void MoveObject(Vector3 inputPosition)
    {
        
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(inputPosition);
        worldPosition.z = 0; 

        
        transform.position = worldPosition;
    }
}
