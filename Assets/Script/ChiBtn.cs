using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChiBtn : MonoBehaviour
{
    [SerializeField]
    Image image1;
    [SerializeField]
    Image image2;

    int[] idlist = new int[3];
    int[] indexlist = new int[2];
    public void SetButton(int p1, int p2, int num)
    {
        //int num1 = GameManager.Instance.baePeaManager.me.sonpea[p1];
        //int num2 = GameManager.Instance.baePeaManager.me.sonpea[p2];
        //image1.sprite = Resources.Load<Sprite>("image/" + num1);
        //image2.sprite = Resources.Load<Sprite>("image/" + num2);
        //idlist[0] = num2;
        //idlist[1] = num1;
        //idlist[2] = num;
        //indexlist[0] = p1;
        //indexlist[1] = p2;
    }

    public void OnclickBtn()
    {
        //Jaksadata jaksa = GameManager.Instance.baePeaManager.me;
        //GameManager.Instance.baePeaManager.isHuroberim = true;
        //GameManager.Instance.baePeaManager.HuroAddition(jaksa, idlist, indexlist, 2);
        //GameManager.Instance.baePeaManager.huroCheckObj.Close();
        //GameManager.Instance.baePeaManager.ChangeToMyTurn(false);

    }
}
