using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NPCcontroller : MonoBehaviour
{
    //create variables
    //NPC level
    public int NPCLevel = 1;
    //NPC health
    private float NPCHealth;
    private Vector3 newPosition;
    //NPC speed
    public float speed;
    void Start()
    {
        //add level to health
        NPCHealth += NPCLevel;
        //print health
        print(gameObject.name + "'s health: "+NPCHealth);

        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
