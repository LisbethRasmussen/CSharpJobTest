using System.Collections;
using UnityEngine;

namespace com.brainplus.jobtest.coroutines.scenario1
{
    /// <summary>
    /// Using a coroutine, call <see cref="Finish"/> after 3 seconds using <see cref="WaitForSeconds"/>.
    /// You are not allowed to use the <see cref="Time"/> or <see cref="System.DateTime"/> classes.
    /// </summary>
    public class Coroutines_Scenario1 : JobTestMonoBehaviour
    {
        public override string Instructions => "Using a coroutine, call Finish after 3 seconds using WaitForSeconds. You are not allowed to use the Time or DateTime classes.";

        //New----------------
        //Reason for creating a catch: using 'new' during runtime is not good for optimization.
        private WaitForSeconds waitTime = new WaitForSeconds(3.0f);
        //New----------------

        void Start()
        {
            //Finish(); // TODO: Call after 3 second delay

            //New----------------
            StartCoroutine(WaitBeforeFinish()); ;
            //New----------------

        }

        //New----------------
        IEnumerator WaitBeforeFinish() {
            yield return waitTime;
            Finish();
        }
        //New----------------

        /// <summary>
        /// You are not allowed to change this function.
        /// </summary>
        void Finish()
        {
            Debug.Log($"Finish: {this.name}");
        }
    }
}
