using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("TriggerChecker : OnTriggerEnterが呼ばれた");
	}
}