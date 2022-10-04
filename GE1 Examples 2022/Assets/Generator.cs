using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour 
{
    int loops = 20;
    int n = 0;
    float r,c;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start() 
    {
        while(r >= 0) 
        {
            loops--;
            r = loops/2;
            c = 2*Mathf.PI*r;
            n = (int)(c/(2/2));
            float side = 2*r*Mathf.Sin(Mathf.PI/n);

            while(n>1 && side<2/2) 
            {
                n = n - 1;
            }

            for (int i=0;i<n;++i)
            {
                float angle = Mathf.PI*2f*i/n;
                GameObject.Instantiate(prefab, new Vector3(r*Mathf.Cos(angle), r*Mathf.Sin(angle), 0f), Quaternion.identity);
            }
            r = r - 1;
        }
    }
    // Update is called once per frame
    void Update() {

    }
}
