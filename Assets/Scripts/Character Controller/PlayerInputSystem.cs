using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputSystem : MonoBehaviour
{
    public float HorizontalInput, VerticalInput;
    public bool SpaceInput, ShiftInput;

    void Start()
    {
        
    }

    void Update()
    {
        inputFunction();
    }

    public void inputFunction()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
        SpaceInput = Input.GetButton("Space");
        ShiftInput = Input.GetButton("LeftShift");
    }
}
