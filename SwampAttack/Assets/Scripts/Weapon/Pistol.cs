using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public override IEnumerator Shoot(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);

        yield return 0;
    }
}
