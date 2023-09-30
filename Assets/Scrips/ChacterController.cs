using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Controlelr : MonoBehaviour
{
    public float horizantalMove;
    public float verticalMove;
    public CharacterController player;
    public float speed;
    void Start()
    {
      player = GetComponent<CharacterController>();

    }

    private void FixedUpdate()
    {
      player.Move(new Vector3 (horizantalMove,0 , verticalMove) * speed * Time.deltaTime);
          
    }
    void Update()
    {
        horizantalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        

    }
}
