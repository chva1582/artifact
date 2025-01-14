﻿using UnityEngine;
using System.Collections;

namespace Pong
{
	public class player : MonoBehaviour 
	{
		public GameObject scoreLeft, scoreRight;
		public Rigidbody body;
		public KeyCode up, down, left, right, spinR, spinL;
		public int lowerBoundY, upperBoundY;
		public int vertSpeed;
		public int latSpeed;
		scoreKeeper scoreScriptR, scoreScriptL;
		bool wait;
		
		void Start()
		{
			body = GetComponent<Rigidbody>();
			scoreScriptL = scoreLeft.GetComponent<scoreKeeper>();
			scoreScriptR = scoreRight.GetComponent<scoreKeeper>();
		}

		void Update () 
		{
			if(!scoreScriptL.resetBool && !scoreScriptR.resetBool)
			{
				if(transform.position.x >= lowerBoundY && transform.position.x <= upperBoundY)
				{
					if(Input.GetKey(left))
						body.AddForce(-latSpeed,0,0,ForceMode.Acceleration);

					if(Input.GetKey(right))
						body.AddForce(latSpeed,0,0,ForceMode.Acceleration);
				}

				else if(transform.position.x < lowerBoundY)
					body.AddForce(-5*(transform.position.x-lowerBoundY),0,0,ForceMode.Acceleration);

				else
					body.AddForce(-5*(transform.position.x-upperBoundY),0,0,ForceMode.Acceleration);

				if(Input.GetKey(up))
					body.AddForce(0,0,vertSpeed,ForceMode.Acceleration);

				if(Input.GetKey(down))
					body.AddForce(0,0,-vertSpeed,ForceMode.Acceleration);

				if(Input.GetKey(spinL))
				{
					if(body.angularVelocity.y >= 0 && wait != true)
						body.AddTorque(0,30,0);
					else
					{
						Vector3 zero = Vector3.zero;
						body.angularVelocity = zero;
						Wait();
					}
				}

				if(Input.GetKey(spinR))
				{
					if(body.angularVelocity.y <= 0 && wait != true)
						body.AddTorque(0,-30,0);
					else
					{
						Vector3 zero = Vector3.zero;
						body.angularVelocity = zero;
						Wait();
					}
				}
			}
		}

		IEnumerator Wait()
		{
			wait = true;
			yield return new WaitForSeconds(5);
			wait = false;
		}
	}
}