using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Bird bird;
    public GameObject Bullet;
    [SerializeField] private Transform BulletSpawnPos;
    [SerializeField] private int Ammunition;
    [SerializeField] private Text ammoText;
    void Update()
    {
        ShootBullet();
        ammoText.text = Ammunition.ToString();
    }

    private void ShootBullet(){
        if(Input.GetMouseButtonDown(1) && !bird.IsDead()){
            if(Ammunition >= 1){
                Instantiate(Bullet, BulletSpawnPos.transform.position,Quaternion.identity);
            }
            Ammunition -= 1;
            if(Ammunition < 0){
                Ammunition = 0;
            }
        }
    }


    public void AddAmmo(int BulletCount){
        Ammunition += BulletCount;
    }
}
