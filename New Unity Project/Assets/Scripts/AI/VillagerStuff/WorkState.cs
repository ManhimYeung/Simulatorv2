using UnityEngine;
using StateStuff;
public class WorkState : State<VillagerAI>
{
    private static WorkState _instance;
    private WorkState()
    {
        if (_instance != null)
            return;
        _instance = this;
    }
    public static WorkState Instance
    {
        get
        {
            if (_instance == null)
                new WorkState();
            return _instance;
        }
    }
    public override void EnterState(VillagerAI _owner)
    {
        FindTree(_owner);
    }
    public override void ExitState(VillagerAI _owner)
    {

    }
    public override void UpdateState(VillagerAI _owner)
    {
        Debug.Log("Updating workstate");
    }

    void FindTree(VillagerAI _owner)
    {
        TreeAI[] treesCount = Object.FindObjectsOfType<TreeAI>();
        _owner.target = treesCount[0];
        ///<summary>
        ///Just finding the closest tree and move towards the tree
        ///</summary>
        if (treesCount.Length >= 1)
        {
            for (int i = 1; i < treesCount.Length; i++)
            {
                if (Vector3.Distance(treesCount[i].transform.position, _owner.transform.position) < 
                    Vector3.Distance(_owner.target.transform.position, _owner.transform.position))
                    _owner.target = treesCount[i];
            }
            if (_owner.transform.position != _owner.target.transform.position)
            {
                _owner.transform.position = Vector3.MoveTowards(_owner.transform.position, _owner.target.transform.position, _owner.speed * 10 * Time.deltaTime);
            }
        }
        ///<summary>
        ///Tree error message if no trees left which should not happen.
        ///</summary>
        else if (treesCount.Length == 0)
            Debug.Log("No trees left. ");
        ///<summary>
        ///when the villager is close to the tree, chop the tree by going inside like the elves in war3
        /// </summary>
        
        if (_owner.target != null)
        {
            if (Vector3.Distance(_owner.gameObject.transform.position, _owner.target.transform.position) < 0.5f)
            {
                ///<summary>
                ///not sure how I will make the villager chop the tree yet.
                /// </summary>
                
            }
        }
    }
}
