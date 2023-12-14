//enemy ai 

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    // creates the variables and attributes to call from the game files 
    GameObject Player;
    private CharacterController cc;
    public float speed = 3;
    public float AttackDistance = 6;
    public float gravity = 20f;
    // makes the character stationary
    Vector3 moveDirection = Vector3.zero;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //looks for the players movement and defines the animator  
        Player = FindObjectOfType<characterMovement>();
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange == true)
        {
            transform.LookAt(new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z));
            float dist = Vector3.Distance(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z));
            if (dist > AttackDistance)
            {
                if (transform.position.x > Player.transform.position.x)
                {
                    moveDirection = new Vector3(-1, 0, 0);
                }
                else
                {
                    moveDirection = new Vector3(1, 0, 0);
                }
            }
        }
    }
}
