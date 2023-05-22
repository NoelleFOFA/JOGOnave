using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D oRigid;
    public GameObject tiroplayer;
    public Transform localdisparo1;
    public float velonave;
    private Vector2 teclas;
    public bool temtiro2;
    void Start()
    {
        temtiro2 = false;
    }

    
    void Update()
    {
        MovimentoPlayer();
        Atirar();
    }
    private void MovimentoPlayer()
    {
        teclas = new Vector2(Input.GetAxisRaw("Horizontal") ,Input.GetAxisRaw("Vertical"));
        oRigid.velocity = teclas.normalized * velonave;
    }
    private void Atirar()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(temtiro2 == false)
            {
                Instantiate(tiroplayer, localdisparo1.position, localdisparo1.rotation);

            }

        }
    }
}
