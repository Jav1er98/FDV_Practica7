using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost_zone : MonoBehaviour
{
    public float boostzone;

    private void OnTriggerStay2D(Collider2D other)
    {
        other.GetComponent<Rigidbody2D>().AddForce(new Vector2(boostzone, 0f));

    }
}
