using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_ : MonoBehaviour
{
    int a=0;
    public GameObject quad1;
    public GameObject quad2;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void switch1()
    {
        if (a == 0)
        {
            quad1.SetActive(false);
            quad2.SetActive(true);
            a = 1;
        }
        else
        {
           
            quad1.SetActive(true);
            quad2.SetActive(false);
            a = 0;
        }
    }
}
