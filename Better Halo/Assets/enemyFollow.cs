using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyFollow : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        //transform.LookAt(new Vector3(player.position.x, transform.position.y, transform.position.z));
        transform.Rotate(-90, 0, 0);
        transform.position  -= transform.up * 2f * Time.deltaTime;
    }
}
