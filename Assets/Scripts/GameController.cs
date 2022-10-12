using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private ProjectileController projectileController;
        

        public void  InitShooting(float reloadTime,float distance,float velocity)
        {
            projectileController.StartShooting(reloadTime,distance,velocity);
        }
    }
}