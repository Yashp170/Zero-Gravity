using BNG;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
public class TrigerPush : MonoBehaviour
{
    public InputActionProperty Rightt;
    public InputActionProperty Leftt;
    public HandController handController;
    public RotateObj rotateObj;


    void Start()
    {
        Rightt.action.Enable();
        Leftt.action.Enable();
    }
    void Update()
    {
        float LeftTriger = Leftt.action.ReadValue<float>();
        float RightTriger = Rightt.action.ReadValue<float>();

        if(LeftTriger==0)
        {
            rotateObj.speed = 0;
        }
        if(LeftTriger == 1)
        {
            rotateObj.speed = 1;
        }
    }
    
  
}



