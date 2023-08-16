using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Boys : MonoBehaviour
{
    public SO_NPC_Boys SOBoys;
    public LovePointComponent love;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        love.setLP(SOBoys.lovePoint);
    }

    public void TakeLove(float loveDmg)
    {
        love.takeLoveDmg(loveDmg);
        bool isFlirted = love.isFlirted();
        if (isFlirted == true)
        {
            Debug.Log("Fall in love");
            //Destroy(gameObject);
        }
    }
}
