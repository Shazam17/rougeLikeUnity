using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public CharacterController2D characterController2D;
    public Animator animator;
    public InventoryScript inventoryScript;
    public float horizontalMove = 0.0f;
    public float runSpeed = 40.0f;
    private bool jump = false;


    [SerializeField]
    public int hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.transform.name);
        BonusScript bonusScript = collision.GetComponent<BonusScript>();
        if (bonusScript)
        {
            hp += bonusScript.hpBoost;
            bonusScript.collect();
        }

        itemScript item = collision.GetComponent<itemScript>();
        if(item)
        {
            item.InteractWithPlayer(this);
            item.Collect();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        
        if (Input.GetButton("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", jump);
        }
        else
        {
            jump = false;
        }
        
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    void FixedUpdate()
    {
        characterController2D.Move(horizontalMove * Time.fixedDeltaTime , false , jump); 
    }

}
