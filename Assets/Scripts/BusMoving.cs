using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMoving : MonoBehaviour
{   //creating Game Objectes to accsing 
    public int speed=5;


    //defin the varaiable vectore3
    public Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
