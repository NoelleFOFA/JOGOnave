using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroPlayer : MonoBehaviour
{
    public float velotiro;
    void Start()
    {
        
    }

    void Update()
    {
       MoverTiro(); 
    }
    private void MoverTiro()
    {
        transform.Translate(Vector3.right * velotiro * Time.deltaTime);
    }
}
