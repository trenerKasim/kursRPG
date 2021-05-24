using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
	[SerializeField]
	private Transform target;
	public Transform Target
	{
		get { return target; }
		set { target = value; }
	}
	
    // Update is called once per frame
    void Update()
    {
		GetComponent<NavMeshAgent>().destination = target.position;
    }
}
