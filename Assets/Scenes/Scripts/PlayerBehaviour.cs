using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PaddleBehaviour leftPaddle;
    [SerializeField] PaddleBehaviour rightPaddle;
    //PaddleBehaviour plunger;

     [SerializeField] InputAction pullPlunger;
     [SerializeField] InputAction useA;
     [SerializeField] InputAction useD;
    

    void Update()
    {
        leftPaddle.Flip(useA.IsPressed());
        rightPaddle.Flip(useD.IsPressed());
       // plunger.Pull(pullPlunger.ReadValue<float>());
    }

    private void OnEnable()
    {
        useA.Enable();
        useD.Enable();
        pullPlunger.Enable();
    }
    private void OnDisable()
    {
        useA.Disable();
        useD.Disable();
        pullPlunger.Disable();
    }

}
