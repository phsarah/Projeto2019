﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceControl : MonoBehaviour
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
            script.encostado = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Platforms")) {
            script.encostado = false;
        }
    }

}
