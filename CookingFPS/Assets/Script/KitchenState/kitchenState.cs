public class Kitchen : monoBehavior
{
    private Vector2 location = Vector2.Zero;
    public Vector2 Position { get => location; set => location = value; }
    

    private string ApplianceType;
    
    public Kitchen(Vector2 location, string type)
    {
        this.location = location;
        this.ApplianceType = type;
    }
    public void GoUp()
    {
        Physics.Jump();
    }
    
    public bool IsAtEnd()
    {
        return atTheEnd;
    }
    public void GoDown()
    {
        MarioMovementState.GoDown();
        IsCrouch = true;
    }
    public void GoLeft()
    {
        
        if (Island)
        {
                MarioMovementState.GoLeft();
        }
        else
        {
            Physics.JumpLeft();
        }
    }
    public void GoRight()
    {
        
        if (Island)
        {
            MarioMovementState.GoRight();
        }
        else
        {
            Physics.JumpRight();
        }
    }
    public void BeDead()
    {
        MarioPowerupState.BeDead();
        MarioMovementState.BeDead();

    }
    
    public void Update()
    {
        MarioSprite.Update();
        Physics.Update();
        if((this.location.X > GameObjectManager.Instance.EndOfLevelXPosition -MarioUtil.FlagpoleBuffer && this.location.X < GameObjectManager.Instance.EndOfLevelXPosition + MarioUtil.FlagpoleBuffer) && !hasCompletedLevel)
        {
            hasCompletedLevel = true;
            ScoringSystem.Instance.AddPointsForRestTime();
            if (MarioPowerupState is NormalMarioPowerupState)
                GameObjectManager.Instance.GameObjectList.SetSingleton(typeof(IMario),new SlideDownFlagDecorator(this, new Vector2(this.location.X, MarioUtil.HeightOfFloor)));
            else
                GameObjectManager.Instance.GameObjectList.SetSingleton(typeof(IMario), new SlideDownFlagDecorator(this, new Vector2(this.location.X, MarioUtil.HeightOfFloor-MarioUtil.MarioHeight)));

            atTheEnd = true;
        }
        if (isOnPipe)
        {
            location.Y++;
        }
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        MarioSprite.Draw(spriteBatch, location);
    }
    public bool IsActive()
    {
        return MarioPowerupState.IsActive();
    }
    
    public void SetIsLand(bool land)
    {
        if (land)
            Island = true;
        else
            Island = false;
    }
    
    public void NoInput()
    {
        MarioMovementState.NoInput();
        if(!(MarioPowerupState is DeadMarioPowerupState))
        Physics.NotJump();
        IsCrouch = false;
    }
        
    public void ThrowProjectile()
    {
        
            MarioPowerupState.ThrowProjectile();
    }

    public void Draw(SpriteBatch spriteBatch, Color c)
    {
        MarioSprite.Draw(spriteBatch, location,c);
    }

    public void SetFalling(bool fallState)
    {
        Fall = fallState;
    }

    public bool IsJump()
    {
        if (MarioMovementState is LeftJumpingMarioMovementState||
            MarioMovementState is RightJumpingMarioMovementState)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}