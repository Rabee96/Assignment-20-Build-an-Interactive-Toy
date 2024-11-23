using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
public class Cannon : MonoBehaviour
     {         
          float pCannonX = 0f;
          float pCannonY = 2.1f;
          float pCannonZ = 0f;
          float pCannonDirection = 0f;
          float direction = 0f;
          // Start is called before the first frame update
          void Start()
          {
          }

          // Update is called once per frame
          void Update()
          {
               CannonMovement(); 
               transform.position = new Vector3(pCannonX,pCannonY,pCannonZ);
          }

          void CannonMovement(){
               direction = transform.eulerAngles.y*Mathf.PI/180f;
               if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                    {
                         pCannonDirection += 0.5f;
                         transform.rotation = Quaternion.Euler(new Vector3(0f,pCannonDirection,0f));
                    }
                    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                    {            
                         pCannonDirection -= 0.5f;
                         transform.rotation = Quaternion.Euler(new Vector3(0f,pCannonDirection,0f));
                    }
                    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                    {
                         pCannonX += Mathf.Sin(direction)*0.1f;
                         pCannonZ += Mathf.Cos(direction)* 0.1f;
                    }
                    if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                    {
                         pCannonX -= Mathf.Sin(direction)*0.1f;
                         pCannonZ -= Mathf.Cos(direction)* 0.1f;
                    }
          }
     }
}

