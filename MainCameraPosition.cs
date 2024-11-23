using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts{
public class MainCameraPosition : MonoBehaviour
    {
        private Vector3 pCamera = new (0.1f,3f,-3.3f);
        private int pToggle = 1;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        { 
            if (Input.GetKeyDown(KeyCode.V))
            {
                if (pToggle == 1)
                {
                    pCamera = new Vector3(-0.1f,5.8f,-10f);
                    pToggle = 2;
                }else if (pToggle == 2)
                {   
                    pCamera = new Vector3(0f,3.8f,9.6f);
                    pToggle = 0;
                }else
                {
                    pCamera = new (0.1f,5f,-3.3f);
                    pToggle = 1;
                }
            }
            transform.position = pCamera;
        }
    }

    
}
