using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerPosition;
    public Vector3 enemyPosition;
    Rigidbody rigidP;
    public float enSpeed;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rigidP = GetComponent<Rigidbody>();
        enSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position;
        enemyPosition = this.transform.position;
        transform.LookAt(player.transform);
        rigidP.velocity = transform.forward * enSpeed;
        // Vector3 Transform.forward(player, playerPosition);

    }
    //new Vector3  = playerPosition - enemyPosition;
    //void TurnTowardsPlayer()
    //{
    //    Vector3 relativePos = target.position - transform.position;(vector entre le gameobject et la cible)
    //Quaternion rotation = Quaternion.LookRotation(relativePos); (créer nouvelle matrice "rotation"
    //transform.rotation = rotation;
    //transform.rotation = Quaternion.RotateTowards(transform.rotation, player.rotation);
    //}
}
//  Rigidbody m_Rigidbody;
//float m_Speed;

