using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAnimation : MonoBehaviour
{

    public InputActionAsset klarasPlayerAction;
    public Animator klarasAnimator;

    // Update is called once per frame
    void Update()
    {
        if (klarasPlayerAction.FindAction("Move").IsPressed())
        {
            klarasAnimator.SetBool("Run", true);
        }
        else
            klarasAnimator.SetBool("Run", false);
        
        if (klarasPlayerAction.FindAction("Jump").IsPressed())
        {
            klarasAnimator.SetBool("Jump", true);
        }
        else
            klarasAnimator.SetBool("Jump", false);
    }
}
