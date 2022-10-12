using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class ProjectileController : MonoBehaviour
    {
        [SerializeField] private Projectile projectilePrefab;

        private float reloadTime;
        private float distance;
        private float velocity;
        

        private void Shoot()
        {
            var pr = Instantiate(projectilePrefab, transform);
            pr.Init(distance,velocity);
        }

        public void StartShooting(float reloadTime,float distance,float velocity)
        {
            this.reloadTime = reloadTime;
            this.distance = distance;
            this.velocity = velocity;
            StartCoroutine(ShootingWithDelay());
        }


        private IEnumerator ShootingWithDelay()
        {
            while (true)
            {
                Shoot();
                yield return new WaitForSeconds(reloadTime);
            }
        }
    }
}