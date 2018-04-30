using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowParticle : MonoBehaviour
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
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Destroy")) {
            Destroy(gameObject);
            ScoringController.GetInstance().addScore();
            GameObject p = GameObject.Instantiate(particle, transform.position, transform.rotation);
            Destroy(p, 1);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bullet")) {
            anim.SetBool("isDead", true);
            aiEnemy.StopMove();
        }

        if (collision.gameObject.tag.Equals("Player")) {
            aiEnemy.StopMove();
            SceneManager.LoadScene("Scenes/Gameover");
        }
    }
}
