using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCarro : MonoBehaviour
{
    
    public Vector2 derechaX = new Vector2();    
    public Vector2 izquierdaX = new Vector2();

    void Start()
    {
        derechaX.x = transform.position.x + 3.9f;
        izquierdaX.x = transform.position.x - -0f;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
            transform.position = new Vector2(derechaX.x,transform.position.y);
        if(Input.GetKey(KeyCode.A))
            transform.position = new Vector2(izquierdaX.x,transform.position.y);
    }
}
