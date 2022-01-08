using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    [SerializeField]
    SweatsManager sweats;

    [SerializeField]
    Animator animator;

    bool isWin = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetIsWin(bool w)
    {
        isWin = w;
    }

    public void SetButtonAnim(int i)
    {
        animator.SetInteger("button", i);
    }

    private void OnMouseDown()
    {
        animator.SetBool("pressed", true);
        sweats.CheckCondition(isWin);
    }
}
