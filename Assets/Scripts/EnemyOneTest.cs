using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOneTest : MonoBehaviour
{

public float rangoDeAlerta;

public LayerMask capaDelJugador;

public Transform jugador;

bool estarAlerta;

void Start()
{

}

    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position,rangoDeAlerta,capaDelJugador);

        if(estarAlerta == true)
        {
            transform.LookAt(jugador);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,rangoDeAlerta);
    }

}
