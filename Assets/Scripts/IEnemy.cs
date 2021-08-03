using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy
{
    void AddDamage(float damage);
    void MoveSpeed(float speed);
}