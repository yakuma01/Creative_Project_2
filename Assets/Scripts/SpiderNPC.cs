using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderNPC : MonoBehaviour
{
    bool flag = true;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Run());
    }

    IEnumerator Run()
    {
        var x = transform.position;
        if (flag == true)
        {
            if (gameObject.CompareTag("pat1"))
            {
                x.z -= 4;
            }
            if (gameObject.CompareTag("pat2"))
            {
                x.z += 4;
            }
            if (gameObject.CompareTag("pat3"))
            {
                x.z += 3;
            }
            if (gameObject.CompareTag("pat4"))
            {
                x.z -= 3;
            }
            agent.SetDestination(x);
            flag = false;
        }
        yield return new WaitForSeconds(2);
        
        if (flag == false)
        {
            if (gameObject.CompareTag("pat1"))
            {
                x.z += 4;
            }
            if (gameObject.CompareTag("pat2"))
            {
                x.z -= 4;
            }
            if (gameObject.CompareTag("pat3"))
            {
                x.z -= 3;
            }
            if (gameObject.CompareTag("pat4"))
            {
                x.z += 3;
            }
            agent.SetDestination(x);
            flag = true;
        }
        yield return new WaitForSeconds(2);
        StartCoroutine(Run());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
