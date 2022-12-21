using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSwitcher: MonoBehaviour
{
    [SerializeField]
    private GameObject robot1;
    [SerializeField]
    private GameObject robot2;
    private bool switched = false;

    public void ChangeRobot()
    {
        switch(switched)
        {
            case false:
                Instantiate(robot2, transform.position, transform.rotation);
                switched = true;
                break;
            case true:   
                Instantiate(robot1, transform.position, transform.rotation);
                switched = false;
                break;
        }
    }
}
