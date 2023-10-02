using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class NavScript : MonoBehaviour
{

  
    public CharacterController enemyController;

    public Transform player;
    private NavMeshAgent agent;
    public Transform enemyTransform;


    int speed;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        speed = 5;

        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        var position = player.position;
        agent.destination = position;
    }

    
}
