using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gravwell : MonoBehaviour
{
    private Transform trans;
    private List<Rigidbody2D> heldObjects = new List<Rigidbody2D>();

    private Mouse mouse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trans = GetComponent<Transform>();
        mouse = Mouse.current;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 worldPoint2d = new Vector2(worldPoint.x, worldPoint.y);
        trans.position = worldPoint2d;


        if (mouse.leftButton.wasReleasedThisFrame)
        {
            
        }
    }

}
