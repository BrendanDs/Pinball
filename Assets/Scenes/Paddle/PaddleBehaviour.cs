/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PaddleBehaviour : MonoBehaviour
{
    [SerializeField] InputAction pullPlunger;
    [SerializeField] InputAction leftPaddle;
    [SerializeField] InputAction rightPaddle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftPaddle.Flip(useLeft.IsPressed());
        rightPaddle.Flip(useRight.IsPressed());
        pullPlunger.Pull(pullPlunger.IsPressed());
    }
    
    private void OnEnable()
    {
        useLeft.Enable();
        useRight.Enable();
        pullPlunger.Enable();
    }
    private void OnDisable ()
    {
        useLeft.Disable();
        useRight.Disable();
        pullPlunger.Disable();
    }
       
}
*/