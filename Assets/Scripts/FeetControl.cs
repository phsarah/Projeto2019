using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetControl : MonoBehaviour
{

    public GameObject player;

    MoveToRef script;

    void Start()
    {
        script = player.GetComponent<MoveToRef>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Platforms")) {
            script.peApoiado = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Platforms")) {
            script.peApoiado = false;
        }
    }
}
