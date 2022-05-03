using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    private event Delegates.InputDelegate HorizontalInputDelegate;
    private event Delegates.InputDelegate VerticalInputDelegate;

    public void AddHorizontalInputDelegate(Delegates.InputDelegate inputDelegate)
    {
        HorizontalInputDelegate += inputDelegate;
    }

    public void AddVerticalInputDelegate(Delegates.InputDelegate inputDelegate)
    {
        VerticalInputDelegate += inputDelegate;
    }

    public void GetInput()
    {
        GetHorizontalInput();
        GetVerticalInput();
    }

    private void GetHorizontalInput()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        if (horizontalValue != 0f)
        {
            HorizontalInputDelegate(horizontalValue);
        }
    }

    private void GetVerticalInput()
    {
        float verticalValue = Input.GetAxis("Vertical");
        if (verticalValue != 0f)
        {
            VerticalInputDelegate(verticalValue);
        }
    }
}
