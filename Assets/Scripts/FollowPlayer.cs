using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //creating Game Objectes to accsing 
    public GameObject player;

    //defin the varaiable vectore3
    public Vector3 offset =new  Vector3(0, 5, -7);
    public Vector3 offset1 = new Vector3(0, 7, 7);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position+ offset;

        if (Input.GetKeyDown("v")) {
            transform.position = player.transform.position + offset1;

        }
        
    }
}
