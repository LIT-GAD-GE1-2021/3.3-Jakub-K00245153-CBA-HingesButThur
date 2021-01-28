using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutoSwitchController : MonoBehaviour
{
    private bool switchOff = true;
    private Animator switchAnimator;
    void Awake()
    {
        switchAnimator = gameObject.GetComponent<Animator>();
        turnOff();
    }

    public void turnOn()
    {
        switchOff = false;
        switchAnimator.SetBool("SwitchOff", switchOff);
    }

    public void turnOff()
    {
        switchOff = true;
        switchAnimator.SetBool("SwitchOff", switchOff);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Someone entered the switch trigger");

        this.turnOn();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Someone left the switch trigger");

        this.turnOff();
    }
}

