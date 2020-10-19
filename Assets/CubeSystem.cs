using Unity.Entities;

public class CubeSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref CubeComponent cubeComponent) =>
        {
            // Increment level by 1 per second
            //cubeComponent.cube += 1f * Time.DeltaTime;
        });
    }
}
