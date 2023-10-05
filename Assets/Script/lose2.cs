using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose2 : MonoBehaviour
{
    public void again()
    {
        SceneManager.LoadScene(2);
    }
    public void main()
    {
        SceneManager.LoadScene(0);
    }
}
