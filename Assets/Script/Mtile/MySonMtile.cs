using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySonMtile : Mtile
{
    [SerializeField]
    Image image;
    [SerializeField]
    Button button;
    //material 복사 생성 해야할 듯. 안그러면 모든 tile에 다 적용되어버림.
    //[SerializeField]
    //Material doraMaterial;
    [SerializeField]
    Image twincle;


    public int currentMtileid;
    public int currentindex;

    bool isHover;
    bool isClick;


    Vector2 defaultpos;

    void Start()
    {
        button.onClick.AddListener(ButtonOnclicked);
        transform.name = currentMtileid + "";
        //if (currentMtileid == 10 || currentMtileid == 55 || currentMtileid == 155 || currentMtileid == 255)
        //{
        //    isDora = true;

        //}
        defaultpos = image.transform.position;
    }

    private void ButtonOnclicked()
    {

        //Jaksadata js = GameManager.Instance.baePeaManager.me;
        //GameManager.Instance.baePeaManager.Beorim(js, currentMtileid, currentindex);
    }

    public override void SetMtile(int peaid, int index)
    {
        image.sprite = Resources.Load<Sprite>("image/" + peaid);
        currentMtileid = peaid;
        currentindex = index;
        transform.name = peaid + "";
    }

    public override void SetPosition(float positionindex)
    {
        float width = image.rectTransform.rect.width;
        transform.localPosition = new Vector3(positionindex * width, 0, 0);

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

    public void OnHover()
    {
        //GameManager.Instance.EffectManager.MtileHover(currentMtileid, true);
        image.transform.position = new Vector3(image.transform.position.x, defaultpos.y + 50, image.transform.position.y);
    }

    public void OutHover()
    {
        //if (GameManager.Instance)
        //{

        //    GameManager.Instance.EffectManager.MtileHover(currentMtileid, false);
        //    image.transform.position = new Vector3(image.transform.position.x, defaultpos.y, image.transform.position.y);
        //}
    }

    public void OnDisable()
    {
        OutHover();
    }

    public override void SetHover(bool isHover)
    {
        
    }
}
