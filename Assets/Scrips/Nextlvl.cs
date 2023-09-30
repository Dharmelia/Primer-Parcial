using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlvl : MonoBehaviour
{
 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        { SceneManager.LoadScene(2); }
    }
}