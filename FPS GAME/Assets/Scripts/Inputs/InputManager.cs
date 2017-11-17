using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    [SerializeField]
    private float axisThreshhold = 0.2f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

	public bool Up(){
        return Input.GetAxis(Strings.Movement.VERTICAL) > axisThreshhold;
    }
	public bool Down()
	{
		return Input.GetAxis(Strings.Movement.VERTICAL) < -axisThreshhold;
	}
	public bool Left()
	{
        return Input.GetAxis(Strings.Movement.HORIZONTAL) < -axisThreshhold;
	}
	public bool Right()
	{
        return Input.GetAxis(Strings.Movement.HORIZONTAL) > axisThreshhold;
	}

    /* 
     * functions that return values for the mouse position
     */
    public float GetXRot(){
        return Input.GetAxis(Strings.Movement.MOUSE_X);
    }
    public float GetYRot()
	{
        return -Input.GetAxis(Strings.Movement.MOUSE_Y);
	}

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
