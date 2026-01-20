# Spagetti code class diagram
```mermaid


---
Title: Class diagram TD
---

classDiagram

ProjectileBehavior ..> Enemies
ProjectileBuffs ..> TowerAttacks
TowerAttacks ..> BaseUI
TowerAttacks ..> ProjectileBehavior
TowerSwitchAttacks <|-- TowerAttacks 

class BaseUI{
    + ListChange : event Action
    - Health : TMP_Text
    - mana : TMP_Text
    - hp : float
    - closeButtonText : TMP_Text
    - speedUpButton : GameObject
    - PauseSprites : List~Sprite~
    - enemyScripts : GameObject[]
    - waveSpawner : Spawner
    - list : GameObject
    - listOpen : bool
    + isPaused : bool
    - spedup : bool
    - buyList : List~TowerBuy~
    - manaCount : float
    - manaCostText : List~TMP_Text~

    - Start() : void
    - Update() : void
    - WavesUI(wavecount : string) : void
    - Health(dmg : float) : void
    - Mana(manaCout : float) : void
    + OnPauseButtonClick() : void
    + OnSpeedUpButtonClick() : void
    + OnCloseButtonClick() : void
    + OnQuitButtonClick() : void
}

class Enemies{
    + OnEndpointReached : Action event
    - dmg : float
    + hp : float
    + speed : float
    + manaWorth : float
    - waypoints : Transform[]
    - maxDistance : float
    - targetwaypoint : Transform
    - targetIndex : int
    + startSpeed : float
    + speedChangeTimer : float
    - Start() : void
    - Update() : void
    - FollowWaypoints(waypoint : Transform) : void
    - CheckArrival() : void
    - NextTarget() : Transform
}

class ExtraUIscreens{
    + OnQuit() : void
    + OnStart() : void
}

class JellyfishBuffs{
    - buff : GameObject
    - Start() : void
}

class ManaSystem{
    + OnManaChange : Action event
    - manaCounter : float
    - Start() : void
    - AfterStart() : void
    - ManaChange(mana : float) : void
}

class ProjectileBehavior{
    + OnDeath : Action event
    - speed : float
    - dmg : float
    - hp : Enemies
    - checkTarget : Transform
    + fireProjectile(target : Transform, dealtdamage : float) : void
    - OnCollisionEnter2D(collision : Collision2D) : void
}

class ProjectileBuffs{
    - collisioncount : float
    - OnCollisionEnter2D(collision : Collision2D) : void
}

class SceneManagerScript{
    - Start() : void
}

class Spawner{
    + ManaPerEnemy : Action event
    + OnWaveIncrease : Action event
    - waveCount : int 
    - waveMax : float
    - enemy : GameObject
    - boss : GameObject
    - enemyMax : float
    - enemyCount : float
    - enemyDeaths : float
    - timer : float
    - bossCount : float
    - bossMax : float
    - Deathtimer : float
    - interval : float
    - ManaPerDeath : float
    - Start() : void
    - Update() : void
    - AfterStart() : void
    - EnemySpawner() : void
    - EnemyWaveSpawnIncrease(waveCount : int) : void
    - EnemyDeathCounter(mana : float) : void
    - EnemiesEndPointReached(dmg : float) : void
    - TowerSpawn(position : Transform, tower : GameObject) : void
}

class TowerAttacks{
    - castDistance : float
    - PlayerLayer : LayerMask
    - boxSize : Vector2
    - castTime : float
    - Paused : BaseUI
    - hit : RaycastHit2D
    - timeElapsed : float
    - spawnPosition : Vector3
    - behavior : ProjectileBehavior
    - projectileInstance : GameObject
    - target : Transform
    - projectiledmg : float
    + buff : float
    - projectile : GameObject
    - Start() : void
    - Update() : void
    - OnDrawGizmos() : void
    - projectileDmgSwitch() : void
    # projectileFire() : void
}

class TowerBuy{
    + placedTowers : Action event
    + BuyTowerMana : Action event
    + manaCost : float
    - tower : GameObject
    - difference : Vector2
    - startPosition : Vector2
    - onPath : bool
    - spriteRenderer : SpriteRenderer
    - colliderTimer : float
    - closed : bool
    - defaultSprite : Sprite
    - mana : float
    - Start() : void
    - Update() : void
    - OnMouseDown() : void
    - OnMouseDrag() : void
    - OnCollisionEnter2D(Collision2D collision) : void
    - OnCollisionStay2D(Collision2D collision) : void
    - OnListChange() : void
    - CheckMana(manaCount : float) : void
}

class TowerSwitchAttacks{
    # projectiles : List~GameObject~
    - projectilenumber : int
    - Clicked : bool
    - Sr : SpriteRenderer
    # ProjectileSelect() : GameObject
    # getProjectileNumber() : int
    - OnMouseEnter() : void
    - OnMouseDown() : void
    - OnMouseExit() : void
}