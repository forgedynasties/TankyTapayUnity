using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    [SerializeField] private GameObject bike;
    private TimeControl timeControl;

    private bool throttleButton, brakeButton, steerLeftButton, steerRightButton;

    private void Start()
    {
        throttleButton = false;
        brakeButton = false;
        steerLeftButton = false;
        steerRightButton = false;
    }

    private void Update()
    {
        if (throttleButton)
            throttle();
        if(brakeButton)
            brake();
        if(steerLeftButton)
            steerLeft();
        if(steerRightButton)
            steerRight();
    }

    public void steerLeft()
    {
        bike.GetComponent<BikeController>().steerLeft();
    }
    public void steerRight()
    {
        bike.GetComponent<BikeController>().steerRight();

    }
    public void throttle()
    {

    }

    public void brake()
    {

    }

    public void engineStart()
    {
        bike.GetComponent<BikeController>().startEngine();

    }

    public void throttleButtonDown()
    {
        bike.GetComponent<BikeMovement>().throttleButtonDown();
    }
    public void throttleButtonUp()
    {
        bike.GetComponent<BikeMovement>().throttleButtonUp();

    }

    public void brakeButtonDown()
    {
        bike.GetComponent<BikeMovement>().brakeButtonDown();

    }
    public void brakeButtonUp()
    {
        bike.GetComponent<BikeMovement>().brakeButtonUp();

    }

    public void steerLeftButtonDown()
    {
        steerLeftButton = true;
        bike.GetComponent<BikeController>().steerLeftDown();
    }
    public void steerLeftButtonUp()
    {
        steerLeftButton = false;
        bike.GetComponent<BikeController>().steerUp();

    }

    public void steerRightButtonDown()
    {
        steerRightButton= true;
        bike.GetComponent<BikeController>().steerRightDown();

    }

    public void steerRightButtonUp()
    {
        steerRightButton = false;
        bike.GetComponent<BikeController>().steerUp();

    }

}
