using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoraUI : MonoBehaviour
{
    [SerializeField]
    List<FrontDoraMtile> frontDoraMtiles = new List<FrontDoraMtile>();

    public void SetDoraUI(int index)
    {
        //int mtileId = GameManager.Instance.baePeaManager.frontDoraPea[index];
        //frontDoraMtiles[index].SetMtile(mtileId);
        //GameManager.Instance.EffectManager.SetMTileSet(mtileId, frontDoraMtiles[index]);
     
    }
}
