using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public float velocidadeInimigo;
    void Start()
    {
        
    }
    void Update()
    {
        MovimentoInimigo();
    }
    private void MovimentoInimigo()
    {
        transform.Translate(Vector3.up * velocidadeInimigo * Time.deltaTime);
    }
}
