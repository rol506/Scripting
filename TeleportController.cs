using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    [SerializeField] private Vector3 toTeleport = new Vector3(-0.4f, 1.2f, 0f);

    public void OnTriggerEnter(Collider other)
    {
        other.transform.position = toTeleport;
    }
}
