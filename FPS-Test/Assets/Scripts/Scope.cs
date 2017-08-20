using UnityEngine;

public class Scope : MonoBehaviour {

    public Animator animator;
    private bool isScoped = false;
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            isScoped = !isScoped;
            animator.SetBool("ScopeB", isScoped);         
        }
	}
}
