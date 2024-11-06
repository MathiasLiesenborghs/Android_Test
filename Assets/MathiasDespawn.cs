using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathiasDespawn : MonoBehaviour
{
    public float lifeTime = 11f;

    void Start()
    {
        StartCoroutine(DisparaitreAprèsTemps());
    }

    IEnumerator DisparaitreAprèsTemps()
    {
        yield return new WaitForSeconds(lifeTime);


        Destroy(gameObject);
    }
}
