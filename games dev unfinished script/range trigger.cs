//rangetrigger
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class rangetrigger : MonoBehaviour
{
    EnemyAi EneAi;
    // Start is called before the first frame update
    void Start()
    {
        //looks for the componet enemy ai
        EneAi = transform.root.GetComponent<EnemyAi>();
    }

    // Update is called once per frame
    void Update()
    {
        //when the player stands in the collider trigger it will update to true causing the ai to attack
       void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            {
                EneAi.inRange = true;
            }
    }
        //if the player is not in range of the collider it will set it to false
         void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            {
                EneAi.inRange = false;
            }
    }
}
}
