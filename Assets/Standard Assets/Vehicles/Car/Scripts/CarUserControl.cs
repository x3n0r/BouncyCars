using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            if (gameObject.transform.name == "Player1")
            {
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
                float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
                float handbrake = CrossPlatformInputManager.GetAxis("Jump");
                m_Car.Move(h, v, v, handbrake);
#else
                m_Car.Move(h, v, v, 0f);
#endif
            }
            else if (gameObject.transform.name == "Player2")
            {
                float h = CrossPlatformInputManager.GetAxis("Horizontal_P2");
                float v = CrossPlatformInputManager.GetAxis("Vertical_P2");
#if !MOBILE_INPUT
                float handbrake = CrossPlatformInputManager.GetAxis("Jump_P2");
                m_Car.Move(h, v, v, handbrake);
#else
                m_Car.Move(h, v, v, 0f);
#endif
            }
        }
    }
}
