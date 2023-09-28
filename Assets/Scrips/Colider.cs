using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Damage"))
            {
            DoDamageToPlayer();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.CompareTag("Damage")) 
            {
            DoDamageToPlayer();
              }
    }
    void DoDamageToPlayer()
    {
        Debug.Log("Hit!");
    }
}
