using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int loops = 10;
    public float angle;
    public float a = 16f;
    public float n = 10;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<loops;i++)
        {
            for(int j=0;j<n;++j)
            {
                angle = Mathf.PI * 2f * j / n;
                GameObject.Instantiate(prefab, new Vector3(a*Mathf.Cos(angle), a*Mathf.Sin(angle), 0f), Quaternion.identity);
            }
            a -= 2.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
