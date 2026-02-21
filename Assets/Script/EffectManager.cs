using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTileSet
{
    public int num;
    public List<Mtile> mtiles;
}

public class EffectManager : MonoBehaviour
{
    public Material doraMaterial;

    public List<MTileSet> mtilesets = new List<MTileSet>();

    int[] jongryu = { 10, 20, 30, 40, 50, 60, 70, 80, 90,
                    110, 120, 130, 140, 150, 160, 170, 180, 190,
                    210, 220, 230, 240, 250, 260, 270, 280, 290,
                    310, 320, 330, 340, 350, 360, 370, 410
    };

    void Start()
    {

        StartCoroutine(UpdateDoralight());
    }

    public void Init()
    {
        for (int i = 0; i < jongryu.Length; i++)
        {
            MTileSet tileset = new MTileSet();
            tileset.num = jongryu[i];
            tileset.mtiles = new List<Mtile>();
            mtilesets.Add(tileset);
        }
    }

    public IEnumerator UpdateDoralight()
    {
        //doraMaterial = new Material(Shader.Find("UI/Unlit/Transparent"));
        //doraMaterial.mainTexture = Resources.Load<Sprite>("image/lightimage").texture;
        //twincle.material = doraMaterial;
        //Material doraMaterial = new Material(origin);
        while (true)
        {
            // --- [1단계] 0.5초 동안 (1, 0)에서 (0, 0)으로 이동 ---
            float elapsed1 = 0f;
            Vector2 startP1 = new Vector2(1.0f, 0.0f);
            Vector2 endP1 = new Vector2(0.0f, 0.0f);

            while (elapsed1 < 0.5f)
            {
                elapsed1 += Time.deltaTime;
                float progress = elapsed1 / 0.5f;
                doraMaterial.SetTextureOffset("_MainTex", Vector2.Lerp(startP1, endP1, progress));
                yield return null;
            }
            doraMaterial.SetTextureOffset("_MainTex", endP1);

            // --- [2단계] 0.5초 동안 (0, 0)에서 (0, 1)으로 이동 ---
            float elapsed2 = 0f;
            Vector2 startP2 = new Vector2(0.0f, 0.0f);
            Vector2 endP2 = new Vector2(0.0f, 1.0f);

            while (elapsed2 < 0.5f)
            {
                elapsed2 += Time.deltaTime;
                float progress = elapsed2 / 0.5f;
                doraMaterial.SetTextureOffset("_MainTex", Vector2.Lerp(startP2, endP2, progress));
                yield return null;
            }
            doraMaterial.SetTextureOffset("_MainTex", endP2);

            // --- [대기] 모든 변화가 끝난 후 2초간 정지 ---
            // 이 상태에서 Offset은 (0, 1)을 유지합니다.
            yield return new WaitForSeconds(2f);

            // 2초가 지나면 다시 while문의 처음으로 돌아가 (1, 0)부터 시작합니다.
        }
    }

    public void SetMTileSet(int mtileid, Mtile mtile)
    {
        if (mtileid == 55) mtileid = 50;
        if (mtileid == 155) mtileid = 150;
        if (mtileid == 255) mtileid = 250;
        if (mtileid >= 410) mtileid = 410;
        MTileSet targetSet = mtilesets.Find(set => set.num == mtileid);

        if (targetSet != null)
        {
            //Debug.Log(mtileid + ", " + targetSet.mtiles.Count);
            targetSet.mtiles.Add(mtile);
        }
    }
    public void RemoveMTileSet(int mtileid, Mtile mtile)
    {
        if (mtileid == 55) mtileid = 50;
        if (mtileid == 155) mtileid = 150;
        if (mtileid == 255) mtileid = 250;
        if (mtileid >= 410) mtileid = 410;
        MTileSet targetSet = mtilesets.Find(set => set.num == mtileid);
        if (targetSet != null)
        {
            targetSet.mtiles.Remove(mtile);
        }
    }

    public void MtileHover(int mtileId, bool isHover)
    {
        if (mtileId == 55) mtileId = 50;
        if (mtileId == 155) mtileId = 150;
        if (mtileId == 255) mtileId = 250;
        if (mtileId >= 410) mtileId = 410;
        MTileSet targetSet = mtilesets.Find(set => set.num == mtileId);
        if (targetSet != null)
        {
            for (int i = 0; i < targetSet.mtiles.Count; i++)
            {
                //Debug.Log(targetSet.num + targetSet.mtiles[i].transform.parent.name);
                targetSet.mtiles[i].SetHover(isHover);

            }
        }
    }

    public void SetNewDoraTwincle(int mtileid)
    {

    }

    public bool IsDoraNum(int num)
    {

        return false;
    }

    //꽃패는 -2, 도라번호가 아니면 -1
    public int GetDoranumFromDisplay(int num)
    {
        int[] fDras = { };// GameManager.Instance.baePeaManager.frontDoraPea;
        int result = -1;
        for (int i = 0; i < fDras.Length; i++)
        {
            if (fDras[i] <= 0) break;
            if (fDras[i] == num)
            {
                switch (num)
                {
                    //만수
                    case 10: result = 20; break;
                    case 20: result = 30; break;
                    case 30: result = 40; break;
                    case 40: result = 50; break;
                    case 50: result = 60; break;
                    case 55: result = 60; break;
                    case 60: result = 70; break;
                    case 70: result = 80; break;
                    case 80: result = 90; break;
                    case 90: result = 10; break;
                    // 통수
                    case 110: result = 120; break;
                    case 120: result = 130; break;
                    case 130: result = 140; break;
                    case 140: result = 150; break;
                    case 150: result = 160; break;
                    case 155: result = 160; break;
                    case 160: result = 170; break;
                    case 170: result = 180; break;
                    case 180: result = 190; break;
                    case 190: result = 110; break;
                    // 통수
                    case 210: result = 220; break;
                    case 220: result = 230; break;
                    case 230: result = 240; break;
                    case 240: result = 250; break;
                    case 250: result = 260; break;
                    case 255: result = 260; break;
                    case 260: result = 270; break;
                    case 270: result = 280; break;
                    case 280: result = 290; break;
                    case 290: result = 210; break;
                    //자패
                    case 310: result = 320; break;
                    case 320: result = 330; break;
                    case 330: result = 340; break;
                    case 340: result = 310; break;
                    case 350: result = 360; break;
                    case 360: result = 370; break;
                    case 370: result = 350; break;
                    //그외 꽃패
                    default: result = -2; break;
                }
            }
        }
        return result;
    }
}
