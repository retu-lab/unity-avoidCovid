using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 키를 누르면 이동한다(중력 대응판) 
public class OnKeyPress_MoveGravity : MonoBehaviour
{

    public static float speed = 9; // 속도：Inspector에 지정
    public static float jumppower = 16;  // 점프력：Inspector에 지정

    private AudioSource audio;
    public AudioClip jumpSound;

    float vx = 0;
    bool leftFlag = false; // 왼쪽 방향인지 
    bool pushFlag = false; // 스페이스 키가 눌린 상태인지 
    bool jumpFlag = false; // 점프 상태인지 
    bool groundFlag = false; // 발이 무언가에 닿았는지 
    bool buttonFlag = false; // 버튼이 눌린 상태인지
    public static bool leftButtonFlag = false; // 왼쪽버튼 눌린 상태인지
    public static bool rightButtonFlag = false; // 오른쪽 버튼 눌린 상태인지
    Rigidbody2D rbody;

    public static float initiateSpeed = speed;  // item3 을 위한 것 // 난이도 조절 -> public 으로 바꾸기
    int flag = 0;
    int initTime = -1;
    float fLimitTime = 5.0f;
    float fTime;

    public static float initateJumpPower = jumppower; //item4 를 위한 것
    float fLimitTime2 = 7.0f;
    float fTime2;

    public static int badItem = 0; //item5 를 위한 것
    float fLimitTime3 = 7.0f;
    float fTime3;

    SpriteRenderer sprite; // change color of item5


    void Start ()// 처음에 시행한다
    { 
        // 충돌 시에 회전시키지 않는다 
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;

        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = this.jumpSound;
        this.GetComponent<AudioSource>().loop = false;

        sprite = GetComponent<SpriteRenderer>();
    }

    void Update () // 계속 시행한다 
    {
        //item3 개구리 아이템 코드 추가
        if (initiateSpeed != speed)
        {
             fTime += Time.deltaTime;
            if (fTime >= fLimitTime)
            {
                speed = initiateSpeed;
                fTime = 0;

            }
        }
        // item4 빨강 스시 아이템 코드 추가
        if (initateJumpPower != jumppower)
        {
            fTime2 += Time.deltaTime;
            if (fTime2 >= fLimitTime2)
            {
                jumppower = initateJumpPower;
                fTime2 = 0f;
              
            }
        }
        // item5 분홍 스시 아이템 코드 추가
        if(badItem == 1)
        {
            sprite.color = new Color(0f, 1f, 0f, 1);
            fTime3 += Time.deltaTime;
            if(fTime3 >= fLimitTime3)
            {
                badItem = 0;
                fTime3 = 0f;
                sprite.color = new Color(1, 1, 1, 1);
            }
        }

        vx = 0;
        if ((Input.GetKey("right") && badItem == 0 )|| (Input.GetKey("left") && badItem == 1)) // 만약 오른쪽 키가 눌리면
        { 
            vx = speed; // 오른쪽으로 진행하는 이동량을 넣는다
            leftFlag = false;
        }
        if ((Input.GetKey("left") && badItem == 0) || (Input.GetKey("right") && badItem == 1)) // 만약 왼쪽 키가 눌리면
        { 
            vx = -speed; // 왼쪽으로 진행하는 이동량을 넣는다 
            leftFlag = true;
        }
        // 버튼 오른쪽 왼쪽 코드
        if((leftButtonFlag && badItem == 0) || (rightButtonFlag && badItem == 1))
        {
            vx = -speed;
            leftFlag = true;
        }
        if ((rightButtonFlag && badItem == 0) || (leftButtonFlag && badItem == 1))
        {
            vx = speed;
            leftFlag = false;
        }

        // 만약 스페이스키가 눌렸을 때 발이 무언가에 닿았다면 
        if ((Input.GetKey("up") && groundFlag) || buttonFlag && groundFlag)
        { 
            if (pushFlag == false)// 계속 누르고 나가지 않으면
            { 
                jumpFlag = true; // 점프 준비 
                pushFlag = true; // 계속 누른 상태 

            }
        }
        else
        {
            pushFlag = false; // 계속 누른 상태 해제 
            buttonFlag = false;
        }


    }
    void FixedUpdate() // 계속 시행한다(일정 시간마다)
    { 
        // 이동한다(중력을 건 채)
        rbody.velocity = new Vector2(vx, rbody.velocity.y);
        // 왼쪽 오른쪽으로 방향을 바꾼다 
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
        // 만약 점프할 때 
        if (jumpFlag) {
            jumpFunction();
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    { // 발이 무언가에 닿으면 
        groundFlag = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    { // 발에 아무 것도 닿지 않으면 
        groundFlag = false;
    }

    public void jumpFunction()
    {

        jumpFlag = false;
        rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        //mySfx.PlayOneShot(jump2);
        this.GetComponent<AudioSource>().Play();
    }
    public void buttonOn()
    {
        buttonFlag = true;

    }
    public void leftOn()
    {
        leftButtonFlag = true;
        //leftFlag = true;
       // if(badItem == 0)

        //     vx = -speed; // 왼쪽으로 진행하는 이동량을 넣는다 
        //    leftFlag = true;
        // rbody.velocity = new Vector2(vx, rbody.velocity.y);
        /*else
        {
            vx = speed; // 오른쪽으로 진행하는 이동량을 넣는다
            leftFlag = false;
        }*/
    }
    public void rightOn()
    {
        rightButtonFlag = true;
       // if(badItem == 0)
        
       //     vx = speed; // 오른쪽으로 진행하는 이동량을 넣는다
       //     leftFlag = false;
       // rbody.velocity = new Vector2(vx, rbody.velocity.y);
        /* else
         {
             vx = -speed; // 왼쪽으로 진행하는 이동량을 넣는다 
             leftFlag = true;
         }*/
    }
    public void stop()
    {
        leftButtonFlag = false;
        rightButtonFlag = false;    
        vx = 0;
    }
}