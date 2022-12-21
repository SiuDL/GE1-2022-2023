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
    private bool switched = false; // set to false initially to spawn in the first robot

    // method to change the robot
    public void ChangeRobot()
    {
        switch(switched)
        {
            case false:
                if(robot2) // checks if the second robot's clone exists
                    Destroy(robot2); // destroys object
                // intantiate a clone of the prefab 1 robot
                robot1 = GameObject.Instantiate<GameObject>(robotPrefab1);
                switched = true;
                break;
            case true:
                if(robot1) // checks if the first robot's clone exists
                    Destroy(robot1); // destroys object
                // intantiate a clone of the prefab 1 robot
                robot2 = GameObject.Instantiate<GameObject>(robotPrefab2);   
                switched = false;
                break;
        }
    }
}
