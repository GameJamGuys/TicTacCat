using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurseSkill : BaseSkill
{

    public override void UseSkill()
    {
        base.UseSkill();
        PlayerLogic.Instance.SetCurse();
    }
}
