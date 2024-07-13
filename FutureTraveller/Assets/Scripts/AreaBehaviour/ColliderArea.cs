using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum areaType
{
    area1,
    area2,
    area3,
    area4,
}
public class ColliderArea : MonoBehaviour
{
    [SerializeField] areaType areaType;

    private void OnTriggerStay2D(Collider2D collision)
    {
        DamageDealer damageDealer = collision.GetComponent<DamageDealer>();

        if (damageDealer != null)
        {
            if (collision.CompareTag("Player"))
            {
                //Debug.Log(areaType);

                if (areaType == areaType.area1)
                {
                    PlayerStatics.Instance.area1Stay = true;
                }
                else
                {
                    PlayerStatics.Instance.area1Stay = false;
                }

                if (areaType == areaType.area2)
                {
                    PlayerStatics.Instance.area2Stay = true;
                }
                else
                {
                    PlayerStatics.Instance.area2Stay = false;
                }

                if (areaType == areaType.area3)
                {
                    PlayerStatics.Instance.area3Stay = true;
                }
                else
                {
                    PlayerStatics.Instance.area3Stay = false;
                }

                if (areaType == areaType.area4)
                {
                    PlayerStatics.Instance.area4Stay = true;
                }
                else
                {
                    PlayerStatics.Instance.area4Stay = false;
                }
            }
        }
    }
}
