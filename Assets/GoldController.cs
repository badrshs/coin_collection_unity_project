using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldController : MonoBehaviour
{

    private Explodable _explodable;

    void Start ()
    {
        _explodable = GetComponent<Explodable>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("player"))
        {


            _explodable.explode();

        }



    }

}
