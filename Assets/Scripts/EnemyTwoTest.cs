using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoTest : MonoBehaviour
{

public float rangoDeAlerta;

public float distance;

public float speed = 7f;

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
            transform.LookAt(new Vector3(jugador.position.x,transform.position.y,jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(jugador.position.x,transform.position.y,jugador.position.z),speed * Time.deltaTime);
        }
    }

public void DistanceCheck()
{
    float distBetween = Vector3.Distance(jugador.position,transform.position);
    
    if (distBetween < distance)
    {
      speed = 0;
    }

    else
    {
      speed = 7f;
    }
}


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,rangoDeAlerta);
    }

}

