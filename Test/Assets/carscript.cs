using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class carscript : MonoBehaviour
{
    Vector3 velocity, acceleration;
    float rotationSpeed = 180, thrust = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Space))

        {
            acceleration = thrust * transform.forward;
        }



        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Rotate(new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Rotate(new Vector3(0, 1, 0), -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {

            acceleration = thrust * transform.right;
        }

      





        if (Input.GetKey(KeyCode.UpArrow))

            {
                transform.Rotate(new Vector3(1, 0, 0), rotationSpeed * Time.deltaTime);
            }



            velocity += acceleration * Time.deltaTime;

            transform.position += velocity * Time.deltaTime;



        

    }
}
