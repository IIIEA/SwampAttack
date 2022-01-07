using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    public override IEnumerator Shoot(Transform shootPoint)
    {
        int countOfBurstShots = 5;
        var fireRate = new WaitForSeconds(0.1f);

        for (int i = 0; i < countOfBurstShots; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);

            yield return fireRate;
        }
    }
}
