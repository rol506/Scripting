using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.U2D;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float speedFactor = 2.5f;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<FirstPersonMovement>().speed *= speedFactor;
            other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<FirstPersonMovement>().speed /= speedFactor;
            other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
        }
    }
}
