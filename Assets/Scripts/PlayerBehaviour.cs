using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public FloatVariable health;

    private void Start()
    {
        health.Value = 100;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            health.Value -= 5;
    }
}
