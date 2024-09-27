using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class MeleeConditionNode : DecoratorNode
{
    public BossControls bossControls;
    protected override void OnStart() {
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        float distance = Vector2.Distance(bossControls.transform.position, bossControls.player.position);
        
        if(distance < 3) {
            return State.Success;
        }else
            return State.Failure;
    }
}
