using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackComponent : MonoBehaviour
{
    public float LoveDmg;
    public float CoolDown;
    //public float SpeedAttack;
    public float RangeAttack;
    public GameObject NPC_Beam;
    private Transform ShotPos;
    private Transform boy;

    private float timeshoot = 0;
    

    public void Setup(float LoveDmg, float CoolDown, float RangeAttack, Transform ShotPos)
    {
        this.LoveDmg = LoveDmg;
        this.CoolDown = CoolDown;
        this.RangeAttack = RangeAttack;
        this.ShotPos = ShotPos;
    }

    public void SetTarget(Transform target)
    {
        this.boy = target;
    }

    private void Update()
    {
        if (boy == null) return;
        timeshoot += Time.deltaTime;
        if (timeshoot > CoolDown)
        {
            timeshoot = 0;
            spawnBeam();
        }
    }

    private void spawnBeam()
    {
        var npc_Beam = Instantiate(NPC_Beam);
        npc_Beam.transform.position = ShotPos.position;
        Vector3 direction = (boy.position - ShotPos.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        npc_Beam.transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
