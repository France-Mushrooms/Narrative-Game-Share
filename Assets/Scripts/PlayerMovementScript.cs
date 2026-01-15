using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
      Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    Animator anim;

    public float runSpeed = 20.0f;

    void Start (){
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update ()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");



        if(horizontal != 0|| vertical !=0){
            anim.SetBool("isWalking", true);
            anim.SetFloat("animHorizontal", horizontal);
            anim.SetFloat("animVertical", vertical);
        }
        else {
           anim.SetBool("isWalking", false) ;
        }


    }

    void  FixedUpdate() {
        if (horizontal != 0 && vertical !=0)
        {
            horizontal *=moveLimiter;
            vertical *= moveLimiter;
        }

        body.linearVelocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

    }
    
    
}