using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadakMtile : Mtile
{
    [SerializeField]
    public MeshRenderer meshrenderer;

    public bool isHover;

    [SerializeField]
    MeshRenderer twincle;
    void Start()
    {

    }

    public override void SetMtile(int mtileid)
    {
        meshrenderer.material.mainTexture = Resources.Load<Texture2D>("image/" + mtileid);
    }

    public override void SetPosition(int positionindex)
    {
        float scalex = transform.localScale.x;
        float scaley = transform.localScale.y;
        int posx = positionindex % 6;
        int posy = positionindex / 6;
        transform.localPosition = new Vector3(posx * scalex, -posy * scaley * 1.4f, 0);
    }
    public override void UpdateDoralight(bool isdora)
    {
        twincle.gameObject.SetActive(isdora);
        if (isdora)
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
        if (!meshrenderer) return;
        if (isHover)
        {
            meshrenderer.material.color = bluehovercolor;
        }
        else
        {
            meshrenderer.material.color = new Color32(231, 231, 231, 255);
        }
    }

}
