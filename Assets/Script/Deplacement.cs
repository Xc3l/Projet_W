using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deplacement : MonoBehaviour
{
    PlayerControls controls;
    Vector3 move;
    public float speed = 3;

    void Awake(){
        controls = new PlayerControls();
        controls.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move = Vector3.zero;

    }

    void Update(){
        Vector3 m = new Vector3(move.x, 0.0f, move.y) * speed * Time.deltaTime;
        transform.Translate(m, Space.World);
    }

    void OnEnable(){
        controls.Player.Enable();

    }

    void OnDisable(){
        controls.Player.Disable();

    }
}

