using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private Animator ani; // Animator để điều khiển animation của nhân vật

   
    private Rigidbody2D rb;
    private bool isNen;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>(); // Lấy Animator từ đối tượng GameObject này khi bắt đầu chạy
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 scale = transform.localScale;
           //moi vo game player dung yen
        ani.SetBool("isRunning", false);
        //end
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            //animation
            ani.SetBool("isRunning", true);
            //end
            
            scale.x = 0.5f;
            transform.Translate(Vector3.right * 5f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            //animation
            ani.SetBool("isRunning", true);
            //end
            
            scale.x = -0.5f;
            transform.Translate(Vector3.left * 5f * Time.deltaTime);
        }
        //update scale
        transform.localScale = scale;
        
        //nhay len
        if (Input.GetKey(KeyCode.Space))
        {
            if (isNen)
            {
                //transform.Translate(Vector3.up * 5f * Time.deltaTime);
                rb.AddForce(new Vector2(0, 270));
                isNen = false;
            }
           
        }
        //end
        
        //get key: nhan giu nut
        //get key down; nhan phim 1 lan
        //get key up; tha ra
        
    }

       //khi player cham vao gach co tag la nen
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "nen")
        {
            isNen = true;
        }

    }
}
