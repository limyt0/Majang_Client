using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class HuroCheckUI : MonoBehaviour
{
    [SerializeField]
    Button ronbtn;
    [SerializeField]
    Button tsumobtn;
    [SerializeField]
    Button chibtn;
    [SerializeField]
    Button ponbtn;
    [SerializeField]
    Button mingkanbtn;
    [SerializeField]
    Button anKanBtn;
    [SerializeField]
    Button skipbtn;
    [SerializeField]
    Button skipmybtn;
    [SerializeField]
    Button chicancelBtn;
    [SerializeField]
    GameObject huroBtns;
    [SerializeField]
    GameObject ChiBtns;

    [SerializeField]
    List<ChiBtn> chibtnslist;
    void Start()
    {
        ponbtn.onClick.AddListener(OnclickPonButton);
        mingkanbtn.onClick.AddListener(OnclickMingKanButton);
        skipbtn.onClick.AddListener(OnclickSkipButtion);
        chibtn.onClick.AddListener(OnclickChiButton);
        chicancelBtn.onClick.AddListener(onclickChiCancelButton);
        anKanBtn.onClick.AddListener(OnClickAnkanButton);
    }

    private void OnClickAnkanButton()
    {
        //throw new NotImplementedException();
    }

    public void onclickChiCancelButton()
    {
        huroBtns.SetActive(true);
        ChiBtns.SetActive(false);
    }

    private void OnclickChiButton()
    {
        //chi_list chi_lists = GameManager.Instance.baePeaManager.chi_lists;
        //ResetChilistButtons(chi_lists);
        //int getcount = chi_lists.get_count();
        //int[] sonpae = GameManager.Instance.baePeaManager.me.sonpea;
        //int berinId = GameManager.Instance.baePeaManager.GetLastBeorinId();
        //if (getcount > 1)
        //{
        //    huroBtns.SetActive(false);
        //    ChiBtns.SetActive(true);
        //    for (int i = 0; i < chi_lists.get_count(); i++)
        //    {
        //        chibtnslist[i].gameObject.SetActive(true);
        //        int p1 = chi_lists.chilist[i][0];
        //        int p2 = chi_lists.chilist[i][1];
        //        chibtnslist[i].SetButton(p1, p2, berinId);
        //    }
        //}
        //else if (getcount == 1)
        //{
        //    Jaksadata jaksa = GameManager.Instance.baePeaManager.me;
        //    int[] indexlist = new int[2];
        //    indexlist[0] = chi_lists.chilist[0][0];
        //    indexlist[1] = chi_lists.chilist[0][1];

        //    int[] idlist = new int[3];
        //    idlist[0] = berinId;
        //    idlist[1] = sonpae[indexlist[0]];
        //    idlist[2] = sonpae[indexlist[1]];


        //    GameManager.Instance.baePeaManager.isHuroberim = true;
        //    GameManager.Instance.baePeaManager.HuroAddition(jaksa, idlist, indexlist, 2);
        //    GameManager.Instance.baePeaManager.huroCheckObj.onclickChiCancelButton();
        //    GameManager.Instance.baePeaManager.ChangeToMyTurn(false);
        //    Close();
        //}
        //else
        //{
        //    Close();
        //}
    }

    private void ResetChilistButtons() //(chi_list chi_lists)
    {
        for (int i = 0; i < 5; i++)
        {
            chibtnslist[i].gameObject.SetActive(false);
        }
    }

    private void OnclickPonButton()
    {

        //Jaksadata jaksa = GameManager.Instance.baePeaManager.me;
        //int berinId = GameManager.Instance.baePeaManager.GetLastBeorinId();
        //int[] idlist = new int[3];
        //for (int i = 0; i < 3; i++)
        //{
        //    idlist[i] = berinId;
        //}
        //int taganum = GameManager.Instance.baePeaManager.BerimTagaNumber();
        //int[] indexlist = GameManager.Instance.baePeaManager.ponkanlist.ToArray();
        //GameManager.Instance.baePeaManager.isHuroberim = true;
        //GameManager.Instance.baePeaManager.HuroAddition(jaksa, idlist, indexlist, taganum);
        //Close();
        //GameManager.Instance.baePeaManager.ChangeToMyTurn(false);
    }

    private void OnclickMingKanButton()
    {
        //Jaksadata jaksa = GameManager.Instance.baePeaManager.me;
        //int berinId = GameManager.Instance.baePeaManager.GetLastBeorinId();
        //int[] list = new int[4];
        //for (int i = 0; i < 4; i++)
        //{
        //    list[i] = berinId;
        //}
        //int taganum = GameManager.Instance.baePeaManager.BerimTagaNumber();
        //if (taganum != 0)
        //{
        //    taganum += 1;
        //}
        //int[] indexlist = GameManager.Instance.baePeaManager.ponkanlist.ToArray();
        //GameManager.Instance.baePeaManager.isYsberim = true;
        //GameManager.Instance.baePeaManager.HuroAddition(jaksa, list, indexlist, taganum);
        //Close();
        //GameManager.Instance.baePeaManager.ChangeToMyTurn(true);
    }
    private void OnclickSkipButtion()
    {
        Close();
        //Baram mextbaram = GameManager.Instance.baePeaManager.NextBaram();

        //GameManager.Instance.baePeaManager.TurnChange(mextbaram, true, false);
    }

    public void Close()
    {
        //GameManager.Instance.baePeaManager.HuroCoroutineStop();
        //gameObject.SetActive(false);
        //Baram baram = GameManager.Instance.baePeaManager.NextBaram();
        //GameManager.Instance.baePeaManager.TurnChange(baram, true, false);
    }

    public void SetActivePonbtn(bool isActive)
    {
        ponbtn.gameObject.SetActive(isActive);
    }
    public void SetActiveMingKanbtn(bool isActive)
    {
        mingkanbtn.gameObject.SetActive(isActive);
    }
    public void SetActiveChibtn(bool isActive)
    {
        chibtn.gameObject.SetActive(isActive);

    }

    public void SetActiveAnKanBtn(bool isActive)
    {
        anKanBtn.gameObject.SetActive(isActive);
    }

    private void OnDisable()
    {
        huroBtns.SetActive(true);
        ChiBtns.SetActive(false);
        for (int i = 0; i < chibtnslist.Count; i++)
        {
            chibtnslist[i].gameObject.SetActive(false);
        }
    }
}
