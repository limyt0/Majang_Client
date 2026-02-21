using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SangDaeSonMtile : Mtile
{
    [SerializeField]
    public MeshRenderer meshrenderer;
    int currentBlockid;
    int currentindex;

    public override void SetMtile(int peaid, int index)
    {
        meshrenderer.material.mainTexture = Resources.Load<Texture2D>("image/" + peaid);
        currentBlockid = peaid;
        currentindex = index;
    }

    public override void SetPosition(float positionindex)
    {
        float scalex = transform.localScale.x;
        transform.localPosition = new Vector3(scalex * positionindex, 0, 0);
    }
}
