#if CMPSETUP_COMPLETE
using Fusion;
using UnityEngine;

namespace AvocadoShark
{
    public class PlayerPosResetter : NetworkBehaviour
    {
        public float minYValue = -10f;

        void LateUpdate()
        {
            if (HasStateAuthority)
            {
                if (transform.position.y < minYValue)
                {
                    ResetPlayerPosition();
                }
            }
        }
        void ResetPlayerPosition()
        {
            if (FusionConnection.Instance.UseCustomLocation)
                transform.position = FusionConnection.Instance.CustomLocation;
            else
                transform.position = new Vector3(Random.Range(-7.6f, 14.2f), 0, Random.Range(-31.48f, -41.22f));
        }
    }
}
#endif