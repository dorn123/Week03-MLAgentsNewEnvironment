using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class RollerAcademy : Academy
{
    Rigidbody rBody;
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }
}

public Transform Target;
public override void AgentRest()
{
    if (this.transform.position.y < 0)
    {
        this.rBody.angularVelocity = Vector3.zero;
        this.rBody.velocity = Vctor3.zero;
        this.transform.position = new Vector3(0, 0.5f, 0);
    }

    Target.position = new Vector3(Random.value * 8 - 4,
                                    0.5f,
                                    Random.value * 8 - 4);
}

public override void CollectObservations()
{
    AddVectorObs(Target.position);
    AddVectorObs(this.transfrom.position);

    AddVectorObs(rBody.velocity.x);
    AddVectorObs(rBody.velocity.z);
}

public float speed = 10;
public override void AgentAction(float[] vectorAction)
{
    Vector3 controlSignal = Vector3.zero;
    controlSignal.x = vectorAction[0];
    controlSignal.z = vectorAction[1];
    rBody.AddForce(controlSignal * Speed);

    float distanceToTarget = Vector3.Distance(this.transform.position, Target.position);

    if(distanceToTarget < 1.42f)
    {
        setReward(1.0f);
        Done();
    }

    if(this.transform.position.y < 0)
    {
        Done();
    }
}
