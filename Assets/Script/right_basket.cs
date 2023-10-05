using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class right_basket : MonoBehaviour
{
   
    public bool ischeck=false;
   
    int a = 1;
    public GameObject pos_buttom_basket_right;
    public GameObject pos_top_basket_left;
    public GameObject pos_buttom_ball_right;
    public GameObject left_basket;

    public GameObject circle_ball;
    public GameObject diamond_ball;
    public GameObject star_ball;
    public GameObject tlog_ball;
    public Renderer render;
    public float move_speed;

    public Rigidbody2D circle_ball1;
    public Rigidbody2D diamond_ball1;
    public Rigidbody2D star_ball1;
    public Rigidbody2D tlog_ball1;

    float start;
    float end;
    float start2;
    float end2;

    void Start()
    {
        
    }

   
    void Update()
    {
        

        if (this.transform.position.x == pos_buttom_basket_right.transform.position.x)
        {
            ischeck = true;
        }
        else
        {
            ischeck = false;
        }

        if (ischeck == true)
        {
            x();
            y();
        }   
        

    }
    public void x()
    {
        if (Input.GetMouseButtonDown(0))
        {
            start = Input.mousePosition.x;
        }
        if (Input.GetMouseButtonUp(0))
        {
            end = Input.mousePosition.x;
            if (Mathf.Abs(start - end) > 5)
            {
                if (start > end)
                {
                    transform.Rotate(new Vector3(0, 0, 10));

                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, -10));

                }
            }
            else
            {

                return;
            }
        }
    }
    public void y()
    {
        if (Input.GetMouseButtonDown(1))
        {
            start2 = Input.mousePosition.y;
        }
        if (Input.GetMouseButtonUp(1))
        {
            end2 = Input.mousePosition.y;
            if (Mathf.Abs(start2 - end2) > 5)
            {
                if (start2 > end2)
                {
                    transform.localScale = new Vector3(transform.localScale.x, -1, transform.localScale.z);

                }
                else
                {

                    transform.localScale = new Vector3(transform.localScale.x, 1, transform.localScale.z);
                    var pos_back = render.material.mainTextureOffset;
                    pos_back.y += move_speed;
                    render.material.mainTextureOffset = pos_back;
                    if (newball.Instance.a == 1)
                    {
                        circle_ball1.AddForce(new Vector2(-0.2f, 1) * 11, ForceMode2D.Impulse);

                    }
                    else if (newball.Instance.a == 2)
                    {
                        diamond_ball1.AddForce(new Vector2(-0.2f, 1) * 11, ForceMode2D.Impulse);

                    }
                    else if (newball.Instance.a == 3)
                    {

                        star_ball1.AddForce(new Vector2(-0.2f, 1) * 11, ForceMode2D.Impulse);


                    }
                    else if (newball.Instance.a == 4)
                    {

                        tlog_ball1.AddForce(new Vector2(-0.2f, 1) * 11, ForceMode2D.Impulse);

                    }

                }


            }
            else
            {

                return;
            }
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {


           
            
                transform.position = new Vector3(pos_buttom_basket_right.transform.position.x, pos_buttom_basket_right.transform.position.y, pos_buttom_basket_right.transform.position.z);
                transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

                


                if (newball.Instance.a == 1)
                {
                    circle_ball.transform.position = new Vector3(pos_buttom_ball_right.transform.position.x, pos_buttom_ball_right.transform.position.y, pos_buttom_ball_right.transform.position.z);
                }
                else if (newball.Instance.a == 2)
                {
                    diamond_ball.transform.position = new Vector3(pos_buttom_ball_right.transform.position.x, pos_buttom_ball_right.transform.position.y, pos_buttom_ball_right.transform.position.z);
                }
                else if (newball.Instance.a == 3)
                {
                    star_ball.transform.position = new Vector3(pos_buttom_ball_right.transform.position.x, pos_buttom_ball_right.transform.position.y, pos_buttom_ball_right.transform.position.z);
                }
                else if (newball.Instance.a == 4)
                {
                    tlog_ball.transform.position = new Vector3(pos_buttom_ball_right.transform.position.x, pos_buttom_ball_right.transform.position.y, pos_buttom_ball_right.transform.position.z);
                }

                left_basket.transform.position = new Vector3(pos_top_basket_left.transform.position.x, pos_top_basket_left.transform.position.y, pos_top_basket_left.transform.position.z);
                left_basket.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            

            

            

            
        }
           

        
        



    }
}
