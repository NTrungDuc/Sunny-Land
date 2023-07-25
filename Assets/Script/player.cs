using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpHeight = 9f;
    Animator animator;
    Rigidbody2D myBody;
    bool grounded;
    public Text txtScore;
    int score = 0;
    int hp = 60;
    public Canvas gameOver;
    public Slider heart;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        float v = Input.GetAxis("Vertical");
        if (v < 0)
        {
            animator.SetBool("crouch", true);
        }else if (v == 0)
        {
            animator.SetBool("crouch", false);
        }
    }
    void Move()
    {
        heart.value = hp;
        float h = Input.GetAxis("Horizontal");
        myBody.velocity = new Vector2(h * speed, myBody.velocity.y);

        if(h > 0)
        {
            Vector3 theScale = transform.localScale;
            theScale.x = 1;
            transform.localScale = theScale;
            animator.SetBool("Speed", true);
        }
        else if (h < 0)
        {
            Vector3 theScale = transform.localScale;
            theScale.x = -1;
            transform.localScale = theScale;
            animator.SetBool("Speed", true);
        }
        else if (h == 0)
        {
            animator.SetBool("Speed", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false;
                animator.SetBool("ground", true);
                myBody.velocity = new Vector2(myBody.velocity.x, jumpHeight);
            }
        }
       if(hp <= 0)
        {
            animator.SetBool("die", true);
            Destroy(gameObject,0.7f);
            gameOver.gameObject.SetActive(true);
            AudioListener.volume = 0f;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "grounded" || collision.gameObject.tag == "fallGR")
        {
            grounded = true;
            animator.SetBool("ground", false);
        }
        
        if(collision.gameObject.tag == "enemies" )
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 4f);
            hp -= 10;
        }
        if (collision.gameObject.tag == "enemies2" )
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 4f);
            hp -= 20;
        }
        if (collision.gameObject.tag == "enemies3" )
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 4f);
            hp -= 15;
        }
        if (collision.gameObject.tag == "spikes")
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 8f);
            hp -= 5;
        }
        if(collision.gameObject.tag == "nextLV")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(collision.gameObject.tag == "skull")
        {
            transform.position = new Vector3(65,-10.5f,0);
        }
        if (collision.gameObject.tag == "doorTele")
        {
            transform.position = new Vector3(83, 13, 0);
        }
        if (collision.gameObject.tag == "piskel")
        {
            transform.position = new Vector3(100, 9, 0);
        }
        if (collision.gameObject.tag == "fall")
        {
            hp = 0;
            myBody.velocity = new Vector2(0, 10f);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemies")
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 10f);

        }
        if (collision.gameObject.tag == "enemies2")
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 10f);

        }
        if (collision.gameObject.tag == "enemies3")
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 10f);
        }
        if (collision.gameObject.tag == "spikes")
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 8f);
            hp -= 5;
        }
        if (collision.gameObject.tag == "cherry")
        {

            Destroy(collision.gameObject);
            score += 10;
            txtScore.text = "Score: " + score.ToString();
        }
        if (collision.gameObject.tag == "coin")
        {

            Destroy(collision.gameObject);
            score += 20;
            txtScore.text = "Score : " + score.ToString();
        }
        if (collision.gameObject.tag == "gold")
        {

            Destroy(collision.gameObject);
            score += 40;
            txtScore.text = "Score : " + score.ToString();
        }
    }
}
