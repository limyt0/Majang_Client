using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mtile : MonoBehaviour
{
    private bool _isDora;

    public bool isDora
    {
        get => _isDora;
        set
        {
            // 값이 실제로 바뀔 때만 실행
            if (_isDora != value)
            {
                _isDora = value;
                //if (_isDora) 
                UpdateDoralight(_isDora);

            }
        }
    }

    protected Color32 bluehovercolor = new Color32(127, 127, 255, 255);
    public virtual void SetMtile(int peaid) { }

    public virtual void SetMtile(int peaid, int index = -1) { }
    public virtual void SetPosition(int positionindex) { }
    public virtual void SetPosition(float positionindex) { }
    public virtual void SetPosition(float positionindex, bool rotation) { }

    public virtual void UpdateDoralight(bool isDora) { }

    public virtual void SetHover(bool isHover) { }
}
