using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newball : MonoBehaviour
{
    public int a=0;
    public static newball Instance;

    public void Awake()
    {
        Instance = this;
    }


    public void circle_ball()
    {
        a = 1;
        
    }

    public void diamond_ball()
    {
        a = 2;
        
    }

    public void star_ball()
    {
        a = 3;
        
    }

    public void tlog_ball()
    {
        a = 4;
       
    }

    public void menu()
    {
        SceneManager.LoadScene(1);

    }

}
