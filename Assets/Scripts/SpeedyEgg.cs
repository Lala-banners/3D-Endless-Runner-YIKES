using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EggRunner.Lara
{
    public class SpeedyEgg : MonoBehaviour
    {
        //To make egg roll down hill faster

        public GameObject player;

        public float acceleration = 1.0f;
        public float maxSpeed = 40.0f;

        private float currentSpeed = 0.0f;

        // Update is called once per frame
        void Update()
        {
            //transform.Translate(Vector3.MoveTowards(player.transform.position, ) * currentSpeed * Time.deltaTime);

            currentSpeed += acceleration * Time.deltaTime;

            if (currentSpeed > maxSpeed)
            {
                currentSpeed = maxSpeed;
            }
        }
    }
}
