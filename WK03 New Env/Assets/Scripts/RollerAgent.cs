using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class RollerAgent : Agent
{
    Rigidbody rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    public Transform Target;
    public override void AgentReset()
    {
        if (this.transform.position.y < 0) {
            //ถ้าตัว Agent ร่วงคือ y ต่ำกว่า 1
            this.rBody.angularVelocity = Vector3.zero;
            this.rBody.velocity = Vector3.zero;
            this.transform.position = new Vector3(0,0.5f,0);
        }

        Target.position = new Vector3(Random.value * 8-4,0.5f,Random.value * 8-4);
    }

    public override void CollectObservations()
    {
        //Target and Agent position
        AddVectorObs(Target.position);
        AddVectorObs(this.transform.position);

        //Agent Velocity
        AddVectorObs(rBody.velocity.x);
        AddVectorObs(rBody.velocity.y);

    }

    public float speed = 10;
    public override void AgentAction(float[] vectorAction)
    {
        //Action, size = 2
        Vector3 ControlSignal = Vector3.zero;
        ControlSignal.x = vectorAction[0];
        ControlSignal.y = vectorAction[1];
        rBody.AddForce(ControlSignal * speed);

        //Reward
        float distanceToTarget = Vector3.Distance(this.transform.position, Target.position);

        //Reached Target
        if (distanceToTarget < 1.42f) {
            SetReward(1.0f);
            Done();
        }

        //Fell of Plateform
        if (this.transform.position.y < 0) {
            Done();
        }

    }

    void Update()
    {
        
    }
}
