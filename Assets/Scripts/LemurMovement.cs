//https://answers.unity.com/questions/26177/how-to-create-a-basic-follow-ai.html
using UnityEngine;
using UnityEngine.AI;

public class LemurMovement : MonoBehaviour{
    public float lookRadius = 10f;
    Transform target;
    NavMeshAgent agent;
    //private Animation anim;

    // Start is called before the first frame update
    void Start(){
        target = TrackPlayer.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update(){
        float distance = Vector3.Distance(target.position, transform.position);

        if(distance <= lookRadius){
            agent.SetDestination(target.position);
            //Stop();

            if(distance <= agent.stoppingDistance){
                //face the target
                FaceTarget();
            }
        }
	}

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    public void Stop(){
        //anim.Stop();
    }

    void FaceTarget(){
        //get direction to target
        Vector3 direction = (target.position - transform.position).normalized;

        //get rotation by pointing to target
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));

        //update player rotation - Quaternion for smooth rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
}
