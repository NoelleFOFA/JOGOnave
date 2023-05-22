using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public float velocidadeInimigo;
    public GameObject tiroinimigo;
    public Transform localdisparoinimigo;
    public float tempomaxtiro;
    public float tempoatual;
    public bool inimigoatirador;

    void Start()
    {
        
    }
    void Update()
    {
        MovimentoInimigo();
        if(inimigoatirador == true)
        {
            Atirarinimigos();
        }
    }
    private void MovimentoInimigo()
    {
        transform.Translate(Vector3.up * velocidadeInimigo * Time.deltaTime);
    }
    private void Atirarinimigos()
    {
        tempoatual -= Time.deltaTime;
        if(tempoatual <= 0)
        {
            Instantiate(tiroinimigo, localdisparoinimigo.position, Quaternion.Euler(0f,0f,0f));
            tempoatual = tempomaxtiro;
        }
    }
}
