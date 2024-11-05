using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MathiasInputSystem : MonoBehaviour
{
    [SerializeField] private float _playerPosition;
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

        var mousePosition = Input.mousePosition;

        var bottomLeftBoundary = Camera.main.ViewportToWorldPoint(Vector3.zero);
        var topRightBoundary = Camera.main.ViewportToWorldPoint(Vector3.one);

        var mousePositionInWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePositionInWorldSpace.z = 0;
        mousePositionInWorldSpace.y = Mathf.Clamp(mousePositionInWorldSpace.y, bottomLeftBoundary.y + .5f, topRightBoundary.y - .5f);
        transform.position = mousePositionInWorldSpace;
        mousePositionInWorldSpace.x = Mathf.Clamp(mousePositionInWorldSpace.x, bottomLeftBoundary.x + .5f, topRightBoundary.x - .5f);
        transform.position = mousePositionInWorldSpace;
    }

    void MoveObject(Vector3 inputPosition)
    {
        
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(inputPosition);
        worldPosition.z = 0; 

        
        transform.position = worldPosition;
    }
}
