using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Girls : MonoBehaviour
{
    public NPC_Movement movement;
    public SO_NPC_Girls SOGirls;
    public AttackComponent attackComponent;
    public Transform ShotPos;

    private void Init()
    {
        //love.setLP(SOBoys.LovePoint);
        movement.SetSpeedMovement(SOGirls.Speed);
    }


    private void Start()
    {
        Init();
        attackComponent.Setup(SOGirls.LoveDmg, SOGirls.CoolDown, SOGirls.RangeAttack, ShotPos);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(ShotPos.position, SOGirls.RangeAttack);
    }

}
