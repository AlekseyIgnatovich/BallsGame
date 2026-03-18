using System;
using UnityEngine;

public class BallsManager : MonoBehaviour
{
    float timer = 0f;
    [SerializeField] float interval = 1.0f;                        //что отображалась строка в инспекторе (+каждую секунду) (для быстрого доступа)
    [SerializeField] GameObject prefab;
    [SerializeField] Ball startBall;
    [SerializeField] RotateToMouse rotateToMouse;
    bool pressed = false;
  

    void Update()
        //создавать шар раз в секунду
    {
        if (Input.GetMouseButtonUp(0) &&  pressed == false)                 //при первом нажатии шарик начинае движение
        {
            //Debug.Log("Нажат левый клик.");
            pressed = true;
            Vector3 direction = rotateToMouse.direction.normalized;
            // Перемещение объекта с учётом скорости и времени
            startBall.StartMove(direction);
        }
        /* if ((pressed == true) && (startBall != null))
        {
            startBall.transform.Translate(direction * speed * Time.deltaTime);
        }*/
    }

    /*{
        timer += Time.deltaTime;
        if (timer >= interval) {
            Instantiate(prefab);
            timer = 0f;
            Debug.Log(timer);
        }
    }*/

    void Start()
    {
        startBall.SetColor();                                   //метод задает цвет основному шарику
        for (int y = 0; y < 5; y++)
        {
            for (int x = -10; x <= 10; x++)
            {
                float pozx = x;
                GameObject sphere = Instantiate(prefab);        //объект сфера создается из префаба
                Ball ball = sphere.GetComponent<Ball>();        //у сферы беретсы компоент Ball
                if (y % 2 != 0)                                 //сдвигаем шарики на половинку
                {
                    pozx = 0.5f+x;
                }
               sphere.transform.position = new Vector3(pozx, y, 0);         //определяем положение всех сфер относительно осей, можно сделать то же самоу через GetComponen
               ball.SetColor();
            }
        }
    }
    
}
