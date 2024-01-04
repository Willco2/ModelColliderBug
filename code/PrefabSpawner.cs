using Sandbox;

public sealed class PrefabSpawner : Component
{

	[Property] public GameObject Prefab { get; set; }

	protected override void OnStart()
	{
		for ( int i = 0; i < 10; i++ )
		{
			var spawned = SceneUtility.Instantiate( Prefab, new Vector3( i * 25, 0, 0 ) );
			spawned.Parent = GameObject;
			spawned.Transform.LocalPosition = new Vector3( i * 25, 0, 0 );
		}
	}
}
