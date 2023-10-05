using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back_mover_menu : MonoBehaviour
{
    public Renderer render;
    public float move_speed;


    void Update()
    {
        var move_pos = render.material.mainTextureOffset;
        move_pos.y += move_speed;
        render.material.mainTextureOffset = move_pos;
    }
}
