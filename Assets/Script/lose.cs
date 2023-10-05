using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class lose : MonoBehaviour
{
    public GameObject circle_ball;
    public GameObject diamond_ball;
    public GameObject star_ball;
    public GameObject tlog_ball;

    public GameObject lose1;
    public Vector2 b_again;
    public Vector2 b_main;
    public Vector2 text_lose;
    public Button again1;
    public Button main1;
    public GameObject text;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (newball.Instance.a == 1)
        {
            if (-5 > circle_ball.transform.position.y)
            {
                lose1.SetActive(true);
                again1.transform.DOMove(b_again,0.7f);
                main1.transform.DOMove(b_main, 0.7f);
                text.transform.DOMove(text_lose, 0.7f);
            }

        }
        else if (newball.Instance.a == 2)
        {
            if (-5 > diamond_ball.transform.position.y)
            {
                lose1.SetActive(true);
                lose1.SetActive(true);
                again1.transform.DOMove(b_again, 0.7f);
                main1.transform.DOMove(b_main, 0.7f);
                text.transform.DOMove(text_lose, 0.7f);
            }
        }
        else if (newball.Instance.a == 3)
        {
            if (-5> star_ball.transform.position.y)
            {
                lose1.SetActive(true);
                lose1.SetActive(true);
                again1.transform.DOMove(b_again, 0.7f);
                main1.transform.DOMove(b_main, 0.7f);
                text.transform.DOMove(text_lose, 0.7f);
            }
        }
        else if (newball.Instance.a == 4)
        {
            if (-5 > tlog_ball.transform.position.y)
            {
                lose1.SetActive(true);
                lose1.SetActive(true);
                again1.transform.DOMove(b_again, 0.7f);
                main1.transform.DOMove(b_main, 0.7f);
                text.transform.DOMove(text_lose, 0.7f);
            }
        }

    }
}
