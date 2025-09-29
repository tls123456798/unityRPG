using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;

    Rigidbody2D rigid;
    float h;
    float v;
    bool isHorizonMove;

    Animator anim;
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        // Move Value
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        
        // Check Button Down & Up
        bool hDown = Input.GetButtonDown("Horizontal");
        bool vDown = Input.GetButtonDown("Vertical");
        bool hUp = Input.GetButtonUp("Horizontal");
        bool vUp = Input.GetButtonUp("Vertical");

        // Check Horizontal Move
        if (hDown || vUp)
            isHorizonMove = true;
        else if (vDown || hUp)
            isHorizonMove = false;

        if (anim.GetInteger("hAxisRaw") != h)
        {
            anim.SetBool("isChange", true);
            anim.SetInteger("hAxisRaw", (int)h);
        }
        else if (anim.GetInteger("vAxisRaw") != v)
        {
            anim.SetBool("isChange", true);
            anim.SetInteger("vAxisRaw", (int)v);
        }
        else
            anim.SetBool("isChange", false);
        
    }

    private void FixedUpdate()
    {
        Vector2 moveVec = isHorizonMove ? new Vector2(h,0) : new Vector2(0,v);
        rigid.linearVelocity = moveVec * Speed;
    }
}
