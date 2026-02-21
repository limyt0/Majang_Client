using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FrontDoraMtile : Mtile
{
    [SerializeField]
    Image image;
    void Start()
    {

    }
    public override void SetMtile(int mtileid)
    {
        image.sprite = Resources.Load<Sprite>("image/" + mtileid);
        transform.name = mtileid + "";
    }
    public override void SetHover(bool isHover)
    {
        //Debug.Log("ishover");
        if (isHover)
        {
            image.color = bluehovercolor;//Color.white;
        }
        else
        {
            image.color = new Color32(231, 231, 231, 255);
        }
    }
}
