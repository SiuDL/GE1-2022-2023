using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int loops = 10;
    public float r, c;
    public int n = 0;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        while(r > 0)
        {
            loops--;
            r = loops/2;
            c = 2*Mathf.PI*r;
            n = (int)(c/(2*0.5));
            float sin = 2*r*Mathf.Sin(Mathf.PI/n);
            for(int i=0;i<n;++i)
            {
                float angle = Mathf.PI * 2f * (i / n);
                GameObject.Instantiate(prefab, new Vector3(r*Mathf.Cos(angle), r*Mathf.Sin(angle), 0f), Quaternion.identity);
            }
            r--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
