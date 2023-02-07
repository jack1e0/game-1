using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public GameObject upPos;
    public GameObject downPos;
    public GameObject midPos;

    public float speed;

    private bool atMid;
    private bool atTop;
    private bool atBottom;

    void Start()
    {
        atMid = true;
        atTop = false;
        atBottom = false;
    }

    void Update()
    {
        mid();
        top();
        bottom();
    }

    private void mid()
    {
        if (atMid)
        {
            if (Input.GetKey("up"))
            {
                transform.position = Vector3.MoveTowards(transform.position, upPos.transform.position, speed * Time.deltaTime);

            }

            if (Input.GetKey("down"))
            {
                transform.position = Vector3.MoveTowards(transform.position, downPos.transform.position, speed * Time.deltaTime);

            }

            if (transform.position == upPos.transform.position)
            {
                atMid = false;
                atTop = true;
            }

            if (transform.position == downPos.transform.position)
            {
                atMid = false;
                atBottom = true;
            }
        }
        
    }

    private void top()
    {
        if (atTop)
        {
            if (Input.GetKey("down"))
            {
                transform.position = Vector3.MoveTowards(transform.position, downPos.transform.position, speed * Time.deltaTime);
                atMid = true;

            }
        }
        if (transform.position == midPos.transform.position)
        {
            atMid = true;
            atTop=false;
        }
    }

    private void bottom()
    {
        if (atBottom)
        {
            if (Input.GetKey("up"))
            {
                transform.position = Vector3.MoveTowards(transform.position, upPos.transform.position, speed * Time.deltaTime);
                atMid = true;

            }
        }
        if (transform.position == midPos.transform.position)
        {
            atMid = true;
            atBottom = false;
        }
    }


    /*
    Vector Lerp:

    public GameObject cam;
    private Vector3 midPos;
    private Vector3 upPos;
    private Vector3 downPos;

    private float distance = 11f;
    private float lerpTime = 2f;
    private float currLerpTime = 0;

    private bool keyHit = false;

    void Start()
    {
        midPos = cam.transform.position;
        upPos = cam.transform.position + Vector3.up * distance;
        downPos = cam.transform.position + Vector3.down * distance;
    }

    // Update is called once per frame
    void Update()
    {
        
            midToTop();
            midToDown();
        
        
        if (cam.transform.position == upPos)
        {
            topToMid();
        }

        if (cam.transform.position == downPos)
        {
            downToMid();
        }
    }

    private void midToTop()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            keyHit = true;
        }

        if (keyHit)
        {
            currLerpTime += Time.deltaTime;
            if (currLerpTime >= lerpTime)
            {
                currLerpTime = lerpTime;
            }

            float percentage = currLerpTime / lerpTime;
            cam.transform.position = Vector3.Lerp(midPos, upPos, percentage);

            //currLerpTime = 0;
        }
    }

    private void topToMid()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            keyHit = true;
        }

        if (keyHit)
        {
            currLerpTime += Time.deltaTime;
            if (currLerpTime >= lerpTime)
            {
                currLerpTime = lerpTime;
            }

            float percentage = currLerpTime / lerpTime;
            cam.transform.position = Vector3.Lerp(upPos, midPos, percentage);
        }
    }

    private void midToDown()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            keyHit = true;
        }

        if (keyHit)
        {
            currLerpTime += Time.deltaTime;
            if (currLerpTime >= lerpTime)
            {
                currLerpTime = lerpTime;
            }

            float percentage = currLerpTime / lerpTime;
            cam.transform.position = Vector3.Lerp(midPos, downPos, percentage);
        }
    }

    private void downToMid()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            keyHit = true;
        }

        if (keyHit)
        {
            currLerpTime += Time.deltaTime;
            if (currLerpTime >= lerpTime)
            {
                currLerpTime = lerpTime;
            }

            float percentage = currLerpTime / lerpTime;
            cam.transform.position = Vector3.Lerp(downPos, midPos, percentage);
        }
    }
    */
}
