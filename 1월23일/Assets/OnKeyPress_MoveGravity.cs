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
    Rigidbody2D rbody;

    float initiateSpeed = speed;  // item3 을 위한 것 // 난이도 조절 -> public 으로 바꾸기
    int flag = 0;
    int initTime = -1;
    float fLimitTime = 5.0f;
    float fTime;

    float initateJumpPower = jumppower; //item4 를 위한 것
    float fLimitTime2 = 7.0f;
    float fTime2;

    public static int badItem = 0; //item5 를 위한 것
    float fLimitTime3 = 7.0f;
    float fTime3;

    void Start ()// 처음에 시행한다
    { 
        // 충돌 시에 회전시키지 않는다 
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;

        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = this.jumpSound;
        this.GetComponent<AudioSource>().loop = false;
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
            fTime3 += Time.deltaTime;
            if(fTime3 >= fLimitTime3)
            {
                badItem = 0;
                fTime3 = 0f;
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
        // 만약 스페이스키가 눌렸을 때 발이 무언가에 닿았다면 
        if (Input.GetKey("up") && groundFlag)
        { 
            if (pushFlag == false)// 계속 누르고 나가지 않으면
            { 
                jumpFlag = true; // 점프 준비 
                pushFlag = true; // 계속 누른 상태 
            }
        } else
        {
            pushFlag = false; // 계속 누른 상태 해제 
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
            jumpFlag = false;
            rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
            //mySfx.PlayOneShot(jump2);
            this.GetComponent<AudioSource>().Play();
        }

        // 새로 추가한 부분 (속도 조절 아이템)

        /*initTime = -1;
        int curTime = Forever_ShowCount_score.lastScore;

        if (flag == 0 && initiateSpeed != speed)
        {
            initTime = Forever_ShowCount_score.lastScore;
            flag = 1;
        }
        if(initTime + 10 < curTime && flag == 1)
        {
            speed = initiateSpeed;
            flag = 0;
        }*/

        

    }
    void OnTriggerStay2D(Collider2D collision)
    { // 발이 무언가에 닿으면 
        groundFlag = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    { // 발에 아무 것도 닿지 않으면 
        groundFlag = false;
    }
}