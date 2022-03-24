using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    public bool taNoChao;
    public Transform detectaChao;
    public LayerMask chao;
    public int pulosExtras = 1;

    public Animator anim;

    private Vector3 facingRight;
    private Vector3 facingLeft;
    private float direction;

    private Collider2D colisor; 


    private void Start()
    {
        facingRight = transform.localScale;
        facingLeft = transform.localScale;
        facingLeft.x = facingRight.x * -1;
        rb = GetComponent<Rigidbody2D>();
        colisor = GetComponent<Collider2D>();

    }

    private void Update()
    {
        direction = Input.GetAxis("Horizontal");

        if(direction > 0){
            //olhando para a direita
            transform.localScale = facingRight;

        }
        if(direction < 0){
            //olhando para a esquerda
            transform.localScale = facingLeft;
        }

        taNoChao = Physics2D.OverlapCircle(detectaChao.position, 0.2f, chao);
        Move();
        Jump();
    }

    void Move(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
        anim.SetFloat("speed", movement.sqrMagnitude);

    }

    void Jump(){

        if(Input.GetButtonDown("Jump") && taNoChao == true){
            gameObject.GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * 5;
        }
         if(Input.GetButtonDown("Jump") && taNoChao == false && pulosExtras > 0){
            gameObject.GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * 5;
            pulosExtras--;
        }
        if (taNoChao){
            pulosExtras = 1;
        }
    }

    void OnTriggerEnter2D (Collider2D collider){
         if (collider.gameObject.layer == 7)
        {
            colisor.isTrigger = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
