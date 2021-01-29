using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public PivotHingeController PivotHingeController;
    public onbutton onbutton;
    public offbutton offbutton;


    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;

    }

    public void HingeOn()
    {
        PivotHingeController.SetPivotHingeMotorSpeed(-10);
    }
    public void HingeOff()
    {
        PivotHingeController.SetPivotHingeMotorSpeed(10);
    }

}
