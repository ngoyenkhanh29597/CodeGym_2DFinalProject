using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LovePointComponent : MonoBehaviour
{
    public float LPorigin;
    public float LP;
    public UI_LPBar LPbar;

    public void setLP(float lp)
    {
        this.LPorigin = lp;
        this.LP = lp;
    }

    public void increaseLP(float lp)
    {
        this.LP += lp;
    }

    public void takeLoveDmg(float loveDmg)
    {
        this.LP -= loveDmg;
        if (this.LP <= 0)
        {
            this.LP = 0;
            return;
        }
        float percent = LP/LPorigin;
        LPbar.UpdateLP(percent);
    }

    public bool isFlirted()
    {
        return LP <= 0;
    }
}
