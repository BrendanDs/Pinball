using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class Controls : MonoBehaviour
{
    [SerializeField] InputAction useLeft;
    [SerializeField] InputAction useRight;
    [SerializeField] InputAction pullPlunger;
    // Start is called before the first frame update
    private void OnEnable()
    {
        useLeft.Enabled();
        useRight.Enabled();
        pullPlunger.Enabled();
    }
    private void OnDisable()
    {
        useLeft.Disabled();
        useRight.Disabled();
        pullPlunger.Disabled();
    }

    // Update is called once per frame
    void Update()
    {
        leftPaddle.Flip(useLeft.IsPressed());
        rightPaddle.Flip(useRight.IsPressed());
        plunger.Pull(pullPlunger.IsPressed());
        
    }
}
