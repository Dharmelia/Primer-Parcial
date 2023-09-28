using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SIGUIENTENIVEL : MonoBehaviour
{
    private void OnTriggerEnter(Collider Other)

    {
        if (Other.gameObject.name == "PER")
        
            SceneManager.LoadScene(1);
        }
    
}
