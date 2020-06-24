using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //トリガーモードで他のオブジェクトと接触した場合の処理（追加）
    void OnTriggerEnter2D(Collider2D other)
    {

        //障害物に衝突した場合（追加）
        //if (other.gameObject.tag == "CubeTags")
        //{
            // 着地のときにはボリュームを0にする（追加）
            //GetComponent<AudioSource>().volume =  1;
        //}

    }

    //トリガーモードで他のオブジェクトと接触した場合の処理（追加）
    void OnCollisionEnter2D(Collision2D other)
    {

        //障害物に衝突した場合（追加）
        if (other.gameObject.tag == "CubeTags")
        {
            // 着地のときにはボリュームを0にする（追加）
            GetComponent<AudioSource>().volume = 1;
        }

    }

}