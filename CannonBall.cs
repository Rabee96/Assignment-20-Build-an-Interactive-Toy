using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    float pCannonBallX = 0f;
    readonly float pCannonBallY = 2.1f;
    float pCannonBallZ = 0f;
    bool fired = false;
    readonly float fireSpeed = 0.5f;
    float directionRad = 0f;
    float pCannonX = 0f;
    float pCannonZ = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        pCannonX = transform.parent.position.x;
        pCannonZ = transform.parent.position.z;
        if (Input.GetMouseButtonUp(0))
        {
            fired = true;
            directionRad = transform.parent.eulerAngles.y*Mathf.PI/180f;
            transform.position = new(pCannonX,pCannonBallY,pCannonZ);
        }
        
        if (fired)
        {
            pCannonBallX += Mathf.Sin(directionRad)*fireSpeed;
            pCannonBallZ += Mathf.Cos(directionRad)*fireSpeed;
            transform.position = new (pCannonBallX,2.1f,pCannonBallZ);
        }
        if (Mathf.Abs(transform.position.x) >= pCannonX+600f || Mathf.Abs(transform.position.z) >= pCannonZ+600f )
        {
            fired = false;
            pCannonBallX = pCannonX;
            pCannonBallZ = pCannonZ;
            transform.position = new(pCannonBallX,pCannonBallY,pCannonBallZ);
        }
    }
}
