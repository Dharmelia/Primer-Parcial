using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Estructura : MonoBehaviour
{
    public int Respawn;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        { SceneManager.LoadScene(Respawn); }
    }
}
