using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offbutton : MonoBehaviour
{
        private bool switchOff = true;
        public LevelManager LevelManager;
        void Awake()
        {
            turnOff();
        }

        public void turnOn()
        {
            switchOff = false;
            LevelManager.HingeOn();
        }

        public void turnOff()
        {
            switchOff = true;
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            this.turnOn();
        }

        void OnTriggerExit2D(Collider2D other)
        {
            this.turnOff();
        }
    
}
