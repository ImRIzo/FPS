using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10.0f;
    public float range = 100.0f;
    public Camera fpsCam;
    public ParticleSystem MuzzleFlash;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        MuzzleFlash.Play();
        AudioSource GunAudio = GetComponent<AudioSource>();
        GunAudio.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }

}
