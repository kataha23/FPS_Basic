using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GunSO gunSO;
    private float CoolTime;
    private float ShootTime = 0;


    private void Start()
    {
        CoolTime = gunSO.CoolTime;
    }

    // Update is called once per frame
    void Update()
    {
        HandleFire();
    }

    private void HandleFire()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame
            && ShootTime + CoolTime <= Time.time)
        {
            Fire();
        }
    }

    public void Fire()
    {
        ShootTime = Time.time;

        Bullet instance = Instantiate(bullet, transform.position, Quaternion.identity).GetComponent<Bullet>();
        instance.BulletSpeed = gunSO.BulletSpeed;
        Camera cam = Camera.main;
        Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
        instance.transform.forward = ray.direction;
    }   

}
