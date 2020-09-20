using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class move : MonoBehaviour
{
    //public GameObject Dest;

    public Camera cam;
    private NavMeshAgent agent;

    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //agent.SetDestination(Dest.transform.position);

        anim = GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if(Physics.Raycast(ray,out Hit))
            {
                agent.SetDestination(Hit.point);
            }
                
        }

        if(agent.isOnOffMeshLink)
        {
            agent.CompleteOffMeshLink();
        }

        //判断是否正在移动
        if(agent.velocity.sqrMagnitude==0)
        {
            anim.CrossFade("stand");
        }
        else
        {
            anim.CrossFade("walk");
        }

    }



}
