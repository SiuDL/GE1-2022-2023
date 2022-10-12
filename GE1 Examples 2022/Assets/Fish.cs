using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public Transform head;
    public Transform tail;
    public float freq = 0.5f;
    public float headAmp = 40;
    public float tailAmp = 60;

    public float theta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float headAngle = Mathf.Sin(theta) * headAmp;
        float taileAngle = Mathf.Sin(theta) * tailAmp;

        head.localRotation = Quaternion.AngleAxis(headAngle, Vector3.forward);
        tail.localRotation = Quaternion.AngleAxis(taileAngle, Vector3.forward);

        theta += freq * 2.0f * Mathf.PI * Time.deltaTime;
    }
}
