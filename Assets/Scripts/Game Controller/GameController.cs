using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region Const
    private const string SYSTEMS_PATH = "Prefabs/Game Systems/";
    #endregion

    #region Properties
    protected Dictionary<string, GameSystem> gameSystems = new Dictionary<string, GameSystem>();
    protected GameObject systemHolder;
    #endregion

    #region MonoBehaviour
    private void Awake()
    {
        systemHolder = transform.GetChild(0).gameObject;
        GameFactory.Create(this);
    }
    
    private void Start()
    {
        Debug.Log($"Get System {GetSystem<MovementSystem>().name}");
    }

    private void Update()
    {
        
        foreach (IGameSystem system in GetSystems())
            system.LogicRoutine();
    }

    private void FixedUpdate()
    {

        foreach (IGameSystem system in GetSystems())
            system.PhysicsRoutine();
    }
    #endregion

    public void InstantiateSystems<T>() where T : GameSystem, IGameSystem, new()
    {
        GameSystem gameSystem = GetComponentInChildren<T>() as GameSystem;

        if (gameSystem == null)
        {
            GameObject gameSystemObj = Instantiate(Resources.Load<GameObject>($"{SYSTEMS_PATH}{typeof(T).Name}"), systemHolder.gameObject.transform);
            gameSystem = gameSystemObj.GetComponent<GameSystem>();
        }

        Debug.Log($"Add System: {typeof(T).Name}");
        gameSystems.Add(typeof(T).Name, gameSystem);        
    }

    public T GetSystem<T>() where T : GameSystem
    {
        var key = typeof(T).Name;
        return gameSystems.ContainsKey(key) ? (T)gameSystems[key] : default(T);
    }

    public List<GameSystem> GetSystems()
    {
        return gameSystems.Values.ToList();
    }
}
