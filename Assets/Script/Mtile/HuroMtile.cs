using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuroMtile : Mtile
{
    [SerializeField]
    public MeshRenderer meshrenderer;
    [SerializeField]
    MeshRenderer twincle;
    void Start()
    {

    }

    public override void SetMtile(int mtileid)
    {
        meshrenderer.material.mainTexture = Resources.Load<Texture2D>("image/" + mtileid);
    }

    public override void SetPosition(float positionindex)
    {
        float scalex = transform.localScale.x;
        float posx = positionindex;
        transform.localPosition = new Vector3(posx * scalex, 0, 0);
    }

    public override void SetPosition(float positionindex, bool isrotation)
    {
        float scalex = transform.localScale.x;
        float scaley = transform.localScale.y;
        float posx = positionindex;
        if (isrotation)
        {
            transform.localEulerAngles = new Vector3(0, 0, 90);
            transform.localPosition = new Vector3((posx * scalex) - 0.05f, -scalex / 6, 0);
        }
        else
        {

            transform.localPosition = new Vector3(posx * scalex, 0, 0);
        }

    }

    public override void UpdateDoralight(bool isDora)
    {
        twincle.gameObject.SetActive(isDora);
        if (isDora)
        {
            //twincle.material = GameManager.Instance.EffectManager.doraMaterial;
        }
        else
        {
            twincle.material = null;
        }
       
    }

    public override void SetHover(bool isHover)
    {
        if (isHover)
        {
            meshrenderer.material.color = bluehovercolor;
        }
        else
        {
            meshrenderer.material.color = Color.white;
        }
    }
}
