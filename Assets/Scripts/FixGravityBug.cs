using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixGravityBug : MonoBehaviour
{
    public Transform cameraRig;
    public Transform trakingSpace;
    public float time=0.5f;
    Vector3 defaultPos;
    bool Istrue;
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        if(Istrue)
        {
           if (trakingSpace.localPosition == Vector3.zero) return;

            cameraRig.localPosition = new Vector3(0,defaultPos.y,0);
            //trakingSpace.localPosition = Vector3.zero;
            trakingSpace.localEulerAngles = new Vector3(0, trakingSpace.localEulerAngles.y, 0);
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(time);
        defaultPos = cameraRig.localPosition;
        Istrue = true;
    }
}
