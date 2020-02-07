using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class RollerAgent : Agent
{
    // Start is called before the first frame update
   
    
        Rigidbody rBody;
        void Start () {
            rBody = GetComponent<Rigidbody>();
        }
        
        public Transform Target;
        public override void AgentReset()
        {
            if (this.transform.position.y < 0)
            {
                this.rBody.angularVelocity = Vector3.zero;
                this.rBody.Velocity = Vector3.zero;
                this.transform.position = new Vector3(0,0.5f,0);
            }

            Target.position = new Vector3(Random.value * 8 - 4,
            0.5f,
            Random.value * 8 - 4);
        }
    }

    // Update is called once per frame
    
public override void CollectObservations()
{
    AddVectorObs(Target.position);
    AddVectorObs(this.transform.position);

    AddVectorObs(rBody.Velocity.x);
    AddVectorObs(rBody.Velocity.z);
}

public float speed = 10;
 public override void AgentAction(float[] vectorAction)
    {
        //Actions, size = 2
        Vector3 controSignal = Vector3.zero;
        controSignal.x = vectorAction[0];
        controSignal.z = vectorAction[1];
        rBody.AddForce(controSignal * speed);

        //Rewards
        float distanceTotarget = Vector3.Distance(this.transform.position,Target.position);

        // Reached target
        if (distanceTotarget < 1.42f)

        {
            setReward(1.0f);
            Done();
        }

        //Fell off platform
        if (this.transform.position.y < 0)
        {
            Done();
        }
    }

public override float[] Heuristic()
{
    var action = new float[2];
    action[0] = Input.GetAxis("Horizontal");
    action[1] = Input.GetAxis("Vertical");
    return action;
}

