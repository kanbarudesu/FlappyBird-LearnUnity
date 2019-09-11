using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Ground : MonoBehaviour
{
     //Global variables
    [SerializeField] private Bird bird;
    [SerializeField] private float speed = 1;
    [SerializeField] private Transform nextPos;
    
    //Dipanggil setiap frame
    private void Update()
    {
        //Melakukan pengecekan jika burung null atau belu mati
        if (bird == null || (bird != null && !bird.IsDead()))
        {
            //Membuat pipa bergerak kesebelah kiri dengan kecepatan dari variable speed
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
    }
  
    //Method untuk Menenmpatkan game object pada posisi next ground
    public void SetNextGround(GameObject ground)
    {
        //Pengecekan Null value
        if (ground != null)
        {
            //Menempatkan ground berikutnya pada posisi nextground
            ground.transform.position = nextPos.position;
        }
    }

    //Dipanggil ketika game object bersentuhan dengan game object yang lain
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Membuat burung mati ketika bersentuhan dengan game object ini
        if (bird != null && !bird.IsDead())
        {
            bird.Dead();
        }
    }
}
