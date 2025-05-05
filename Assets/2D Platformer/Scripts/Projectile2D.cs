using UnityEngine;

public class Projectile2D : MonoBehaviour
{
    [SerializeField] Rigidbody2D bulletprefab;
    [SerializeField] Transform shootPoint;

    void Update()
    {
        //Shooting
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Get click point
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            Debug.DrawRay(ray.origin, ray.direction * 3f, Color.red, 3f);

            if (hit.collider != null)
            {

                Vector2 projectileVelocity = CalculatProjectileVelocity(shootPoint.position, hit.point, 1f);

                Rigidbody2D shootBullet = Instantiate(bulletprefab, shootPoint.position, Quaternion.identity);

                shootBullet.linearVelocity = projectileVelocity;
            }
        }
    }


    Vector2 CalculatProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 distance = target - origin;

        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;

        Vector2 projectileVelocity = new Vector2(velocityX, velocityY);

        return projectileVelocity;
    }
}