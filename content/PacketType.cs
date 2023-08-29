namespace Jaket.Content;

/// <summary> All packet types. Will replenish over time. </summary>
public enum PacketType
{
    /// <summary> Data of an entity, usually a player or an enemy. </summary>
    Snapshot,
    /// <summary> Host asks to load a level, the packet contains its name. </summary>
    LevelLoading,

    /// <summary> Owner of the lobby has died, which means you need to destroy all enemies. </summary>
    HostDied,
    /// <summary> Enemy has died, which means you need to kill him locally. </summary>
    EnemyDied,
    /// <summary> Boss has died, which means you need to kill his original enemy identifier. </summary>
    BossDefeated,

    /// <summary> Client ask the creation of a bullet. </summary>
    SpawnBullet,
    /// <summary> Client dealt damage to an entity. </summary>
    DamageEntity,

    /// <summary> Need to open a certain door. Called by the host so that clients don't get stuck in a room. </summary>
    OpenDoor,
    /// <summary> Need to activate a certain object. It can be anything, because there are a lot of different stuff in the game. </summary>
    ActivateObject
}