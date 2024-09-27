using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class RangeConditionNode : DecoratorNode
{
    public Rigidbody2D player;

    protected override void OnStart() {
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        float distance = Vector2.Distance(transform.position, player.position);
        
        if( distance >= 3 && distance < 5) {
            return State.Success;
        }else
            return State.Failure;
    }
}
