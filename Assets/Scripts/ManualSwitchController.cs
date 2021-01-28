using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ManualSwitchController : MonoBehaviour
{ 
    private bool switchOff = true;
    private bool switchEnabled = false;

    private Animator switchAnimator;

    void Awake()
    {
        switchAnimator = gameObject.GetComponent<Animator>();
        turnOff();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            toggleSwitch();
        }
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

    public void enableSwitch()
    {
        switchEnabled = true;
    }

    public void disableSwitch()
    {
        switchEnabled = false;
    }

    public void toggleSwitch()
    {
        if (switchEnabled == true)
        {
            switchOff = !switchOff;
            switchAnimator.SetBool("SwitchOff", switchOff);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        this.enableSwitch();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        this.disableSwitch();
    }

}
