using UnityEngine;

public class AnimatorStateReseter
{
    /// <summary>
    /// Reset current state because Swapping Animator.runtimeAnimatorController with an AnimatorOverrideController
    /// based on the same AnimatorController at runtime doesn't reset current state.
    /// </summary>
    /// <param name="animator"></param>
    public static void ResetCurrentAnimatorState(Animator animator, int layer, int startingTime)
    {
        // Push back state
        animator.Play(animator.GetCurrentAnimatorStateInfo(0).nameHash, layer, startingTime);

        // Force an update
        animator.Update(startingTime);
    }

}
