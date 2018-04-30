using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDetection : MonoBehaviour
{

    public GameObject particle;
    Animator anim;
    AIEnemyControl aiEnemy;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        aiEnemy = GetComponent<AIEnemyControl>();
    }

    // Update is called once per frame
    void Update()
    {
        // jika animasi pada enemy selesai
        // menghilangkan enemy, menambahkan coin dan menampilkan partikel
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Destroy"))
        {
            Destroy(gameObject);
            ScoringController.GetInstance().addScore();
            GameObject p = GameObject.Instantiate(particle, transform.position, transform.rotation);
            Destroy(p, 1);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // jika enemy terkena peluru
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            anim.SetBool("isDead", true);
            aiEnemy.StopMove();
        }

        // jika enemy terkena player
        if (collision.gameObject.tag.Equals("Player"))
        {
            aiEnemy.StopMove();
            SceneManager.LoadScene("Scenes/Gameover");
        }
    }
}
