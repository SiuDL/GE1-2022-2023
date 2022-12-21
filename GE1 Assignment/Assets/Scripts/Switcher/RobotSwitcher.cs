using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSwitcher: MonoBehaviour
{
    // serialized field to store the robot prefabs
    [SerializeField]
    private GameObject robotPrefab1;
    [SerializeField]
    private GameObject robotPrefab2;

    // variables to contain the clones of the prefabs
    private GameObject robot1;
    private GameObject robot2;

    // boolean to check if robot has been switched
    private bool switched = false;

    // method to change the robot
    public void ChangeRobot()
    {
        switch(switched)
        {
            case false:
                if(robot2)
                    Destroy(robot2);
                robot1 = GameObject.Instantiate<GameObject>(robotPrefab1);
                switched = true;
                break;
            case true:
                if(robot1)
                    Destroy(robot1);
                robot2 = GameObject.Instantiate<GameObject>(robotPrefab2);   
                switched = false;
                break;
        }
    }
}
