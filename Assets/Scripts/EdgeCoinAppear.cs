using UnityEngine;
using System.Collections;


public class EdgeCoinAppear : MonoBehaviour {

	private float last_position;
	//private float Edge_begin_position;
	public GameObject CoinPrefab;
	public GameObject BoostPrefab;
	private GameObject Edge1;
	private GameObject Edge2;
	private GameObject Edge3;
	private GameObject Edge4;
	public GameObject Stage1Edge1;
	public GameObject Stage1Edge2;
	public GameObject Stage1Edge3;
	public GameObject Stage1Edge4;
	public GameObject Stage2Edge1;
	public GameObject Stage2Edge2;
	public GameObject Stage2Edge3;
	public GameObject Stage2Edge4;
	public float wherestarStage2;
	public int iUp;
	public float edgeArea_appear_distance;
	public float edge_appear_distance;
	private float camerasize;

	private int edgeNum;
	private float coinshift;
	// Use this for initialization
	void Start () {
		last_position = -50f;
		//Edge_begin_position = transform.position.x;
		camerasize = Camera.main.orthographicSize;
		Edge1 = Stage1Edge1;
		Edge2 = Stage1Edge2;
		Edge3 = Stage1Edge3;
		Edge4 = Stage1Edge4;
		edgeNum = 0;
		coinshift = 0;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x > wherestarStage2) {
			Edge1 = Stage2Edge1;
			Edge2 = Stage2Edge2;
			Edge3 = Stage2Edge3;
			Edge4 = Stage2Edge4;
			coinshift = 1.5f;

		}
		if (transform.position.x - last_position > edgeArea_appear_distance) {
			last_position = transform.position.x;
			System.Random ro = new System.Random();
			int iResult;
			iResult = ro.Next (iUp);
			switch (iResult) {
			case 0:
				scence_wave (iResult);
				break;
			case 1:
				scence_wave (iResult);
				break;
			case 2:
				scence_boost (transform.position.x + 20f, transform.position.y, transform.position.z);
				break;
			case 3:
				scence_general (iResult);
				break;
			}


		}
	}

	public void scence_wave(int iResult){
		for(int i=0;i<iUp;i++)
		{
			float position = transform.position.x + 20f + i*edge_appear_distance;
			edgeNum = (edgeNum + 1) % 4;
			switch (edgeNum) {
			case 0:
				CreateProjectile (Edge1, new Vector3 (position, transform.position.y + camerasize / 2, transform.position.z));
				CreateCoinsChainUp(iResult,position, transform.position.y + camerasize / 2, transform.position.z);

				break;
			case 1:
				CreateProjectile (Edge2, new Vector3 (position, transform.position.y - camerasize / 2, transform.position.z));
				CreateCoinsChainDown(iResult+1,position, transform.position.y + camerasize / 2, transform.position.z);

				break;
			case 2:
				CreateProjectile (Edge3, new Vector3 (position, transform.position.y + camerasize / 2, transform.position.z));
				CreateCoinsChainUp(iResult+2,position, transform.position.y + camerasize / 2, transform.position.z);

				break;
			case 3:
				CreateProjectile (Edge4, new Vector3 (position, transform.position.y - camerasize / 2, transform.position.z));
				CreateCoinsChainDown(iResult+3,position, transform.position.y + camerasize / 2, transform.position.z);

				break;
			}
		}
	
	}
	public void scence_boost(float x,float y,float z){
		CreateBoost (new Vector3(x,y,z));
		for (int i = 2; i<25; i ++) {
		
			CreateCoins(new Vector2(x+i,y-0.5f));
			CreateCoins(new Vector2(x+i,y+0.5f));
		}
	}
	public void scence_general(int iResult){
		for (int i = 0; i < iUp; i++) {
			int ro = Random.Range (0, 2);
			float position = transform.position.x + 20f + i * edge_appear_distance;
			edgeNum = (edgeNum + 1) % 4;
			if (ro == 1) {
				switch (edgeNum) {
				case 0:
					CreateProjectile (Edge1, new Vector3 (position, transform.position.y + camerasize / 2, transform.position.z));
					CreateCoinsChainUp (iResult, position, transform.position.y + camerasize / 2, transform.position.z);

					break;
				case 1:
					CreateProjectile (Edge2, new Vector3 (position, transform.position.y - camerasize / 2, transform.position.z));
					CreateCoinsChainDown (iResult + 1, position, transform.position.y + camerasize / 2, transform.position.z);

					break;
				case 2:
					CreateProjectile (Edge3, new Vector3 (position, transform.position.y + camerasize / 2, transform.position.z));
					CreateCoinsChainUp (iResult + 2, position, transform.position.y + camerasize / 2, transform.position.z);

					break;
				case 3:
					CreateProjectile (Edge4, new Vector3 (position, transform.position.y - camerasize / 2, transform.position.z));
					CreateCoinsChainDown (iResult + 3, position, transform.position.y + camerasize / 2, transform.position.z);

					break;
				}
			}
		}
	}

	public void CreateProjectile(GameObject Edge, Vector2 pos){
		var clone = Instantiate (Edge, pos, Quaternion.identity) as GameObject;

		//clone.transform.localScale = transform.localScale;
	}


	public void CreateCoinsChainUp(int iResult,float x, float y, float z)
	{
		if (iResult != 1)
			return;
		CreateCoins(new Vector3(x-4, y - 0f, z));
		CreateCoins(new Vector3(x-3, y - 1f, z));
		CreateCoins(new Vector3(x-2, y - 2f, z));
		CreateCoins(new Vector3(x-1, y - 3.2f, z));
		CreateCoins(new Vector3(x+0, y - 4f, z));
		CreateCoins(new Vector3(x+1, y - 4.5f, z));
		CreateCoins(new Vector3(x+2, y - 4f, z));
		CreateCoins(new Vector3(x+3, y - 3.2f, z));
		CreateCoins(new Vector3(x+4, y - 2f, z));
		CreateCoins(new Vector3(x+5, y - 1f, z));
		CreateCoins(new Vector3(x+6, y - 0f, z));

	}
	public void CreateCoinsChainDown(int iResult,float x, float y, float z)
	{
		x += coinshift;
		if (iResult != 1)
			return;
//		float iy = -5.0f;
//		int xxx = 1;
//		for (int ix = -5; ix < 6; ix++) {
//			CreateCoins (new Vector3 (x + ix, y + iy, z));
//			if (iy > 0)
//				xxx = -1;
//			iy = iy + xxx;
//		}
		CreateCoins(new Vector3(x-5, y - 5f, z));
		CreateCoins(new Vector3(x-4, y - 4f, z));
		CreateCoins(new Vector3(x-3, y - 3f, z));
		CreateCoins(new Vector3(x-2, y - 2.2f, z));
		CreateCoins(new Vector3(x-1, y - 1.4f, z));
		CreateCoins(new Vector3(x-0, y - 1f, z));
		CreateCoins(new Vector3(x+1, y - 1.4f, z));
		CreateCoins(new Vector3(x+2, y - 2.2f, z));
		CreateCoins(new Vector3(x+3, y - 3f, z));
		CreateCoins(new Vector3(x+4, y - 4f, z));
		CreateCoins(new Vector3(x+5, y - 5f, z));
		CreateCoins(new Vector3(x+6, y - 6f, z));

	}


	public void CreateCoins(Vector2 pos)
	{
		var clone = Instantiate(CoinPrefab, pos, Quaternion.identity) as GameObject;

		//clone.transform.localScale = transform.localScale;
	}

	public void CreateBoost(Vector2 pos)
	{
		var clone = Instantiate(BoostPrefab, pos, Quaternion.identity) as GameObject;

		//clone.transform.localScale = transform.localScale;
	}
}