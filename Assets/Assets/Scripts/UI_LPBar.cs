using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_LPBar : MonoBehaviour
{
    public Image LPmain;

    public void UpdateLP(float percent)
    {
        LPmain.fillAmount = percent;
    }
}
