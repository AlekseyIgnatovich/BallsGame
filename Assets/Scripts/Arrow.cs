using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    /* Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.rotation.
    }
    */
    public Vector3 direction;
    void Update()
    {
        // Получаем позицию мыши в мировых координатах
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z; // Для 2D игр игнорируем ось Z
        // Определяем направление к позиции мыши
        direction = mousePos - transform.position;
        // Вычисляем угол поворота в градусах
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        // Поворачиваем объект, устанавливая его угол поворота
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        if ((-85<angle) && (angle<85))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
        //Debug.Log(angle);
        }
}