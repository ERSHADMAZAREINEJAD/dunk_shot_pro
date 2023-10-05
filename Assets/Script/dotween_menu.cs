using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class dotween_menu : MonoBehaviour
{
    public Button button;
    public Button button2;
    public GameObject tlog;
    public Vector3 pos_button;
    public Vector3 pos_tlog;
    public Vector3 pos_button2;

    void Start()
    {
        button.transform.DOMove(pos_button, 0.7f);
        button2.transform.DOMove(pos_button2, 0.7f);
        tlog.transform.DOMove(pos_tlog, 0.7f);

    }

    
    void Update()
    {
        
    }
}
