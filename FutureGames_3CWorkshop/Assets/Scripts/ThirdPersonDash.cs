using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonDash : MonoBehaviour
{
   PlayerMovementController moveScript;

    public float dashSpeed;
    public float dashTime;
    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<PlayerMovementController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Fire2"))
        {
            StartCoroutine(Dash());
        }


    }

    IEnumerator Dash()
    {
        float startTime = Time.time;

        while (Time.time < startTime + dashTime)
        {
            transform.Translate(playerBody.right * dashSpeed);

            yield return null;
        }
    }
}
